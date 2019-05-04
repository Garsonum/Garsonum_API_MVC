using Garsonum_API_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garsonum_API_MVC.ModelDbs
{
    public class CategoryDb
    {
        GarsonumContext garsonum = new GarsonumContext();

        public IEnumerable<Category> GetCategory()
        {
            return garsonum.Category.ToList();
        }

        public IEnumerable<Category> GetCategoryById(int ID)
        {
            return garsonum.Category.Where(ca => ca.CatId == ID).ToList();
        }
        public void Delete(int id)
        {
            garsonum.Category.Remove(garsonum.Category.Where(c=> c.CId==id).First());
        }
        public void Create(Category category)
        {
            garsonum.Category.Add(category);
            garsonum.SaveChangesAsync();
        }
    }
}
