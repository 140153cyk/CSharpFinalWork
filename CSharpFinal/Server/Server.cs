using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Server
{
    public class Server
    {
        public int MaxRoomID { get; set; } = 0;

        /// <summary>
        /// 你画我猜房间的起始ID
        /// </summary>
        public readonly int DrawRoomStartID = 1000000;
        /// <summary>
        /// 飞花令房间，房间ID应该小于1000000
        /// </summary>
        public static ConcurrentDictionary<int, FlyingFlowerRoom> DicFlyRoom = new ConcurrentDictionary<int, FlyingFlowerRoom>();

        /// <summary>
        /// 你画我猜房间，ID应该大于1000000
        /// </summary>
        public static ConcurrentDictionary<int, DrawAndGuessRoom> DicDrawRoom = new ConcurrentDictionary<int, DrawAndGuessRoom>();

        private Regex regex = new Regex(@"\w+");

        /// <summary>
        /// 监听
        /// </summary>
        public Server()
        {
            Start();
        }

        public void Start()
        {
            try
            {
                //创建一个监听的socket
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //绑定端口
                IPAddress ip = IPAddress.Any;
                IPEndPoint point = new IPEndPoint(ip, 50000);
                socketWatch.Bind(point);
                socketWatch.Listen(20);
                Thread t = new Thread(Listen);
                t.IsBackground = true;
                t.Start(socketWatch);
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// 循环监听客户端
        /// </summary>
        /// <param name="o"></param>
        public void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                Socket newClient = socketWatch.Accept();
                Thread t = new Thread(Receive);
                t.IsBackground = true;
                t.Start(newClient);
            }
        }

        /// <summary>
        /// 服务器接受并且处理每个客户的消息
        /// 服务器需要处理玩家的请求有以下几种：
        /// 0 代表某玩家新建房间,消息体格式为“{房间类型（0飞花令/1你画我猜）} {房间名字} {最大游玩数量} {玩家名字}”
        /// 1 代表某玩家请求所有房间列表，消息体格式为“{房间类型(0飞花令/1你画我猜)}”
        /// 2 代表某玩家退出房间，消息体格式为“{房间ID}”
        /// 3 代表某玩家加入房间，消息体格式为“{房间ID} {玩家名字}”
        /// 4 代表某玩家已经在房间中准备，消息体格式为“{房间ID}”
        /// 
        /// 10 代表某玩家正在游戏，并且发送了文字信息，消息体格式为“{房间ID} {玩家发言}”
        /// 11 代表玩家发送了画，消息体格式为“{房间ID} {画}”
        /// 12 代表玩家玩你画我猜得分，消息体格式为“{房间ID} {得分量}”
        /// 13 代表玩家玩飞花令成功答对，消息体格式为“{房间ID}”
        /// 14 代表玩家玩飞花令答错，消息体格式为“{房间ID}”
        /// </summary>
        /// <param name="o"></param>
        public void Receive(object o)
        {
            Socket client = o as Socket;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = client.Receive(buffer);
                    string message = "";
                    if (r == 0)
                    {
                        break;
                    }
                    byte type = buffer[0];
                    buffer = RemoveFirstByte(buffer);
                    //处理新建房间的请求,消息体格式为“{房间类型} {房间名字} {最大游玩数量} {玩家名字}”
                    if (type == 0)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        int roomType = Int32.Parse(match.Value);
                        match = match.NextMatch();
                        string name = match.Value;
                        match = match.NextMatch();
                        string maxMem = match.Value;
                        match = match.NextMatch();
                        string playerName = match.Value;
                        CreateARoom(client, name, Int32.Parse(maxMem), playerName, roomType);
                    }
                    //将所有房间的信息发送给玩家，消息体为“{房间类型}”
                    if (type == 1)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        int roomType = Int32.Parse(match.Value);
                        SendAllRooms(client, roomType);
                    }
                    //某玩家退出房间，消息体格式为“{房间ID}”
                    if (type == 2)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        int RoomID = Int32.Parse(match.Value);
                        BasicRoom room = GetConcreteRoom(RoomID);
                        room.RemovePlayer(client);
                    }
                    //某玩家加入房间，消息体格式为“{房间ID} {玩家名字}”
                    if (type == 3)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match m = regex.Match(message);
                        string RoomID = m.Value;
                        m = m.NextMatch();
                        string playerName = m.Value;
                        BasicRoom room = GetConcreteRoom(Int32.Parse(RoomID));
                        room.AddPlayer(client, playerName);
                    }
                    //玩家准备，消息体格式为“{房间ID}”
                    if (type == 4)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match m = regex.Match(message);
                        string RoomID = m.Value;
                        BasicRoom room = GetConcreteRoom(Int32.Parse(RoomID));
                        room.PlayerGetReady(client);
                    }
                    //玩家发送了文字消息,消息体格式为“{房间ID} {玩家发的信息}”
                    if (type == 10)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match m = regex.Match(message);
                        string RoomID = m.Value;
                        m = m.NextMatch();
                        string clientWords = m.Value;
                        BasicRoom room = GetConcreteRoom(Int32.Parse(RoomID));
                        room.TransmitMessage(client, clientWords);
                    }
                    //***玩家发送了画，消息体格式为“{房间ID} {画}”
                    if(type == 11)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        int RoomID = Int32.Parse(match.Value);
                        match = match.NextMatch();
                        string image = match.Value;
                        DrawAndGuessRoom room = (DrawAndGuessRoom)GetConcreteRoom(RoomID);
                        room.TransmitPainting(client, image);
                    }
                    //代表玩家玩你画我猜得分，消息体格式为“{房间ID} {得分量}”
                    if (type == 12)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        int RoomID = Int32.Parse(match.Value);
                        match = match.NextMatch();
                        int score = Int32.Parse(match.Value);
                        DrawAndGuessRoom room = (DrawAndGuessRoom)GetConcreteRoom(RoomID);
                        room.PlayerScore(client, score);
                    }
                    //代表玩家玩飞花令成功答对，消息体格式为“{ 房间ID}”
                    if (type == 13)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        int RoomID = Int32.Parse(match.Value);
                        FlyingFlowerRoom room = (FlyingFlowerRoom)GetConcreteRoom(RoomID);
                        room.AnswerRight();
                    }
                    //代表玩家玩飞花令答错，消息体格式为“{ 房间ID}”
                    if (type == 14)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        int RoomID = Int32.Parse(match.Value);
                        FlyingFlowerRoom room = (FlyingFlowerRoom)GetConcreteRoom(RoomID);
                        room.AnswerWrong();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        /// <summary>
        /// 创建一个新房间,如果是飞花令房间，分配当前最大ID，如果是你画我猜房间，分配最大ID加1000000
        /// </summary>
        /// <param name="RoomOwner"></param>
        public void CreateARoom(Socket RoomOwner, string name, int maxMem, string playerName, int type)
        {
            if (type == 0)
            {
                FlyingFlowerRoom flyingFlowerRoom = new FlyingFlowerRoom(name, maxMem, MaxRoomID);
                DicFlyRoom.TryAdd(MaxRoomID, flyingFlowerRoom);
                flyingFlowerRoom.AddPlayer(RoomOwner, playerName);
                RoomOwner.Send(ConvertMessageForServer(1, MaxRoomID.ToString()));
                MaxRoomID++;
            }
            else
            {
                DrawAndGuessRoom drawAndGuessRoom = new DrawAndGuessRoom(name, maxMem, MaxRoomID + DrawRoomStartID);
                DicDrawRoom.TryAdd(MaxRoomID + DrawRoomStartID, drawAndGuessRoom);
                drawAndGuessRoom.AddPlayer(RoomOwner, playerName);
                RoomOwner.Send(ConvertMessageForServer(1, (MaxRoomID + DrawRoomStartID).ToString()));
                MaxRoomID++;
            }
        }

        /// <summary>
        /// 将游戏的房间列表发送给客户
        /// </summary>
        /// <param name="target"></param>
        public void SendAllRooms(Socket target, int type)
        {
            string message = "";
            if (type == 0)
            {
                foreach (var room in DicFlyRoom)
                {
                    message += room.Value.ToString() + "\n";
                }
            }
            else
            {
                foreach (var room in DicDrawRoom)
                {
                    message += room.Value.ToString() + "\n";
                }
            }
            target.Send(ConvertMessageForServer(0, message));
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
        /// 7 代表玩家发言，信息体格式为“{玩家姓名} ：{玩家发言}”
        /// 8 代表游戏开始，信息体格式为“{关键字/诗句}”
        /// 9 代表玩家淘汰，消息体格式为“{玩家姓名}”
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

        public byte[] RemoveFirstByte(byte[] buffer)
        {
            List<byte> newbuffer = buffer.ToList();
            newbuffer.RemoveAt(0);
            return newbuffer.ToArray();
        }

        /// <summary>
        /// 根据房间ID得到具体的房间
        /// </summary>
        /// <param name="RoomID"></param>
        /// <returns></returns>
        private BasicRoom GetConcreteRoom(int RoomID)
        {
            if (RoomID >= DrawRoomStartID)
            {
                DrawAndGuessRoom room;
                DicDrawRoom.TryGetValue(RoomID, out room);
                return room;
            }
            else
            {
                FlyingFlowerRoom room;
                DicFlyRoom.TryGetValue(RoomID, out room);
                return room;
            }
        }
    }
}
