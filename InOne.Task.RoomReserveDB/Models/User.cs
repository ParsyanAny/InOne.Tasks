using System;
using System.ComponentModel.DataAnnotations;

namespace InOne.Task.RoomReserveDB.Models
{
    public partial class User
    {
        [Key][Required]
        public int Id { get; set; }
        [MaxLength(50)][Required]
        public string Name { get; set; }
        [MaxLength(70)][Required]
        public string Surname { get; set; }
        public DateTime? BirthYear { get; set; }
    }
}
