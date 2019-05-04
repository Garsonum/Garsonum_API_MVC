using Garsonum_API_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garsonum_API_MVC.ModelDbs
{
    public class HasDb
    {
        GarsonumContext garsonum = new GarsonumContext();

        public IEnumerable<Has> GetHas()
        {
            return garsonum.Has.ToList();
        }

    }
}
