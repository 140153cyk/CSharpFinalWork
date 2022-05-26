using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemDataService.Models
{
   public class Collect
    {
        public Collect()
        {
        }

        public int id { get; set; }
        public string account { get; set; }
        public int PoemId { get; set; }


        public Collect(string account, int poemId)
        {
            this.account = account;
            PoemId = poemId;
        }
    }
}
