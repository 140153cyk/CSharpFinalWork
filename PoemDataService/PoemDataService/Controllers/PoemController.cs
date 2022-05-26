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


        public PoemController(PoemContext context)
        {
            db = context;
            reccommendTimer.Interval = 60000;
            reccommendTimer.Elapsed += new ElapsedEventHandler(onTimer);
            reccommendTimer.Enabled = true;
        }
        [HttpPost("poem")]//添加诗词到数据库，用于服务端数据库初始化
        public ActionResult<Poem> ImportPoem([FromBody]Poem newPoem)
        {
            try
            {
                db.Poems.Add(newPoem);
                db.SaveChanges();
                return NoContent();
            }catch(Exception e)
            {
                return BadRequest();
            }
            
        }
        [HttpGet("poem")]
        public ActionResult<Poem>  GetPoem(String table)
        {
            return db.Poems.Include(p=>p.paragraphs).FirstOrDefault();         
        }
        [HttpPost("userinfo")]
        public ActionResult<UserInfo> Register([FromBody]UserInfo info)
        {

            if (db.UserInfos.FirstOrDefault(i => i.account == info.account) != null) return BadRequest();
            else
            {
                db.UserInfos.Add(info);//添加用户登录信息
                db.Recommends.Add(new Recommend(info.account, 1));//添加用户默认推荐诗词
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
        //根据Url后带的account 和 poemId加入收藏
        [HttpPost("collect")]
        public ActionResult<Collect> AddCollect(string account,int poemId)
        {
            if (db.Collects.FirstOrDefault(c => c.account == account && c.PoemId == poemId) != null) return BadRequest();
            
            Collect collect = new Collect(account, poemId);
            
            try
            {
                db.Collects.Add(collect);
                db.SaveChanges();
                return NoContent();
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }
        //根据Url后带的accout和poemId删除收藏
        [HttpDelete("collect")]
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
        [HttpGet("collect")]
        public ActionResult<List<Collect>> GetCollect(string account)
        {
            return db.Collects.Where(c => c.account == account).ToList();
        }
        [HttpGet("recommend")]
        public ActionResult<Poem> GetRecommend(string account)
        {
            Recommend recommend=db.Recommends.FirstOrDefault(r => r.account == account);
            return db.Poems.
                Include(p=>p.paragraphs).
                FirstOrDefault(p => p.id == recommend.PoemId);
        }

        //更新用户的推荐诗词
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
            if (DateTime.Now.Hour == 0 && DateTime.Now.Minute == 0) Task.Run(UpdateRec);
        }
        


    }
}
