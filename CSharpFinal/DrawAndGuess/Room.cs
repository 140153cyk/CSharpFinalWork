using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Collections.Concurrent;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Timers;

namespace DrawAndGuess
{
    public class Room
    {
        private string currentPoem;
        public bool IsNextTurn { set; get; } = false;
        //统计答对的人数
        public int CorrectCount { set; get; } = 0; 
        //房间人数
        public int PlayerNum { set; get; }

        /// <summary>
        /// 游戏开始后，轮到当前玩家
        /// </summary>

        private Socket currentPlayer = null;
        //准备了的玩家的队列
        //准备时加入队列，开始游戏时按照该队列轮流画画，画过了的移除队列
        public ConcurrentQueue<Socket> ActivePlayers { get; set; } = new ConcurrentQueue<Socket>();
        //加入房间的玩家的队列
        public ConcurrentDictionary<Socket, string> Players { get; set; } = new ConcurrentDictionary<Socket, string>();
        public bool IsPlaying { get; set; }

        public int RoomId { get; set; }

        public string Name { get; set; }

        public Room(string name, int maxMem, int id)
        {
            Name = name;
            MaxMem = maxMem;
            RoomId = id;
        }

        /// <summary>
        /// 房间容纳的最大人数
        /// </summary>
        public int  MaxMem = 10;

        /// <summary>
        /// 删除一个玩家
        /// </summary>
        /// <param name="player"></param>
        public void RemovePlayer(Socket player)
        {
            Players.TryRemove(player, out string playerName);
            SendMessage(ConvertMessageForServer(playerName + "退出房间", 1));
        }

        /// <summary>
        /// 添加玩家
        /// </summary>
        /// <param name="player"></param>
        /// <param name="playerName"></param>
        public void AddPlayer(Socket player, string playerName)
        {
            Players.TryAdd(player, playerName);
            SendMessage(ConvertMessageForServer(playerName + "加入房间", 0));
        }

        /// <summary>
        /// 玩家准备
        /// </summary>
        /// <param name="player"></param>
        public void PlayerGetReady(Socket player)
        {
            ActivePlayers.Enqueue(player);
            SendMessage(ConvertMessageForServer(Players[player] + "准备", 2));
            if (ActivePlayers.Count == Players.Count && Players.Count > 1)
            {
                Thread t = new Thread(StartGame);
                t.IsBackground = true;
                t.Start();
            }///房间玩家数等于准备玩家数,且房间不止一人
        }

        /// <summary>
        /// 游戏开始
        /// </summary>
        public void StartGame()
        {
            while (ActivePlayers.Count > 0)
            {
                //获得题目

                //获得玩家
                ActivePlayers.TryDequeue(out currentPlayer);
                string name;
                Players.TryGetValue(currentPlayer, out name);
                //开启一个时钟
                System.Timers.Timer timer = new System.Timers.Timer
                {
                    Enabled = true,
                    Interval = 60000, //一分钟
                    AutoReset = false
                };
                timer.Start();
                timer.Elapsed += new ElapsedEventHandler(NextTurn);
                //该玩家画画，其他玩家猜
                //给所有玩家发当前画画的玩家姓名和题目，client受到该信息时，同样开启一个时钟，代表本轮开始
                SendMessage(ConvertMessageForServer(name + " " + currentPoem, 8));
                while (!(IsNextTurn || CorrectCount >= PlayerNum - 1))//时间到或者所有人答对时退出循环
                {
                    //等待
                }
                //该轮结束
                timer.Stop();
                timer.Dispose();
                IsNextTurn = false;
                CorrectCount = 0;
            }

            Socket Winner;
            ActivePlayers.TryDequeue(out Winner);
            Winner.Send(ConvertMessageForServer("", 9));
        }

        public void Judge(Socket player, string message)
        {
            if (message == currentPoem)
            {
                SendMessage(ConvertMessageForServer(Players[player] + " : 回答正确" , 5));//将信息发送给所有玩家
            }
            else
            {
                SendMessage(ConvertMessageForServer(Players[player] + " : " + message, 5));//将信息发送给所有玩家
            }
        }

        private void NextTurn(object source, ElapsedEventArgs e)
        {
            IsNextTurn = true;
        }

        /// <summary>
        /// 在数据库搜索是否含有数据
        /// </summary>
        /// <param name="message">诗句</param>
        /// <returns></returns>
        public bool IsPoem(string message)
        {
            return true;
        }

        /// <summary>
        /// 将信息发送给所有玩家
        /// </summary>
        /// <param name="buffer"></param>
        public void SendMessage(byte[] buffer)
        {
            var task1 = new Task(() =>
            {
                foreach(var player in Players)
                {
                    player.Key.Send(buffer);
                }
            });
            task1.Start();
        }

        /// <summary>
        /// 将画发给其他玩家
        /// </summary>
        public void SendImage(string name,string image)
        {
            byte[] buffer = ConvertMessageForServer(image, 7);
            var task1 = new Task(() =>
            {
                foreach (var player in Players)
                {
                    if (player.Value == name) continue;
                    player.Key.Send(buffer);
                }
            });
            task1.Start();
        }


        /// <summary>
        /// 房间信息为ID+Name+名字+IsPlaying+房间状态+玩家人数+最大房间人数，使用空格分开
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return RoomId.ToString() + " " + Name + " " + IsPlaying +" " +  Players.Count+" "+ MaxMem;
        }

        /// <summary>
        /// 用来包装需要发送给玩家的信息
        /// 0 代表有新的玩家加入,消息体格式为“{玩家姓名}加入房间”
        /// 1 代表有玩家退出，消息体格式为“{玩家姓名}退出房间”
        /// 2 代表玩家准备，消息体格式为“{玩家姓名}准备”
        /// 3 代表发送所有房间列表，消息体格式为“{房间ID} {房间名字} {游玩状态} {当前玩家数量} {最大玩家数量}”
        /// 4 
        /// 5 代表玩家发言，消息体格式为“{玩家姓名} ： {玩家发言}”
        /// 6 代表发送房间ID，消息体格式为“{房间ID}”
        /// 7 代表发送画的信息，消息体格式为“{画}”
        /// 8 代表本轮开始，轮到某玩家画画，并发送题目，消息体格式为“{玩家姓名} {题目}”
        /// 9 代表某游戏胜利，无消息体
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public byte[] ConvertMessageForServer(string message, int type)
        {
            List<byte> newBuffer = new List<byte>();
            byte[] buffer;
            newBuffer.Add((byte)type);
            buffer = Encoding.UTF8.GetBytes(message);
            newBuffer.AddRange(buffer);
            return newBuffer.ToArray();
        }
    }
}
