using Garsonum_API_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garsonum_API_MVC.ModelDbs
{
    public class UserDb
    {
        GarsonumContext garsonum = new GarsonumContext();
       
        public IEnumerable<User> GetUser()
        {
            return garsonum.User.ToList();
        }

        public IEnumerable<User> GetUserById(Guid ID)
        {
            return garsonum.User.Where(u => u.UId.Equals(ID) ).ToList();
        }
        public IEnumerable<Product> GetOrdersById(Guid id)
        {
            var orders = (from u in garsonum.User
                          where u.UId ==id
                          join has in garsonum.Has on u.UId equals has.UId
                          join p in garsonum.Product on has.PId equals p.PId
                          select p).ToList();

            return orders;
        }
        public IEnumerable<Cafe> GetFavCafes(Guid id)
        {
            var favCafes = (from u in garsonum.User
                            where u.UId == id
                            join t in garsonum.Table on u.TId equals t.TId
                            join c in garsonum.Cafe on t.CId equals c.CId
                            select c);
          
            return favCafes;
        }
       public void Delete(Guid id)
        {
            User user = new User();
            user = garsonum.User.Where(u => u.UId.Equals(id)).First();
            garsonum.User.Remove(user);

        }
        public void Create(User user)
        {
            garsonum.User.Add(user);
            garsonum.SaveChangesAsync();
        }
    }
}
