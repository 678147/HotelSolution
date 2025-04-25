using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.Models
{
    [Table("Room")]
    class Room
    {
        [Column("RoomNumber")]
        public int RoomNumber { get; set; }
        [Column("RoomSize")]
        public int RoomSize { get; set; }
        [Column("RoomType")]
        public int RoomType { get; set; }
    }
}
