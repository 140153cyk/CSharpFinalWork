using System;

namespace PoemDataService.Models
{
    public class Reply
    {
        //评论id
        public int Id { get; set; }
        //用户id
        public string userAccount { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int prase { get; set; }

        public int CommentId { get; set; }
    }
}