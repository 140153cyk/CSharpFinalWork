using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PoemDataService.Models;
using System.Timers;
using System.Threading.Tasks;

namespace PoemDataService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoemController : ControllerBase
    {

        private readonly PoemContext db;
        private Timer reccommendTimer = new Timer();
        private int hour;
        private int minute;

        public PoemController(PoemContext context)
        {
            db = context;
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            reccommendTimer.Interval = 60000;
            reccommendTimer.Elapsed += new ElapsedEventHandler(onTimer);
            reccommendTimer.Enabled = true;
        }

        [HttpPost("userinfo")]
        public ActionResult<UserInfo> Register([FromBody]UserInfo info)
        {

            if (db.UserInfos.FirstOrDefault(i => i.account == info.account) != null) return BadRequest();
            else
            {
                db.UserInfos.Add(info);
                db.SaveChanges();
                return info;
            }
        }

        [HttpGet("userinfo/{account}")]
        public ActionResult<UserInfo> Login(string account)
        {
            var info = db.UserInfos.FirstOrDefault(i => i.account == account);
            if (info != null) return info;
            return null;
        }

        [HttpGet("poem")]
        public ActionResult<Poem>  GetOrder(String table)
        {
            return db.Poems.Include(p=>p.paragraphs).FirstOrDefault();         
        }

        public void UpdateRec()
        {
            foreach(Recommend r in db.Recommends)
            {

                
                //用户该天没有登录
                if (db.Finisheds.FirstOrDefault(f => f.account == r.account && f.PoemId == r.PoemId) != null) continue;
                //用户收藏为空
                if (db.Collects.FirstOrDefault(c => c.account == r.account) == null)
                {
                    r.PoemId = UpdateRandomReccommend(r.account);
                    continue;
                }
                //协同过滤
                int userCount = db.UserInfos.Count();
                Dictionary<string, int> neibors = new Dictionary<string, int>();
                int poemId = -1;
                Random random = new Random();
                for(int i = 0; i < 4; i++)
                {
                    int userId=random.Next(1, userCount);
                    string neiborAccount = db.UserInfos.FirstOrDefault(u => u.id == userId).account;
                    if (r.account != neiborAccount && !neibors.ContainsKey(neiborAccount)) neibors.Add(neiborAccount, 0);
                }
                if (neibors.Count == 0)
                {
                    r.PoemId = UpdateRandomReccommend(r.account);
                    continue;
                }
                foreach(Collect c in db.Collects.Where(c => c.account == r.account))
                {
                    foreach(string neibor in neibors.Keys)
                    {
                        if (db.Collects.FirstOrDefault(co => co.PoemId == c.PoemId && co.account == neibor) != null)
                        {
                            neibors[neibor] = neibors[neibor] + 1;
                        }
                    }
                }
                string commonest = neibors.Keys.OrderByDescending(k =>
                       neibors[k] * 1.0 / db.Collects.Where(c => c.account == k).Count()
                ).ToList().FirstOrDefault();
                
                foreach(Collect neiborCollect in db.Collects.Where(c => c.account == commonest))
                {
                    if (db.Finisheds.FirstOrDefault(f => f.PoemId == neiborCollect.PoemId && f.account == r.account) != null) continue;
                    poemId = neiborCollect.PoemId;
                    break;
                }
                if (poemId < 0)
                {
                    r.PoemId = UpdateRandomReccommend(r.account);
                }
                else r.PoemId = poemId;               
            }
            db.SaveChanges();
        }
        public int UpdateRandomReccommend(string account)//返回用户一条未读的诗词
        {
           return db.Poems.FirstOrDefault(p =>
                        db.Finisheds.FirstOrDefault(f => f.account == account && f.PoemId == p.id) == null
                    ).id;
        }
        private void onTimer(object sender, ElapsedEventArgs e)
        {
            minute += 1;
            hour += minute % 60;
            minute %= 60;
            hour %= 24;
            if (hour == 0 && minute == 0) Task.Run(UpdateRec);
        }
        


    }
}
