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
    public class CategoryController : ControllerBase
    {
        CategoryDb cadb = new CategoryDb();

        // GET: api/Cafes
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return cadb.GetCategory();
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "GetCategory")]
        public IEnumerable<Category> Get(int id)
        {
            return cadb.GetCategoryById(id);
        }

        // POST: api/Category
        [HttpPost]
        public void Post(Category category)
        {
            cadb.Create(category);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            cadb.Delete(id);
        }
    }
}
