using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garsonum_API_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garsonum_API_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CafesController : ControllerBase
    {
        CafesDb cdb = new CafesDb();

        // GET: api/Cafes
        [HttpGet]
        public IEnumerable<Cafe> Get()
        {
            return cdb.GetCafes();
        }

        // GET: api/Cafes/5
        [HttpGet("{id}", Name = "GetCafe")]
        public IEnumerable<Cafe> Get(int id)
        {
            return cdb.GetById(id);
        }

        // POST: api/Cafes
        [HttpPost]
        public void Post(Cafe cafe)
        {
            cdb.Create(cafe);
        }

        // PUT: api/Cafes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            cdb.Delete(id);
        }
    }
}
