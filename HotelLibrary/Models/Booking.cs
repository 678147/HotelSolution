using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.Models
{
    class Booking
    {
        string email { get; set; }
        int RoomNumber { get; set; }
        string CheckInDate { get; set; }
        string CheckOutDate { get; set; }
    }
}
