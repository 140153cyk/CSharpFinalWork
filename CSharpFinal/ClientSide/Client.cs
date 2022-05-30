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
using System.Text.RegularExpressions;

namespace Client
{
    abstract public class Client
    {
        /// <summary>
        /// 游戏结束，进行结算，s是胜利者名字
        /// </summary>
        public Action<string> GameOver = (s)=>{};

        protected List<string> PlayersInRoom = new List<string>();

        /// <summary>
        /// 游戏开始后，当前作答玩家的姓名/画画玩家的姓名
        /// </summary>
        public string CurrentPlayer { get; set; } = "";

        /// <summary>
        /// 在发言框中发言
        /// </summary>
        public Action<string> ShowMessage = (s) => {};

        /// <summary>
        /// 新建游戏窗口，并且展示所有玩家，s是玩家列表，格式为“{玩家名字} {准备状态}\n”
        /// </summary>
        public Action<string> CreateFormAndShowPlayerState = (s) => {};

        /// <summary>
        /// 刷新房间列表,s格式为“{房间ID} {房间名} {游玩状态} {当前人数} {最大游玩人数}\n”
        /// </summary>
        public Action<string> ShowRooms = (s) => {};

        /// <summary>
        /// 展示画
        /// </summary>
        public Action<string> ShowPaint = (s) => {};

        /// <summary>
        /// 房间中新加入玩家,s格式为“{玩家名字}”
        /// </summary>
        public Action<string> PlayerGetIn = (s) => {};

        /// <summary>
        /// 玩家准备，s格式为“{玩家名字}”
        /// </summary>
        public Action<string> PlayerGetReady = (s) => {};

        /// <summary>
        /// 将玩家从列表中删除，s为“{退出者姓名}”
        /// </summary>
        public Action<string> PlayerQuitRoom = (s) => {};
        
        /// <summary>
        /// 展示轮到自己（画画/飞花）的界面，该函数还负责倒计时，飞花令15秒，画画1分钟。在飞花令中，如果计时结束，应该调用其TellServerAnswerWrong函数。
        /// </summary>
        public Action MyTurn = () => { };

        protected Regex regex = new Regex(@"\w+");
        /// <summary>
        /// 房间ID
        /// </summary>
        public int RoomId { get; set; }

        /// <summary>
        /// 游玩状态
        /// </summary>
        public bool IsPlaying;
        /// <summary>
        /// 玩家名称
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 向服务端发文字消息
        /// </summary>
        /// <param name="s"></param>
        abstract public void SendMessageToServer(string s);

        protected Socket SocketOfClient { get; set; }
        public Client(string name)
        {
            Name = name;
            IsPlaying = false;
            ConnectToServer();
        }
        /// <summary>
        /// 连接到服务器
        /// </summary>
        protected void ConnectToServer()
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

            }
        }


        /// <summary>
        /// 游戏开始
        /// </summary>
        abstract protected void StartGame();

        /// <summary>
        /// 接收服务端发送的信息
        /// 0 代表接收所有房间的列表，信息体格式为“{房间ID} {房间名} {游玩状态} {当前人数} {最大游玩人数}\n”
        /// 1 代表接收房间的ID，信息体格式为“{房间ID}”
        /// 2 代表接收当前房间所有玩家的状态，消息体格式为“{玩家姓名} {准备状态}\n”
        /// 3 代表玩家加入，消息体格式为“{玩家姓名} 加入房间”
        /// 4 代表玩家准备，消息体格式为“{玩家姓名} 准备”
        /// 5 代表玩家退出，信息体格式为“{玩家姓名} 退出房间”
        /// 6 代表玩家得分，信息体格式为“{玩家姓名} {所得分数}”
        /// 7 代表玩家发言，信息体格式为“{玩家姓名} ： {玩家发言}”
        /// 8 代表游戏开始，信息体格式为“{关键字/诗句}”
        /// 9 代表你画我猜游戏结算，无消息体
        /// 10 代表轮到某玩家，消息体格式为“{玩家姓名}”
        /// 11 代表玩家作画，消息体格式为“{画}”
        /// </summary>
        abstract protected void Receive();
        

        /// <summary>
        /// 向服务器发送文字，消息体为“{房间ID} {玩家发言}”
        /// </summary>
        /// <param name="str"></param>
        protected void SendMessage(string str)
        {
            try
            {
                SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString() +" " +  str, 10));
            }
            catch(SocketException ex)
            {
                
            }
        }

        /// <summary>
        /// 请求服务器创建房间,消息体格式为“{房间类型（0飞花令/1你画我猜）}{房间名字} {最大游玩数量} {玩家名字}”
        /// </summary>
        /// <param name="roomName">房间名字</param>
        /// <param name="MaxMem">房间最大人数</param>
        abstract public void CreateRoom(string roomName, int MaxMem);

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
                
            }
        }

        /// <summary>
        /// 退出当前房间，消息体为“{房间ID}”
        /// </summary>
        public void QuitRoom()
        {
            try
            {
                SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString(), 2));
            }
            catch (SocketException ex)
            {
                
            }
        }

        /// <summary>
        /// 玩家已经准备，消息体为“{房间ID}”
        /// </summary>
        public void GetReady()
        {
            try
            {
                SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString(), 4));
            }
            catch (SocketException ex)
            {
                
            }
        }

        /// <summary>
        /// 请求所有房间的列表，消息体格式为“{房间类型(0飞花令/1你画我猜)}”
        /// </summary>
        abstract public void RefreshAllRooms();

        /// <summary>
        /// 用来包装玩家需要发送的信息
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
        /// <param name="message">消息体</param>
        /// <param name="type">消息种类</param>
        /// <returns></returns>
        protected byte[] ConvertMessageForClient(string message, int type)
        {
            List<byte> newBuffer = new List<byte>();
            byte[] buffer;
            newBuffer.Add((byte)type);
            buffer = Encoding.UTF8.GetBytes(message);
            newBuffer.AddRange(buffer);
            return newBuffer.ToArray();
        }

        protected byte[] RemoveFirstByte(byte[] buffer)
        {
            List<byte> newbuffer = buffer.ToList();
            newbuffer.RemoveAt(0);
            return newbuffer.ToArray();
        }
    }
}
