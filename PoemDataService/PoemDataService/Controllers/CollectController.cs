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
    public class CollectController : ControllerBase
    {

        private readonly PoemContext db;

        public CollectController(PoemContext context)
        {
            db = context;
        }
        //根据Url后带的account 和 poemId加入收藏
        [HttpPost]
        public ActionResult<Collect> AddCollect(string account, int poemId)
        {
            if (db.Collects.FirstOrDefault(c => c.account == account && c.PoemId == poemId) != null) return BadRequest();

            Collect collect = new Collect(account, poemId);

            try
            {
                db.Collects.Add(collect);
                db.SaveChanges();
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        //根据Url后带的accout和poemId删除收藏
        [HttpDelete]
        public ActionResult<Collect> DeleteCollect(string account, int poemId)
        {
            try
            {
                db.Collects.Remove(
                    db.Collects.FirstOrDefault(c => c.account == account && c.PoemId == poemId)
                    );
                db.SaveChanges();
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        //根据Url后带的account获取某个用户的全部收藏
        [HttpGet("{account}")]
        public ActionResult<List<Poem>> GetCollect(string account)
        {
            return db.Poems.Where(p =>
            db.Collects.Any(c => c.account == account && c.PoemId == p.id)
            ).Include(p=>p.paragraphs).ToList(); 
        }
        //判断用户是否有某首诗的收藏
        [HttpGet]
        public bool JudgeCollect(string account, int poemId)
        {
            return db.Collects.Any(c => c.account == account && c.PoemId == poemId);
        }
    }
}
