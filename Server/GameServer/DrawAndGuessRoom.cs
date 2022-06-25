using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Server
{
    public class DrawAndGuessRoom : BasicRoom
    {
        private Socket currentDrawer;

        private bool IsNextTurn;

        /// <summary>
        /// 答对题目的人数
        /// </summary>
        int count;

        public DrawAndGuessRoom(string name, int maxMem, int id)
        {
            this.Name = name;
            this.MaxMem = maxMem;
            this.RoomId = id;
            this.IsPlaying = false;
        }

        public override void StartGame()
        {
            IsPlaying = true;
            while (ReadyPlayers.Count > 0)
            {
                Thread.Sleep(1000);
                IsNextTurn = false;
                count = 0;
                //***获得题目
                HttpClientHandler handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
                HttpClient client = new HttpClient(handler);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var task=client.GetStringAsync("https://localhost:5001/api/poem/guess");
                string currentPoem = JsonConvert.DeserializeObject<String>(task.Result);
                Console.WriteLine(currentPoem);
                SendMessage(ConvertMessageForServer(8, currentPoem));
                //获得玩家
                ReadyPlayers.TryDequeue(out currentDrawer);
                string name;
                Players.TryGetValue(currentDrawer, out name);
                SendMessage(ConvertMessageForServer(10, name));
                //开启一个时钟,一分钟
                System.Timers.Timer timer = new System.Timers.Timer
                {
                    Enabled = true,
                    Interval = 60000, //一分钟
                    AutoReset = false
                };
                timer.Start();
                timer.Elapsed += new ElapsedEventHandler(NextTurn);
                while (!IsNextTurn && count < Players.Count-1) ;//时间到或者所有人答对
                //本轮结束
                timer.Stop();
                timer.Dispose();
            }
            Thread.Sleep(1000);
            SendMessage(ConvertMessageForServer(9, ""));
            IsPlaying = false;
        }

        private void NextTurn(object source, ElapsedEventArgs e)
        {
            IsNextTurn = true;
        }

        /// <summary>
        /// 转发玩家的画
        /// </summary>
        /// <param name="drawer"></param>
        /// <param name="image"></param>
        public void TransmitPainting(Socket drawer, string image)
        {
            byte[] buffer = ConvertMessageForServer(11, image);
            var task1 = new Task(() =>
            {
                foreach (var player in Players)
                {
                    if (player.Key == drawer) continue;
                    player.Key.Send(buffer);
                }
            });
            task1.Start();
        }

        /// <summary>
        /// 转发玩家得分的消息，并且得分人数增加
        /// </summary>
        /// <param name="player"></param>
        /// <param name="score"></param>
        public void PlayerScore(Socket player, int score)
        {
            lock (this)
            {
                count++;
            }
            Players.TryGetValue(player, out string playerName);
            SendMessage(ConvertMessageForServer(6, playerName + " " + score.ToString()));
        }
    }
}
