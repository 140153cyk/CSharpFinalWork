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
    public class CommentController : ControllerBase
    {

        private readonly PoemContext db;

        public CommentController(PoemContext context)
        {
            db = context;
        }
        //添加评论
        [HttpPost]
        public ActionResult<Comment> AddComment([FromBody]Comment comment)
        {
            try
            {
                comment.Poems = null;
                db.Comments.Add(comment);
                db.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return comment;
        }
        //获取评论，account:用户账户，poemid:诗词编号
        [HttpGet]
        public ActionResult<List<Comment>> GetComments(string account,int? poemId,int? skip,int? take)
        {
            try
            {
                IQueryable<Comment> query = db.Comments;
                if (account != null)
                {
                    query = query.Where(c =>
                      c.UserAccount == account
                    );

                }
                if (poemId != null)
                {
                    query = query.Where(c =>
                      c.PoemId == poemId
                    );
                }
                if (skip != null) query = query.Skip((int)skip);
                if (take != null) query = query.Take((int)take);

                return query.Include(c=>c.Replys).Include(c=>c.Poems).ThenInclude(p=>p.paragraphs).ToList();
            }catch(Exception e)
            {
                return NoContent();
            }
            
        }
        //修改评论，点赞或取消点赞
        [HttpPut("{id}")]
        public ActionResult<Comment> UpdateComment(int id,[FromBody]Comment comment)
        {
            if (comment.Id != id)
            {
                return BadRequest("不能修改ID");
            }
            try
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                return BadRequest("修改失败");
            }
            return comment;
        }
    }
}

