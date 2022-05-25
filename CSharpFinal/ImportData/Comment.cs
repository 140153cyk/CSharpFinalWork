using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData
{
  public class Comment
  {
    //分享id
    public int Id { get; set; }
    //分享者id
    public int userId { get; set; }
    //诗词
    public Poem poem { get; set; }
    public Reply comment { get; set; }
    //创建时间
    public DateTime Created { get; set; }
   public List<Reply> Comments { get; set;}
  }
}
