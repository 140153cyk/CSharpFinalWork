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
using System.Text.RegularExpressions;

namespace Server
{
    public abstract class BasicRoom
    {
        protected string Name;

        /// <summary>
        /// 房间ID
        /// </summary>
        protected int RoomId { get; set; }

        /// <summary>
        /// 游玩状态
        /// </summary>
        protected bool IsPlaying { get; set; }

        /// <summary>
        /// 最大游玩数量
        /// </summary>
        protected int MaxMem { get; set; }

        /// <summary>
        /// 所有玩家的列表
        /// </summary>
        protected ConcurrentDictionary<Socket, string> Players { get; set; } = new ConcurrentDictionary<Socket, string>();

        /// <summary>
        /// 准备玩家的队列
        /// </summary>
        protected ConcurrentQueue<Socket> ReadyPlayers { get; set; } = new ConcurrentQueue<Socket> ();

        /// <summary>
        /// 添加玩家
        /// </summary>
        /// <param name="player"></param>
        /// <param name="playerName"></param>
        public void AddPlayer(Socket player, string playerName)
        {
            //首先向加入的玩家发送所有玩家的名字和状态
            Socket[] ready = ReadyPlayers.ToArray();
            string playerList = "";
            foreach (var p in Players)
            {
                if (ready.FirstOrDefault(a => a == p.Key) != null)//处在准备队列中
                {
                    playerList += p.Value + " 已准备 ";
                }
                else
                {
                    playerList += p.Value + " 未准备 ";
                }
            }
            player.Send(ConvertMessageForServer(2, playerList));
            Players.TryAdd(player, playerName);
            Thread.Sleep(1000);
            SendMessage(ConvertMessageForServer(3, playerName + " 加入房间"));
        }

        /// <summary>
        /// 删除玩家
        /// </summary>
        /// <param name="player"></param>
        public void RemovePlayer(Socket player)
        {
            //在玩家列表中删除该玩家
            Players.TryRemove(player, out string playerName);
            //在准备队列中删除该玩家
            Socket[] sockets = ReadyPlayers.ToArray();
            sockets = sockets.Where(s => s != player).ToArray();
            Socket socket;
            while (!ReadyPlayers.IsEmpty)
            {
                ReadyPlayers.TryDequeue(out socket);
            }
            foreach (Socket s in sockets)
            {
                ReadyPlayers.Enqueue(s);
            }
            SendMessage(ConvertMessageForServer(5, playerName + " 退出房间"));
        }

        /// <summary>
        /// 玩家准备
        /// </summary>
        /// <param name="player"></param>
        public bool PlayerGetReady(Socket player)
        {
            ReadyPlayers.Enqueue(player);
            SendMessage(ConvertMessageForServer(4, Players[player]+" 准备"));
            if (ReadyPlayers.Count == Players.Count && Players.Count > 1)
            {
                Thread t = new Thread(StartGame);
                t.IsBackground = true;
                t.Start();
                return true;
            }
            return false;
        }

        /// <summary>
        /// 转发某玩家的信息给所有房间内的玩家
        /// </summary>
        /// <param name="talker"></param>
        /// <param name="message"></param>
        public void TransmitMessage(Socket talker, string message)
        {
            Players.TryGetValue(talker, out string playerName);
            SendMessage(ConvertMessageForServer(7, playerName +" : "+ message));
        }

        /// <summary>
        /// 开始游戏
        /// </summary>
        public abstract void StartGame();

        /// <summary>
        /// 将信息发送给房间内的所有玩家
        /// </summary>
        /// <param name="buffer"></param>
        public void SendMessage(byte[] buffer)
        {
            var task1 = new Task(() =>
            {
                foreach (var player in Players)
                {
                    Console.WriteLine("Value:" + player.Value);
                    player.Key.Send(buffer);
                }
                Console.WriteLine("数量:" + Players.Count);
            });
            task1.Start();
        }

        /// <summary>
        /// 包装向客户端发送的信息
        /// 0 代表发送所有房间的列表，信息体格式为“{房间ID} {房间名} {游玩状态} {当前人数} {最大游玩人数}”
        /// 1 代表发送房间的ID，信息体格式为“{房间ID}”
        /// 2 代表发送当前房间所有玩家的状态，消息体格式为“{玩家姓名} {准备状态}\n”
        /// 3 代表玩家加入，消息体格式为“{玩家姓名} 加入房间”
        /// 4 代表玩家准备，消息体格式为“{玩家姓名} 准备”
        /// 5 代表玩家退出，信息体格式为“{玩家姓名} 退出房间”
        /// 6 代表玩家得分，信息体格式为“{玩家姓名} {所得分数}”
        /// 7 代表玩家发言，信息体格式为“{玩家姓名} ： {玩家发言}”
        /// 8 代表游戏开始，信息体格式为“{关键字/诗句}”
        /// 9 
        /// 10 代表轮到某玩家，消息体格式为“{玩家姓名}”
        /// 11 代表玩家作画，消息体格式为“{画}”
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        protected byte[] ConvertMessageForServer(int type, string message)
        {
            List<byte> newBuffer = new List<byte>();
            byte[] buffer;
            newBuffer.Add((byte)type);
            buffer = Encoding.UTF8.GetBytes(message);
            newBuffer.AddRange(buffer);
            return newBuffer.ToArray();
        }

        public override string ToString()
        {
            return RoomId.ToString() + " " + Name + " " + IsPlaying + " " + Players.Count + " " + MaxMem;
        }
    }
}
