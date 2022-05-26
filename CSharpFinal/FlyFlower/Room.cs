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

namespace FlyFlower
{
    public class Room
    {
        private System.Threading.Timer tmr;
        private readonly string[] KeyWords = { "月", "酒", "花", "风", "春", "夏", "秋", "冬", "夜", "叶" };

        private string currentKeyWord;
        enum PlayerState
        {
            noResponse,
            wrongResponse,
            rightResponse
        }

        /// <summary>
        /// 游戏开始后，表示当前玩家的状态
        /// </summary>
        private PlayerState currentState;

        /// <summary>
        /// 游戏开始后，轮到当前玩家
        /// </summary>
        private Socket currentPlayer = null;

        /// <summary>
        /// 存放访问过的诗句
        /// </summary>
        public ConcurrentBag<string> visited { get; set; } = new ConcurrentBag<string>();
        public ConcurrentQueue<Socket> ActivePlayers { get; set; } = new ConcurrentQueue<Socket>();
        public ConcurrentDictionary<Socket, string> Players { get; set; } = new ConcurrentDictionary<Socket, string>();
        public bool IsPlaying { get; set; }

        public int RoomId { get; set; }

        public string Name { get; set; }

        public Room(string name, int maxMem, int id)
        {

            Name = name;
            MaxMem = maxMem;
            RoomId = id;
            IsPlaying = false;
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
            //在玩家列表中删除该玩家
            Players.TryRemove(player, out string playerName);
            //在准备队列中删除该玩家
            Socket[] sockets = ActivePlayers.ToArray();
            sockets = sockets.Where(s => s!= player).ToArray();
            Socket socket;
            while (!ActivePlayers.IsEmpty)
            {
                ActivePlayers.TryDequeue(out socket);
            }
            foreach (Socket s in sockets)
            {
                ActivePlayers.Enqueue(s);
            }
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
            Socket[] active = ActivePlayers.ToArray();
            string playerList = "";
            foreach(var p in Players)
            {
                if (active.FirstOrDefault(a => a == p.Key) != null)//处在准备队列中
                {
                    playerList += p.Key + " " + "已经准备";
                }
                else
                {
                    playerList += p.Key + " " + "没有准备";
                }
            }
            player.Send(ConvertMessageForServer(playerList, 10));
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
            Random random = new Random();
            currentKeyWord = KeyWords[random.Next(0, 10)];
            IsPlaying = true;
            SendMessage(ConvertMessageForServer(currentKeyWord, 11));
            while(ActivePlayers.Count > 1)
            {
                ActivePlayers.TryDequeue(out currentPlayer);
                currentState = PlayerState.noResponse;
                //开启一个时钟
                tmr = new System.Threading.Timer(new TimerCallback(OutOfTime),null, Timeout.Infinite, 1000);
                currentPlayer.Send(ConvertMessageForServer("", 8));
                while(currentState == PlayerState.noResponse)
                {
                    //等待state改变
                }
                if(currentState == PlayerState.rightResponse)
                {
                    ActivePlayers.Enqueue(currentPlayer);
                    continue;
                }
                if(currentState == PlayerState.wrongResponse)
                {
                    currentPlayer.Send(ConvertMessageForServer("", 7));
                    continue;
                }
                tmr.Dispose();
            }
            IsPlaying = false;
            Socket Winner;
            ActivePlayers.TryDequeue(out Winner);
            Winner.Send(ConvertMessageForServer("", 9));
            SendMessage(ConvertMessageForServer("", 12));
        }

        /// <summary>
        /// 计时器超时
        /// </summary>
        /// <param name="o"></param>
        private void OutOfTime(object o)
        {
            currentState = PlayerState.wrongResponse;
        }

        /// <summary>
        /// 判断玩家发言是否正确
        /// </summary>
        /// <param name="player"></param>
        /// <param name="message"></param>
        public void Judge(Socket player, string message)
        {
            //如果没有轮到当前玩家发言，不做判断
            if(player == currentPlayer)
            {
                //带有关键字且是诗句
                if (Regex.IsMatch(message, @"\w*" + currentKeyWord + @"\w*")&&IsPoem(message))
                {
                    currentState = PlayerState.rightResponse;
                 }
                else
                {
                    currentState = PlayerState.wrongResponse;
                }
            }
            SendMessage(ConvertMessageForServer(Players[player] + " : " + message, 5));//将信息发送给所有玩家
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
        /// 4 代表有玩家失败，消息体格式为“{玩家姓名}失败了”
        /// 5 代表玩家发言，消息体格式为“{玩家姓名} ： {玩家发言}”
        /// 6 代表发送房间ID，消息体格式为“{房间ID}”
        /// 7 代表本玩家失败了，无消息体
        /// 8 代表轮到本玩家飞花，无消息体
        /// 9 代表某游戏胜利，无消息体
        /// 10 代表玩家列表，消息体为“{玩家姓名} {准备状态}”
        /// 11 代表游戏开始，消息体为“{飞花关键字}”
        /// 12 代表游戏结束，无消息体
        /// </summary>{
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
