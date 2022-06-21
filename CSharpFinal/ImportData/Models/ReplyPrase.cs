using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoemDataService.Models
{
  public class ReplyPrase
  {

    public int Id { get; set; }
    //用户id
    public string userAccount { get; set; }

    public int replyId { get; set; }
    public bool IsPrased { get; set; }
    public ReplyPrase(string account, int replyId)
    {
      userAccount = account;
      this.replyId = replyId;
    }
  }
}

