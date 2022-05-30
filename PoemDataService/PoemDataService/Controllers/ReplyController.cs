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
    public class ReplyController : ControllerBase
    {

        private readonly PoemContext db;

        public ReplyController(PoemContext context)
        {
            db = context;
        }
        //添加评论
        [HttpPost]
        public ActionResult<Reply> AddReply([FromBody] Reply  reply)
        {
            try
            {
                db.Replies.Add(reply);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return reply;
        }
        //获取回复，account:用户账户
        [HttpGet]
        public ActionResult<List<Reply>> GetReplies(string account, int? skip, int? take)
        {
            try
            {
                IQueryable<Reply> query = db.Replies;
                if (account != null)
                {
                    query = query.Where(r =>
                      r.userAccount == account
                    );
                }
                if (skip != null) query = query.Skip((int)skip);
                if (take != null) query = query.Take((int)take);

                return query.ToList();
            }
            catch (Exception e)
            {
                return NoContent();
            }

        }
        //修改回复，点赞或取消点赞
        [HttpPut("{id}")]
        public ActionResult<Reply> UpdateReply(int id, [FromBody] Reply reply)
        {
            if (reply.Id != id)
            {
                return BadRequest("不能修改ID");
            }
            try
            {
                db.Entry(reply).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                return BadRequest("修改失败");
            }
            return reply;
        }
    }
}
