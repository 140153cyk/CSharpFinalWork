using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoemDataService.Models
{
  public class CommentPrase
  {
    
    public int Id { get; set; }
    
    public string Account { get; set; }
    //诗词
    public int commentId { get; set; }
    
   public bool IsPrased { get; set; }
    public CommentPrase(string account,int id)
    {
      Account = account;
      commentId = id;
    }

        public CommentPrase()
        {
        }
    }
}
