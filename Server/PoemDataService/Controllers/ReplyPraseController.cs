using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PoemDataService.Models;
using System.Timers;
using System.Threading.Tasks;
using PoemDataService.DAO;
using System.Text.RegularExpressions;

namespace PoemDataService.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ReplyPraseController : ControllerBase
  {

    private readonly PoemContext db;

    public ReplyPraseController(PoemContext context)
    {
      db = context;
    }
    //根据Url后带的account 和 replyId加入
    [HttpPost]
    public ActionResult<ReplyPrase> AddReplyReplyPrase(string account, int replyId)
    {
      if (db.replyPrases.FirstOrDefault(c => c.userAccount == account && c.replyId == replyId) != null) return BadRequest();

      ReplyPrase ReplyPrase = new ReplyPrase(account, replyId);

      try
      {
        db.replyPrases.Add(ReplyPrase);
        db.SaveChanges();
        return NoContent();
      }
      catch (Exception e)
      {
        return BadRequest();
      }
    }
    //根据Url后带的accout和Id删除
    [HttpDelete]
    public ActionResult<ReplyPrase> DeleteReplyPrase(string account, int Id)
    {
      try
      {
        db.replyPrases.Remove(
            db.replyPrases.FirstOrDefault(c => c.userAccount == account && c.replyId == Id)
            );
        db.SaveChanges();
        return NoContent();
      }
      catch (Exception e)
      {
        return BadRequest();
      }
    }
  

    //判断用户是否有某首诗的收藏
    [HttpGet]
    public bool JudgeReplyPrase(string account, int Id)
    {
      return db.replyPrases.Any(c => c.userAccount == account && c.replyId== Id);
    }

  
  }
}


