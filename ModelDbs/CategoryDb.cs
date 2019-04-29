using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garsonum_API_MVC.Models
{
    public class CategoryDb
    {
        GarsonumContext garsonum = new GarsonumContext();
        public IEnumerable<Category> GetCafes()
        {
            return garsonum.Category.ToList();
        }
        public IEnumerable<Category> GetById(int ID)
        {
            return garsonum.Category.Where(c => c.CatId == ID).ToList();
        }
    }
}
