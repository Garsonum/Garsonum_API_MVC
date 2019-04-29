using System;
using System.Collections.Generic;

namespace Garsonum_API_MVC.Models
{
    public partial class Table
    {
        public Table()
        {
            User = new HashSet<User>();
        }

        public int TId { get; set; }
        public string TName { get; set; }
        public bool Enable { get; set; }
        public byte? Type { get; set; }
        public int CId { get; set; }

        public Cafe C { get; set; }
        public ICollection<User> User { get; set; }
    }
}
