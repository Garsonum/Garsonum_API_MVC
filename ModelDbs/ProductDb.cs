using Garsonum_API_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garsonum_API_MVC.ModelDbs
{
    public class ProductDb
    {
        GarsonumContext garsonum = new GarsonumContext();

        public IEnumerable<Product> GetProduct()
        {
            return garsonum.Product.ToList();
        }

        public IEnumerable<Product> GetProductById(int ID)
        {
            return garsonum.Product.Where(p => p.PId == ID).ToList();
        }
        
        public void Delete(int id)
        {
            garsonum.Product.Remove(garsonum.Product.Where(p => p.PId == id).First());
        }

        public void Create(Product product)
        {
            garsonum.Product.Add(product);
            garsonum.SaveChangesAsync();
        }
    }
}
