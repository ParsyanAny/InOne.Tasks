using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InOne.Task.RoomReserveDB.Models
{
    public class ReservationFurniture
    {
        [Key, Column(Order = 1)]
        public int ReservationId { get; set; }
        [Key, Column(Order = 2)]
        public int FurnitureId { get; set; }
        public int? Count { get; set; }
    }
}
