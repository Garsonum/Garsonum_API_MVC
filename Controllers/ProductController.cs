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
    public class ProductController : ControllerBase
    {
        ProductDb pdb = new ProductDb();
        // GET: api/Product
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return pdb.GetProduct();
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "GetProduct")]
        public IEnumerable<Product> Get(int id)
        {
            return pdb.GetProductById(id);
        }

        // POST: api/Product
        [HttpPost]
        public void Post(Product product)
        {
            pdb.Create(product);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            pdb.Delete(id);
        }
    }
}
