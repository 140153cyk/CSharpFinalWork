using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Poem
    {
        public Poem()
        {
        }

        public int id { get; set; }
        
        public string title { get; set; }
        public string author { get; set; }
        public string biography { get; set; }//全唐诗的原文
        public List<Paragraph> paragraphs { get; set; } = new List<Paragraph>();
        public string volume { get; set; }

        public Poem( string title, string author, string biography, string volume)
        {
            this.title = title;
            this.author = author;
            this.biography = biography;
            this.volume = volume;
        }
    }
}
