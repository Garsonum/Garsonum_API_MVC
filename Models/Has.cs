using System;
using System.Collections.Generic;

namespace Garsonum_API_MVC.Models
{
    public partial class Has
    {
        public int UId { get; set; }
        public int OId { get; set; }
        public int PId { get; set; }
        public double? PPortion { get; set; }
        public int PAmount { get; set; }

        public Order O { get; set; }
        public Product P { get; set; }
        public User U { get; set; }
    }
}
