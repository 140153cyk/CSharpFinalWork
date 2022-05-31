using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Paragraph
    {

        public int id { get; set; }
        public int PoemId { get; set; }

        public int paraNum { get; set; }
        public string value { get; set; }

        public Paragraph(string value, int num)
        {
            this.value = value;
            this.paraNum = num;
        }

        public Paragraph()
        {
        }
    }

}
