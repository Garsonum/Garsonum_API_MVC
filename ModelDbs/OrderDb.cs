using Garsonum_API_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garsonum_API_MVC.ModelDbs
{
    public class OrderDb
    {
        GarsonumContext garsonum = new GarsonumContext();

        public IEnumerable<Order> GetOrder()
        {
            return garsonum.Order.ToList();
        }

        public IEnumerable<Order> GetOrderById(int ID)
        {
            return garsonum.Order.Where(o => o.OId == ID).ToList();
        }
        public void Delete(int id)
        {
            garsonum.Order.Remove(garsonum.Order.Where(order => order.OId ==id ).First());
        }
        public void Create(Order order)
        {
            garsonum.Order.Add(order);
            garsonum.SaveChangesAsync();
        }
    }
}
