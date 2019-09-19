namespace InOne.Task.RoomReserveDB.Models
{
    public partial class ReservationTime
    {
        public string StartTime => Start.ToString("HH:mm");
        public string EndTime => End.ToString("HH:mm");
        public string FullTime => $"{StartTime} - {EndTime}";
    }
}
