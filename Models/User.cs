using System;
using System.Collections.Generic;

namespace Garsonum_API_MVC.Models
{
    public partial class User
    {
        public User()
        {
            Has = new HashSet<Has>();
        }

        public Guid UId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public int? TId { get; set; }

        public Table T { get; set; }
        public ICollection<Has> Has { get; set; }
    }
}
