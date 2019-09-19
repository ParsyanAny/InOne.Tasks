using System.ComponentModel.DataAnnotations;

namespace InOne.Task.RoomReserveDB.Models
{
    public class RoomFurniture
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int FurnitureId { get; set; }
        [Required]
        public int ReservationId { get; set; }
        [Required]
        public int Count { get; set; }
    }
}
