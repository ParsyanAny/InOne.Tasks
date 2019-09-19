using System.ComponentModel.DataAnnotations;

namespace InOne.Task.RoomReserveDB.Models
{
    public class Furniture
    {
        [Key][Required]
        public int Id { get; set; }
        [MaxLength(50)][Required]
        public string TypeName { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
