using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.Models
{
    [Table("User")]
    public class User
    {
        [Column("Email")]
        public string Email { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Password")]
        public string Password { get; set; }

    }
}
