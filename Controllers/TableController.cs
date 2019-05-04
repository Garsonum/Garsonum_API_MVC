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
    public class TableController : ControllerBase
    {
        TableDb tdb = new TableDb();
        // GET: api/Table
        [HttpGet]
        public IEnumerable<Table> Get()
        {
            return tdb.GetTable();
        }

        // GET: api/Table/5
        [HttpGet("{id}", Name = "GetTable")]
        public IEnumerable<Table> Get(int id)
        {
            return tdb.GetTableById(id);
        }

        // POST: api/Table
        [HttpPost]
        public void Post(Table table)
        {
            tdb.Create(table);
        }

        // PUT: api/Table/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            tdb.Delete(id);
        }
    }
}
