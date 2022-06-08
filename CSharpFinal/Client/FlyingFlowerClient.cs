using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    public class FlyingFlowerClient : Client
    {        
        private List<string> PlayersInGame = new List<string>();

        //将玩家状态修改为淘汰，s为“{玩家姓名}”
        public Action<string> KnockOutPlayer = (s) => { };
        //显示当前玩家的回答
        public Action<string> ShowAnswer = (s) => { };
        //当前玩家s回答正确
        public Action<string> AnswerRight = (s) => { };
        //当前玩家s回答错误
        public Action<string> AnswerWrong = (s) => { };
        public string KeyWord { get; set; } = "";


        public FlyingFlowerClient(string name) : base(name)
        {
            
        }

        public override void CreateRoom(string roomName, int MaxMem)
        {
            SocketOfClient.Send(ConvertMessageForClient(0.ToString() + " " + roomName + " " + MaxMem.ToString() + " " + Name, 0));
        }

        public override void RefreshAllRooms()
        {
            SocketOfClient.Send(ConvertMessageForClient(0.ToString(), 1));
        }

        /// <summary>
        /// 告诉服务器本人答对了
        /// </summary>
        private void TellServerAnswerCorrect()
        {
            SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString(), 13));
        }

        /// <summary>
        /// 告诉服务器本人答错了
        /// </summary>
        public void TellServerAnswerWrong()
        {
            SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString(), 14));
        }

        protected override void StartGame()
        {
            PlayersInGame.Clear();
            IsPlaying =true;
            foreach(var player in PlayersInRoom)
            {
                PlayersInGame.Add(player);
            }
            while (PlayersInGame.Count > 1)
            {
                //游戏进行中
            }
            IsPlaying=false;
            Thread.Sleep(1000);
            GameOver(PlayersInGame[0]);
        }

        private void Judge(string speaker, string words)
        {
            if (!IsPlaying) return;
            //在游戏中，轮到该玩家作答
            if(speaker == CurrentPlayer)
            {
                //诗句且有关键字
                if (IsPoem(words) && Regex.IsMatch(words, @"\w*" + KeyWord + @"\w*"))
                {
                    AnswerRight(speaker);
                }
                else
                {
                    AnswerWrong(speaker);
                    PlayersInGame.Remove(speaker);
                    KnockOutPlayer(speaker);
                }
            }
        }



        //***
        private bool IsPoem(string message)
        {
            return true;
        }
        
        protected override void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = SocketOfClient.Receive(buffer);
                    string message = "";
                    byte type = buffer[0];
                    buffer = RemoveFirstByte(buffer);
                    if (r == 0) break;
                    // 代表接收所有房间的列表，信息体格式为“{房间ID} {房间名} {游玩状态} {当前人数} {最大游玩人数}\n”
                    if (type == 0)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        ShowRooms(message);
                    }
                    // 接收房间的ID，信息体格式为“{房间ID}”
                    if (type == 1)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match m = regex.Match(message);
                        string RoomID = m.Value;
                        this.RoomId = Int32.Parse(RoomID);
                    }
                    // 接收当前房间所有玩家的状态，消息体格式为“{玩家姓名} {准备状态}\n”
                    if (type == 2)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        CreateFormAndShowPlayerState(message);
                        Match m = regex.Match(message);
                        //将玩家全部添加进入房间
                        while (m.Success)
                        {
                            PlayersInRoom.Add(m.Value);
                            m = m.NextMatch();
                            m = m.NextMatch();//跳过准备状态
                        }
                        break;
                    }
                    //代表玩家加入，消息体格式为“{玩家姓名} 加入房间”
                    if (type == 3)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        //ShowMessage(message);
                        Match match = regex.Match(message);
                        PlayersInRoom.Add(match.Value);
                        PlayerGetIn(match.Value);
                    }
                    //代表玩家准备，消息体格式为“{玩家姓名} 准备”
                    if (type == 4)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        PlayerGetReady(match.Value);
                        ShowMessage(message);
                    }
                    //代表玩家退出，信息体格式为“{玩家姓名} 退出房间”
                    if (type == 5)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        PlayerQuitRoom(match.Value);
                        ShowMessage(message);
                        PlayersInRoom.Remove(match.Value);
                        PlayersInGame.Remove(match.Value);
                    }
                    //代表玩家发言，信息体格式为“{玩家姓名} ： {玩家发言}”
                    if (type == 7)
                    {
                        message=Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        string speaker = match.Value;
                        match = match.NextMatch();
                        string words = match.Value;
                        ShowAnswer(words);
                        Judge(speaker, words);
                    }
                    //代表游戏开始，信息体格式为“{关键字/诗句}”
                    if (type == 8)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        KeyWord = message;
                        Thread t = new Thread(StartGame);
                        t.IsBackground = true;
                        t.Start();
                    }
                    //代表轮到某玩家，消息体格式为“{玩家姓名}”
                    if (type == 10)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        CurrentPlayer = message;
                        if(CurrentPlayer == Name)
                        {
                            MyTurn();
                        }
                        else
                        {
                            NotMyTurn(message);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        public override void SendMessageToServer(string s)
        {
            SendMessage(s);
            Thread.Sleep(1000);
            if (CurrentPlayer != Name) return;
            //飞花令开始了，检测诗句正确性
            if (IsPoem(s) && Regex.IsMatch(s, @"\w*" + KeyWord + @"\w*"))
            {
                TellServerAnswerCorrect();
            }
            else
            {
                TellServerAnswerWrong();
            }
        }
    }
}
