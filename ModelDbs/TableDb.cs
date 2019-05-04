using Garsonum_API_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garsonum_API_MVC.ModelDbs
{
    public class TableDb
    {
        GarsonumContext garsonum = new GarsonumContext();

        public IEnumerable<Table> GetTable()
        {
            return garsonum.Table.ToList();
        }

        public IEnumerable<Table> GetTableById(int ID)
        {
            return garsonum.Table.Where(t => t.TId == ID).ToList();
        }
        public void Delete(int id)
        {
            garsonum.Table.Remove(garsonum.Table.Where(t => t.TId == id).First());
        }
        public void Create(Table table)
        {
            garsonum.Table.Add(table);
            garsonum.SaveChanges();
        }
    }
}
