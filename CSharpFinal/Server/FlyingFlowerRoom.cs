using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Server
{
    public class FlyingFlowerRoom : BasicRoom
    {
        private string currentKeyWord;
        private readonly string[] KeyWords = { "月", "酒", "花", "风", "春", "秋", "冬", "夜", "叶" };
        private Socket currentPlayer;

        enum PlayerState
        {
            noResponse,
            wrongResponse,
            rightResponse
        }

        private PlayerState playerState;

        public FlyingFlowerRoom(string name, int maxMem, int id)
        {
            this.Name = name;
            this.MaxMem = maxMem;
            this.RoomId = id;
            this.IsPlaying = false;
        }

        public override void StartGame()
        {
            Thread.Sleep(3000);
            Random random = new Random();
            currentKeyWord = KeyWords[random.Next(0, 10)];
            IsPlaying = true;
            SendMessage(ConvertMessageForServer(8, currentKeyWord));
            while(ReadyPlayers.Count > 1)
            {
                playerState = PlayerState.noResponse;
                ReadyPlayers.TryDequeue(out currentPlayer);

                Thread.Sleep(3000);
                SendMessage(ConvertMessageForServer(10, Players[currentPlayer]));
                //等待玩家反应
                while (playerState == PlayerState.noResponse) ;
                if(playerState == PlayerState.rightResponse)
                {
                    ReadyPlayers.Enqueue(currentPlayer);
                }
            }
        }

        public void AnswerRight()
        {
            playerState = PlayerState.rightResponse;
        }

        public void AnswerWrong()
        {
            playerState = PlayerState.wrongResponse;
        }
    }
}
