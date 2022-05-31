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
using System.Timers;

namespace GameWinForm
{
    public class Room
    {

        public int RoomId { get; set; }
        public string Name { get; set; }
        public string IsPlaying { get; set; }

        //房间人数
        public int CurrentNum { set; get; }
        /// <summary>
        /// 房间容纳的最大人数
        /// </summary>
        public int MaxNum { set; get; }

        public Room(int id, string name,string isPlaying, int currentNum, int maxNum)
        {
            RoomId = id;
            Name = name;
            IsPlaying = isPlaying;
            MaxNum = maxNum;
            CurrentNum = currentNum;
        }
    }
}
