using System;
using System.ComponentModel.DataAnnotations;

namespace InOne.Task.RoomReserveDB.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RoomId { get; set; }
        [Required]
        public int ReservationTimeId { get; set; }
        public DateTime? Time1 { get; set; }
        public DateTime? Time2 { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
