using System;
using System.Collections.Generic;

namespace Garsonum_API_MVC.Models
{
    public partial class Cafe
    {
        public Cafe()
        {
            Category = new HashSet<Category>();
            Table = new HashSet<Table>();
        }

        public int CId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public string QrId { get; set; }
        public string Info { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public ICollection<Category> Category { get; set; }
        public ICollection<Table> Table { get; set; }
    }
}
