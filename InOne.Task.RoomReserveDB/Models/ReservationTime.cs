using System;
using System.ComponentModel.DataAnnotations;

namespace InOne.Task.RoomReserveDB.Models
{
    public partial class ReservationTime
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
