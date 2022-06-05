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
using System.Security.Cryptography;
using System.Text;

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
                info.password = encrypt(info.password);
                db.UserInfos.Add(info);//添加用户登录信息
                db.Recommends.Add(new Recommend(info.account, 1));//添加用户默认推荐诗词
                db.SaveChanges();
                return info;
            }
        }

        [HttpGet]
        public bool Login(string account,string password)
        {
            if (account == null || password == null) return false;
            string encryptedPsw = encrypt(password);
            return db.UserInfos.Any(u => u.account == account && u.password == encryptedPsw);
        }
        
        public static string encrypt(string origin)
        {
            StringBuilder sb = new StringBuilder();
            using(MD5 md5 = MD5.Create())
            {
                byte[] originBytes = Encoding.UTF8.GetBytes(origin);
                byte[] encyptedBytes = md5.ComputeHash(originBytes);
                for(int i = 0; i < encyptedBytes.Length; i++)
                {
                    sb.Append(encyptedBytes[i].ToString("x"));
                }
                return sb.ToString();
            }
        }

    }
}
