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
    public class UserInfoController : ControllerBase
    {

        private readonly PoemContext db;

        public UserInfoController(PoemContext context)
        {
            db = context;
        }

        [HttpPost]
        public ActionResult<UserInfo> Register([FromBody] UserInfo info)
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

        [HttpGet("{account}")]
        public ActionResult<UserInfo> Login(string account)
        {
            var info = db.UserInfos.FirstOrDefault(i => i.account == account);
            if (info != null) return info;
            return null;
        }
        

    }
}
