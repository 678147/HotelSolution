using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.Models
{
    [Table("Booking")]
    public class Booking
    {
        [Column("Email")]
        public string Email { get; set; }
        [Column("RoomNumber")]
        public int RoomNumber { get; set; }
        [Column("CheckIn")]
        public string CheckInDate { get; set; }
        [Column("CheckOut")]
        public string CheckOutDate { get; set; }
        [Column("checkedIn")]
        public Boolean CheckedIn { get; set; }
    }
}
