﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemDataService.Models
{
   public class Paragraph
    {
        public int id { get; set; }
        public int PoemId { get; set; }
        public string value { get; set; }

        public Paragraph(string value)
        {
            this.value = value;
        }
    }
}
