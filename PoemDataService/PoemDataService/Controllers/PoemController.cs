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
    public class PoemController : ControllerBase
    {

        private readonly PoemContext db;

        public PoemController(PoemContext context)
        {
            db = context;
        }
        [HttpPost]//添加诗词到数据库，用于服务端数据库初始化
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
        [HttpGet]
        public ActionResult<Poem>  GetPoem()
        {
            return db.Poems.Include(p=>p.paragraphs).FirstOrDefault();         
        }


        [HttpGet("exists")]
        public bool ExistsSentence(string text)
        {
            Paragraph paragraph = db.Paragraphs.FirstOrDefault(p =>
              p.value.Contains(text));
            if (paragraph == null) return false;
            Regex inSentence = new Regex("[，。！？]" + text + "[，。！？]");
            Regex atStart = new Regex("^" + text + "[，。？！]");
            return inSentence.IsMatch(paragraph.value)||atStart.IsMatch(paragraph.value);
        }



    }
}
