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
    //用户id
    public int userId { get; set; }
    public string content { get; set; }
    public DateTime Created { get; set; }
    public int prase { get; set; }
  }
}
