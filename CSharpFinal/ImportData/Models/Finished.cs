using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Finished
    {
        public int id { get; set; }
        public string account { get; set; }
        public int PoemId { get; set; }

        public Finished(string account, int poemId)
        {
            this.account = account;
            PoemId = poemId;
        }
    }
}
