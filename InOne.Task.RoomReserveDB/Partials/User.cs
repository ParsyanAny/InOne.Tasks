using System;

namespace InOne.Task.RoomReserveDB.Models
{
    public partial class User
    {
        public string FullName => $"{Surname} {Name}";
        public int Age => DateTime.Now.Year - BirthYear.Value.Year;
        public string IsAdult => Age > 18 ? "Is Adult" : "Is Teenage" ; 
       
    }
}
