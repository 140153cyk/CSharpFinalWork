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
    public int UserId { get; set; }
    //诗词
    public Poem Poems { get; set; }
    
   public Reply reply{ get; set; }
    //点赞数
    public int Prase { get; set; }
    //创建时间
    public DateTime Created { get; set; }
    public List<Reply> Replys { get; set; }
   
  }
}
