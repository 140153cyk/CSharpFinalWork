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
  public class CommentPraseController : ControllerBase
  {

    private readonly PoemContext db;

    public CommentPraseController(PoemContext context)
    {
      db = context;
    }
    //根据Url后带的account 和 CommentId加入
    [HttpPost]
    public ActionResult<CommentPrase> AddCommentCommentPrase(string account, int CommentId)
    {
      if (db.CommentsPrases.FirstOrDefault(c => c.Account == account && c.commentId == CommentId) != null) return BadRequest();

      CommentPrase CommentPrase = new CommentPrase(account, CommentId);

      try
      {
        db.CommentsPrases.Add(CommentPrase);
        db.SaveChanges();
        return NoContent();
      }
      catch (Exception e)
      {
        return BadRequest();
      }
    }
    //根据commentId删除
    [HttpDelete]
    public ActionResult<CommentPrase> DeletePrase(string account, int Id)
    {
      try
      {
        CommentPrase prase = db.CommentsPrases.FirstOrDefault(c => c.Account == account && c.commentId == Id);
        db.CommentsPrases.Remove(prase );
        db.SaveChanges();
        return NoContent();
      }
      catch (Exception e)
      {
        return BadRequest(e);
      }
    }



    //判断用户是否点赞
    [HttpGet]
    public bool JudgeCommentPrase(string account, int Id)
    {
      return db.CommentsPrases.Any(c => c.Account == account && c.commentId == Id);
    }

  }
}



