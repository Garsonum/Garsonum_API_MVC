using System;
using System.Collections.Generic;

namespace Garsonum_API_MVC.Models
{
    public partial class Product
    {
        public Product()
        {
            Has = new HashSet<Has>();
        }

        public int PId { get; set; }
        public string PName { get; set; }
        public string Description { get; set; }
        public bool PType { get; set; }
        public double? Price { get; set; }
        public string PImage { get; set; }
        public int CatId { get; set; }

        public Category Cat { get; set; }
        public ICollection<Has> Has { get; set; }
    }
}
