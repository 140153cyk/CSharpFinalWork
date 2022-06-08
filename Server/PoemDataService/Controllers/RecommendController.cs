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
using Microsoft.EntityFrameworkCore.Internal;

namespace PoemDataService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReccommendController : ControllerBase
    {

        private readonly PoemContext db;
//        private Timer reccommendTimer = new Timer();

        public ReccommendController(PoemContext context)
        {
            db = context;
/*            reccommendTimer.Interval = 6000;
            reccommendTimer.Elapsed += new ElapsedEventHandler(onTimer);
            reccommendTimer.Start();*/
        }
       
        [HttpGet("{account}")]
        public ActionResult<Poem> GetRecommend(string account)
        {
            Recommend recommend = db.Recommends.FirstOrDefault(r => r.account == account);
            if (recommend == null) return BadRequest();
            UpdateRec(recommend);
            db.SaveChanges();
            return db.Poems.
                Include(p => p.paragraphs).
                FirstOrDefault(p => p.id == recommend.PoemId);
        }

        //更新用户的推荐诗词
        public void UpdateRec(Recommend r)
        {
            //用户没有查看上次推荐
            if (!db.Finisheds.Any(f => f.account == r.account && f.PoemId == r.PoemId)) return;
            //用户收藏为空
            if (!db.Collects.Any(c => c.account == r.account))
            {
                r.PoemId = UpdateRandomReccommend(r.account);
                return;
            }
            //协同过滤
            Dictionary<string, int> neibors = new Dictionary<string, int>();
            int poemId = -1;
            Random random = new Random();
            int total = db.UserInfos.Count();
            for (int i = 0; i < 4; i++)
            {            
                string neiborAccount = db.UserInfos.Skip(random.Next(total)).First().account;
                if (r.account != neiborAccount && !neibors.ContainsKey(neiborAccount)) neibors.Add(neiborAccount, 0);
            }
            if (neibors.Count == 0)
            {
                r.PoemId = UpdateRandomReccommend(r.account);
                return;
            }
            Collect[] collects = db.Collects.Where(c => c.account == r.account).ToArray();
            foreach (Collect c in collects)
            {
                foreach (string neibor in neibors.Keys)
                {
                    if (db.Collects.Any(co => co.PoemId == c.PoemId && co.account == neibor))
                    {
                        neibors[neibor] = neibors[neibor] + 1;
                    }
                }
            }
            string commonest = neibors.Keys.OrderByDescending(k =>
                   neibors[k] * 1.0 / db.Collects.Where(c => c.account == k).Count()
            ).FirstOrDefault();

            Collect[] neiborCollects = db.Collects.Where(c => c.account == commonest).ToArray();
            foreach (Collect neiborCollect in neiborCollects)
            {
                if (db.Finisheds.Any(f => f.PoemId == neiborCollect.PoemId && f.account == r.account)) continue;
                poemId = neiborCollect.PoemId;
                break;
            }
            if (poemId < 0)
            {
                r.PoemId = UpdateRandomReccommend(r.account);
            }
            else r.PoemId = poemId;
           
        }
        public int UpdateRandomReccommend(string account)//返回用户一条未读的诗词
        {
            return db.Poems.FirstOrDefault(p =>
                         db.Finisheds.FirstOrDefault(f => f.account == account && f.PoemId == p.id) == null
                     ).id;
        }



    }
}
