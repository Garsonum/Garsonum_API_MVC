using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garsonum_API_MVC.Models
{
    public class CafesDb
    {
        GarsonumContext garsonum = new GarsonumContext();

        public IEnumerable<Cafe> GetCafes()
        {
            return garsonum.Cafe.ToList();
        }

        public IEnumerable<Cafe> GetById(int ID)
        {
            return garsonum.Cafe.Where(c => c.CId == ID).ToList();
        }
        public void Delete(int id)
        {
            garsonum.Cafe.Remove(garsonum.Cafe.Where(c => c.CId == id).First());
        }
        public void Create(Cafe cafe)
        {
            garsonum.Cafe.Add(cafe);
            garsonum.SaveChangesAsync();

        }
    }
}
