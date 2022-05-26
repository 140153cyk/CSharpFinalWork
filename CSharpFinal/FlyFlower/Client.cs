using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FlyFlower
{
    public class Client
    {

        string keyWords;

        /// <summary>
        /// 展示胜利界面
        /// </summary>
        public Action<string> ShowWin = (s)=>{;};

        /// <summary>
        /// 展示失败界面
        /// </summary>
        public Action<string> ShowLose = (s) => {; };

        /// <summary>
        /// 在发言框中发言
        /// </summary>
        public Action<string> ShowWords = (s) => {; };

        /// <summary>
        /// 刷新玩家列表
        /// </summary>
        public Action<string> ShowPlayers = (s) => {; };

        /// <summary>
        /// 展示关键字
        /// </summary>
        public Action<string> ShowKeyWord = (s) => {; };
        
        /// <summary>
        /// 刷新房间列表
        /// </summary>
        public Action<string> ShowRooms = (s) => {; };

        private Regex regex = new Regex(@"\w+");
        /// <summary>
        /// 房间ID
        /// </summary>
        public int RoomId { get; set; }

        /// <summary>
        /// 玩家名称
        /// </summary>
        public string Name { get; set; }

        Socket SocketOfClient { get; set; }
        public Client(string name)
        {
            Name = name;
            ConnectToServer();
        }
        /// <summary>
        /// 连接到服务器
        /// </summary>
        public void ConnectToServer()
        {
            try
            {
                SocketOfClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                IPEndPoint point = new IPEndPoint(ip, 50000);
                SocketOfClient.Connect(point);

                Thread t = new Thread(Receive);
                t.IsBackground = true;
                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 处理服务器的信息
        /// 0 代表有新的玩家加入,消息体格式为“{玩家姓名}加入房间”
        /// 1 代表有玩家退出，消息体格式为“{玩家姓名}退出房间”
        /// 2 代表玩家准备，消息体格式为“{玩家姓名}准备”
        /// 3 代表收到所有房间列表，消息体格式为“{房间ID} {房间名字} {游玩状态} {当前玩家数量} {最大玩家数量}”
        /// 4 代表有玩家失败，消息体格式为“{玩家姓名}失败了”
        /// 5 代表玩家发言，消息体格式为“{玩家姓名} ： {玩家发言}”
        /// 6 代表玩家收到房间ID，消息体格式为“{房间ID}”
        /// 7 代表本玩家失败了，无消息体
        /// 8 代表轮到本玩家飞花，无消息体
        /// 9 代表游戏胜利，无消息体
        /// 10代表玩家列表，消息体为“{玩家姓名} {准备状态}”
        /// 11代表游戏开始，消息体为“{飞花关键字}”
        /// 12代表游戏结束，无消息体
        /// </summary>
        public void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024*1024*2];
                    int r = SocketOfClient.Receive(buffer);
                    string message = "";
                    byte type = buffer[0];
                    buffer = RemoveFirstByte(buffer);
                    if (r == 0) break;
                    // 有新的玩家加入,消息体格式为“{玩家姓名}加入房间”
                    if (type == 0)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                    }
                    // 有玩家退出，消息体格式为“{玩家姓名}退出房间”
                    if (type == 1)
                    {
                        
                    }
                    //玩家准备，消息体格式为“{玩家姓名}准备”
                    if (type == 2)
                    {
                        
                    }
                    //收到所有房间列表，消息体格式为“{房间ID} {房间名字} {游玩状态} {当前玩家数量} {最大玩家数量}”
                    if (type == 3)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        ShowRooms(message);
                    }
                    //有玩家失败，消息体格式为“{玩家姓名}失败了”
                    if (type == 4)
                    {

                    }
                    //玩家发言，消息体格式为“{玩家姓名} ： {玩家发言}”
                    if (type == 5)
                    {
                        
                    }
                    //玩家收到房间ID，消息体格式为“{房间ID}”
                    if (type == 6)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match m = regex.Match(message);
                        string RoomID = m.Value;
                        RoomId = Int32.Parse(RoomID);
                    }
                    //本玩家失败了，无消息体
                    if (type == 7)
                    {
                        
                    }
                    //轮到本玩家飞花，无消息体
                    if (type == 8)
                    {
                        
                    }
                    //游戏胜利，无消息体
                    if (type == 9)
                    {
                        
                    }
                    //玩家列表，消息体为“{玩家姓名} {准备状态}”
                    if(type == 10)
                    {

                    }
                    //游戏开始，消息体为“{飞花关键字}”
                    if (type == 11)
                    {

                    }
                    //游戏结束，无消息体
                    if (type == 12)
                    {

                    }
                }
                catch(Exception ex)
                {
                      MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// 向服务器发送文字，消息体为“{房间ID} {玩家发言}”
        /// </summary>
        /// <param name="str"></param>
        public void Send(string str)
        {
            try
            {
                SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString() + str, 5));
            }
            catch(SocketException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 请求服务器创建房间,消息体格式为“{房间名字} {最大游玩数量} {玩家名字}”
        /// </summary>
        /// <param name="roomName">房间名字</param>
        /// <param name="MaxMem">房间最大人数</param>
        public void CreateRoom(string roomName, int MaxMem)
        {
            try
            {
                SocketOfClient.Send(ConvertMessageForClient(roomName+" "+MaxMem.ToString() +" "+  Name, 0));
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 加入一个房间，消息体为“{房间ID} {玩家姓名}”
        /// </summary>
        /// <param name="id">房间的ID</param>
        public void JoinRoom(int id)
        {
            try
            {
                SocketOfClient.Send(ConvertMessageForClient(id.ToString() + " "+ Name, 3));
                RoomId = id;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 退出当前房间，消息体为“{房间ID}”
        /// </summary>
        /// <param name="id"></param>
        public void QuitRoom()
        {
            try
            {
                SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString(), 2));
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 玩家已经准备，消息体为“{房间ID}”
        /// </summary>
        public void Prepare()
        {
            try
            {
                SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString(), 4));
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 显示失败界面
        /// </summary>
        public void Lose()
        {

        }

        /// <summary>
        /// 请求所有房间的列表，无消息体
        /// </summary>
        public void RefreshAllRooms()
        {
            try
            {
                SocketOfClient.Send(ConvertMessageForClient("", 1));
            }
            catch( SocketException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 用来包装玩家需要发送的信息
        /// 0 代表某玩家新建房间,消息体格式为“{房间名字} {最大游玩数量} {玩家名字}”
        /// 1 代表某玩家请求所有房间列表，无消息体
        /// 2 代表某玩家退出房间，消息体格式为“{房间ID}”
        /// 3 代表某玩家加入房间，消息体格式为“{房间ID} {玩家名字}”
        /// 4 代表某玩家已经在房间中准备，消息体格式为“{房间ID}”
        /// 5 代表某玩家正在游戏，并且发送了文字信息，消息体格式为“{房间ID} {玩家发言}”
        /// </summary>
        /// <param name="message">消息体</param>
        /// <param name="type">消息种类</param>
        /// <returns></returns>
        public byte[] ConvertMessageForClient(string message, int type)
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
