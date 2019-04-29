using System;
using System.Collections.Generic;

namespace Garsonum_API_MVC.Models
{
    public partial class Order
    {
        public Order()
        {
            Has = new HashSet<Has>();
        }

        public int OId { get; set; }
        public double? TotalPrice { get; set; }
        public bool PaidInfo { get; set; }

        public ICollection<Has> Has { get; set; }
    }
}
