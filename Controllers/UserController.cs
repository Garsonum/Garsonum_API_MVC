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
    public class UserController : ControllerBase
    {
        UserDb udb = new UserDb();
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return udb.GetUser() ;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "GetUser")]
        public IEnumerable<User> Get(Guid id)
        {
            return udb.GetUserById(id);
        }
        //Get: api/user/getordersbyıd/9ABC84D4-5E07-47C4-9F1B-210B4729ACDF
        [HttpGet ("[action]/{id}")]
        public IEnumerable<Product> GetOrders(Guid id)
        {
            return udb.GetOrdersById(id);
        }
        // POST: api/User
        [HttpPost]
        public void Post(User user)
        {
            udb.Create(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        { 
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            udb.Delete(id);
        }
    }
}
