using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData
{
   public class RawPoem
    {
        public string title { get; set; }
        public string author { get; set; }
        public string biography { get; set; }//全唐诗的原文
        public List<string> paragraphs { get; set; } = new List<string>();
        public string volume { get; set; }
    }
}
