using Microsoft.AspNetCore.Mvc;
using PoemDataService.DAO;
using PoemDataService.Models;
using System;
using System.Linq;

namespace PoemDataService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PoetController : ControllerBase
    {

        private readonly PoemContext db;

        public PoetController(PoemContext context)
        {
            db = context;
        }
        //添加诗人信息
        [HttpPost]
        public ActionResult<Poet> AddCollect([FromBody] Poet newPoet)
        {
            try
            {
                db.Poets.Add(newPoet);
                db.SaveChanges();
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public ActionResult<Poet> GetPoet(string name)
        {
            return db.Poets.FirstOrDefault(p => p.name == name);
        }
    } 
}
