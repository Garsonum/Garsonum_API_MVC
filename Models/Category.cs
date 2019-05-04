using System;
using System.Collections.Generic;

namespace Garsonum_API_MVC.Models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public int CId { get; set; }

        public Cafe C { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
