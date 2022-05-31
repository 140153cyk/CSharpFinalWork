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
        public ActionResult<List<Poem>>  GetPoem(string title,string author)
        {
            IQueryable<Poem> query = db.Poems;
            if (title != null)
            {
                query = query.Where(p =>
                  p.title == title
                );
            }
            if (author != null)
            {
                query = query.Where(p =>
                  p.author == author
                );
            }

            
            return query.Include(p=>p.paragraphs).ToList();         
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
