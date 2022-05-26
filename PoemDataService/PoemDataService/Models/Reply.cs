using System;

namespace PoemDataService.Models
{
    public class Reply
    {
        //评论id
        public int Id { get; set; }
        //用户id
        public int userId { get; set; }
        //被回复人id
        public int replyerId { get; set; }
        public DateTime Created { get; set; }
        public int prase { get; set; }
    }
}