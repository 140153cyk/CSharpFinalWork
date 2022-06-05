using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoemDataService.Models
{
    public class Comment
    {
        //帖子id
        public int Id { get; set; }
        //分享者id
        public string UserAccount { get; set; }
        //诗词
     
        public int PoemId { get; set; }
        //public string Deatail { get; set; }
        [ForeignKey("PoemId")]
        public Poem Poems { get; set; }

        //点赞数
        public int Prase { get; set; }
        //创建时间
        public DateTime Created { get; set; }
        public List<Reply> Replys { get; set; }

    }
}