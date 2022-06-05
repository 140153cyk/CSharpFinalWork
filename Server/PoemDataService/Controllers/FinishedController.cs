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
    public class FinishedController : ControllerBase
    {

        private readonly PoemContext db;

        public FinishedController(PoemContext context)
        {
            db = context;
        }
        //添加已读
        [HttpPost]
        public ActionResult<Finished> AddFinished([FromBody] Finished finished)
        {
            try
            {
                db.Finisheds.Add(finished);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return finished;
        }
        //判断是否已读
        [HttpGet]
        public bool AlreadyFinished(string account, int poemId)
        {
            return db.Finisheds.Any(f => f.account == account && f.PoemId == poemId);
        }
    }
}


