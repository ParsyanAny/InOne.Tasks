using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InOne.Task.RoomReserveDB.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        public bool IsEmpty { get; set; }
        [Required]
        public double Price { get; set; }
        public Room ParentRoom { get; set; }
        [ForeignKey("ParentRoom")]
        public int? ParentRoomId { get; set; }
    }
}
