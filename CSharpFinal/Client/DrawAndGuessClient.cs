using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    public class DrawAndGuessClient : Client
    {
        /// <summary>
        /// 不是本人画画的回合
        /// </summary>
        public Action NotMyTurn = ()=>{};
        

        /// <summary>
        /// 展示本轮答对的界面
        /// </summary>
        public Action ShowCorrect = () => { };

        /// <summary>
        /// 玩家的名字和得分
        /// </summary>
        public Dictionary<string, int> PlayersInGame { get; set; } = new Dictionary<string, int>();

        /// <summary>
        /// 当前如果回答正确的得分
        /// </summary>
        private int currentScore;

        public string currentPoem { get; set; } = "";

        public DrawAndGuessClient(string name) : base(name)
        {

        }

        public override void CreateRoom(string roomName, int MaxMem)
        {
            SocketOfClient.Send(ConvertMessageForClient(1.ToString() + " " + roomName + " " + MaxMem.ToString() + " " + Name, 0));
        }

        public override void RefreshAllRooms()
        {
            SocketOfClient.Send(ConvertMessageForClient(1.ToString(), 1));
        }

        /// <summary>
        /// 发送图片
        /// </summary>
        /// <param name="image"></param>
        public void SendImage(string image)
        {
            SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString() + " " + image, 11));
        }

        protected override void StartGame()
        {
            PlayersInGame.Clear();
            IsPlaying = true;
            foreach(var player in PlayersInRoom)
            {
                PlayersInGame.Add(player, 0);
            }
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
                    }
                    //代表玩家加入，消息体格式为“{玩家姓名} 加入房间”
                    if (type == 3)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        ShowMessage(message);
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
                    //玩家得分，信息格式为“{玩家姓名} {得分量}”
                    if (type == 6)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        Match match = regex.Match(message);
                        string player = match.Value;
                        match = match.NextMatch();
                        int score = Int32.Parse(match.Value);
                        ShowMessage(player + "答对了，得到了"+score.ToString()+"分");
                        //玩家得分增加
                        PlayersInGame[player] += score;
                        //下次得分减少，最小得分量为1
                        if (currentScore > 1) currentScore--;
                    }
                    //代表玩家发言，信息体格式为“{玩家姓名} ： {玩家发言}”
                    if (type == 7)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        ShowMessage(message);
                    }
                    //代表游戏开始，信息体格式为“{关键字/诗句}”
                    if (type == 8)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        currentPoem = message;
                        Thread t = new Thread(StartGame);
                        t.IsBackground = true;
                        t.Start();
                    }
                    //代表游戏结算
                    if(type == 9)
                    {
                        int maxScore = 0;
                        string winner="";
                        foreach(var player in PlayersInGame)
                        {
                            if(player.Value > maxScore)
                            {
                                maxScore = player.Value;
                                winner = player.Key;
                            }
                            else if(player.Value == maxScore)
                            {
                                winner+=player.Key;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        GameOver(winner);
                        IsPlaying = false;
                    }
                    //代表轮到某玩家，消息体格式为“{玩家姓名}”
                    if (type == 10)
                    {
                        currentScore = 4;
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        CurrentPlayer = message;
                        if (CurrentPlayer == Name)
                        {
                            MyTurn();
                        }
                        else
                        {
                            NotMyTurn();
                            ShowMessage("系统 ： 轮到" + message + "画画了");
                        }
                    }
                    //代表玩家的画，消息格式为“{画}”
                    if (type == 11)
                    {
                        message = Encoding.UTF8.GetString(buffer, 0, r - 1);
                        ShowPaint(message);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        public override void SendMessageToServer(string s)
        {
            if (s.Equals(currentPoem))
            {
                //答对了，告诉服务器自己答对了，并且展示答对的界面
                SocketOfClient.Send(ConvertMessageForClient(RoomId.ToString() + " " + currentScore.ToString(), 12));
                ShowCorrect();
            }
            else
            {
                SendMessage(s);
            }
        }
    }
}
