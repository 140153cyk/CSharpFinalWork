using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData
{
  public class Comment
  {
    //评论id
    public int Id { get; set; }
    //分享者id
    public int userId { get; set; }
    //诗词
    public Poem poem { get; set; }
    //评论用户ID
    public int CommnetId { get; set; }
    //评论内容
    public string Content { get; set; }
    //点赞数
    public int Prase { get; set; }
    //评论时间
    public DateTime Created { get; set; }
    //发布时间
    public DateTime PostTime { get; set; }
  }

}
