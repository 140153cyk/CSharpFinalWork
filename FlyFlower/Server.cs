///***表示调试用的，需要删除
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
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FlyFlower
{
    public class Server
    {
        /// <summary>
        /// ***用来看输出的函数
        /// </summary>
        public Action<string> showMessage;
        public int MaxRoomID { get; set; } = 0;
        public static ConcurrentDictionary<int, Room> DicRooms = new ConcurrentDictionary<int, Room>();

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
                MessageBox.Show(ex.Message);
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
        /// 0 代表某玩家新建房间,消息体格式为“{房间名字} {最大游玩数量} {玩家名字}”
        /// 1 代表某玩家请求所有房间列表，无消息体
        /// 2 代表某玩家退出房间，消息体格式为“{房间ID}”
        /// 3 代表某玩家加入房间，消息体格式为“{房间ID} {玩家名字}”
        /// 4 代表某玩家已经在房间中准备，消息体格式为“{房间ID}”
        /// 5 代表某玩家正在游戏，并且发送了文字信息，消息体格式为“{房间ID} {玩家发言}”
        /// </summary>
        /// <param name="o"></param>
        public void Receive(object o)
        {
            Socket client = o as Socket;
            SendAllRooms(client);
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024*1024*2];
                    int r = client.Receive(buffer);
                    string message="";
                    if(r == 0)
                    {
                        break;
                    }
                    byte type = buffer[0];
                    buffer = RemoveFirstByte(buffer);
                    //处理新建房间的请求,消息体格式为“{房间名字} {最大游玩数量} {玩家名字}”
                    if (type == 0)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r-1);
                        //***
                        showMessage("消息头：" + type.ToString() + "消息体" + message);
                        Match match = regex.Match(message);
                        string name = match.Value;
                        match = match.NextMatch();
                        string maxMem = match.Value;
                        match = match.NextMatch();
                        string playerName = match.Value;
                        CreateARoom(client, name, Int32.Parse(maxMem), playerName);
                        
                    }
                    //将所有房间的信息发送给玩家，无消息体
                    if (type == 1)
                    {
                        SendAllRooms(client);
                    }
                    //某玩家退出房间，消息体格式为“{房间ID}”
                    if (type == 2)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match m = regex.Match(message);
                        string RoomID = m.Value;
                        Room room = DicRooms[Int32.Parse(RoomID)];
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
                        Room room = DicRooms[Int32.Parse(RoomID)];
                        room.AddPlayer(client, playerName);
                    }
                    //玩家准备，消息体格式为“{房间ID}”
                    if(type == 4)
                    {
                        message= Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match m = regex.Match(message);
                        string RoomID = m.Value;
                        Room room = DicRooms[Int32.Parse(RoomID)];
                        room.PlayerGetReady(client);
                    }
                    //玩家发送了文字消息,消息体格式为“{房间ID} {玩家发的信息}”
                    if (type == 5)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match m = regex.Match(message);
                        string RoomID = m.Value;
                        Room room = DicRooms[Int32.Parse(RoomID)];
                        m = m.NextMatch();
                        string clientWords = m.Value;
                        room.judge(client, clientWords);
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// 创建一个新房间
        /// </summary>
        /// <param name="RoomOwner"></param>
        public void CreateARoom(Socket RoomOwner, string name, int maxMem, string playerName)
        {
            Room room = new Room(name, maxMem, MaxRoomID);
            DicRooms.TryAdd(MaxRoomID++, room);
            room.AddPlayer(RoomOwner, playerName);
            room.IsPlaying = false;
            RoomOwner.Send(ConvertMessageForServer((MaxRoomID - 1).ToString(), 6));
        }

        /// <summary>
        /// 将游戏的房间列表发送给客户
        /// </summary>
        /// <param name="target"></param>
        public void SendAllRooms(Socket target)
        {
            string message = "";
            foreach(var room in DicRooms)
            {
                message += room.Value.ToString()+"\n";
            }
            target.Send(ConvertMessageForServer(message, 3));
        }

        /// <summary>
        /// 用来包装需要发送给玩家的信息
        /// 0 代表有新的玩家加入,消息体格式为“{玩家姓名}加入房间”
        /// 1 代表有玩家退出，消息体格式为“{玩家姓名}退出房间”
        /// 2 代表玩家准备，消息体格式为“{玩家姓名}准备”
        /// 3 代表发送所有房间列表，消息体格式为“{房间ID} {房间名字} {游玩状态} {当前玩家数量} {最大玩家数量} ”
        /// 4 代表有玩家失败，消息体格式为“{玩家姓名}失败了”
        /// 5 代表玩家发言，消息体格式为“{玩家姓名} ： {玩家发言}”
        /// 6 代表发送房间ID，消息体格式为“{房间ID}”
        /// 7 代表本玩家失败了，无消息体
        /// 8 代表轮到本玩家飞花，无消息体
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
        
        public byte[] RemoveFirstByte(byte[] buffer)
        {
            List<byte> newbuffer = buffer.ToList();
            newbuffer.RemoveAt(0);
            return newbuffer.ToArray();
        }
    }
}
