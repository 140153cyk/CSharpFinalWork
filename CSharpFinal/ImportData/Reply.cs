using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData
{
  //reply类是对评论的回复，二级评论
  public class Reply
  {
    //评论id
    public int Id { get; set; }
    //用户id
    public int userId { get; set; }
    //被回复评论id
    public int replyerId { get; set; }
    public string Content { get; set; }
    public DateTime Created { get; set; }
    public int prase { get; set; }
  }
}
