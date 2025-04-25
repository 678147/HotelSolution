using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.Models
{
    [Table("Maintenace")]
    class Maintenace
    {
        [Column("id")]
        public int MaintenaceId { get; set; }
        [Column("RoomNumber")]
        public int RoomNumber { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("TaskStatus")]
        public int TaskStatus { get; set; }
        [Column("TaskType")]
        public int TaskType { get; set; }
    }
}
