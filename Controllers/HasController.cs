using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Garsonum_API_MVC.ModelDbs;
using Garsonum_API_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Garsonum_API_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HasController : ControllerBase
    {
        HasDb hdb = new HasDb();
        // GET: api/Has
        [HttpGet]
        public IEnumerable<Has> Get()
        {
            return hdb.GetHas();
        }

        // GET: api/Has/5
        [HttpGet("{id}", Name = "GetHas")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Has
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Has/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
