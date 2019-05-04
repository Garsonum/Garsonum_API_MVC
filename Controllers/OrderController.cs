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
    public class OrderController : ControllerBase
    {
        OrderDb odb = new OrderDb();
        // GET: api/Order
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return odb.GetOrder() ;
        }

        // GET: api/Order/5
        [HttpGet("{id}", Name = "GetOrder")]
        public IEnumerable<Order> Get(int id)
        {
            return odb.GetOrderById(id);
        }

        // POST: api/Order
        [HttpPost]
        public void Post(Order order)
        {
            odb.Create(order);
        }

        // PUT: api/Order/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            odb.Delete(id);
        }
    }
}
