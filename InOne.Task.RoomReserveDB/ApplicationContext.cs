using InOne.Task.RoomReserveDB.Models;
using System.Data.Entity;

namespace InOne.Task.RoomReserveDB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationFurniture> ReservationFurnitures { get; set; }
        public DbSet<ReservationTime> ReservationTimes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomFurniture> RoomFurnitures { get; set; }
        public DbSet<User> Users { get; set; }


        public ApplicationContext() : base("MyDBContext") { }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Room>()
        //        .HasKey(p => p.Id);
        //}
    }
}
