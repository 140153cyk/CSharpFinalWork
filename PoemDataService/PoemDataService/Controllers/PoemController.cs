using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PoemDataService.Models;

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

        [HttpGet]
        //Get全部的Order
        public ActionResult<Poem> GetOrder()
        {
            return null;
        }

    }
}
