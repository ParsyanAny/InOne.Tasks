using System.Linq;

namespace InOne.Task.RoomReserveDB.Extensions
{
    public static class BaseExtentions
    {
        #region Delete Extentions
        public static void DeleteAllRooms(this ApplicationContext context)
         => context.Rooms.RemoveRange(context.Rooms.AsQueryable());
        public static void DeleteAllUsers(this ApplicationContext context)
         =>   context.Users.RemoveRange(context.Users.AsQueryable());
        public static void DeleteAllReservations(this ApplicationContext context)
         => context.Reservations.RemoveRange(context.Reservations.AsQueryable());
        public static void DeleteAllFurnitures(this ApplicationContext context)
         => context.Furnitures.RemoveRange(context.Furnitures.AsQueryable());
        public static void DeleteAllRoomFurnitures(this ApplicationContext context)
         => context.RoomFurnitures.RemoveRange(context.RoomFurnitures.AsQueryable());
        public static void DeleteAllReservationFurnitures(this ApplicationContext context)
         => context.ReservationFurnitures.RemoveRange(context.ReservationFurnitures.AsQueryable());
        public static void DeleteAllReservationTime(this ApplicationContext context)
         => context.ReservationTimes.RemoveRange(context.ReservationTimes.AsQueryable());
        #endregion
        //There must be generic DeleteAll with reflection
        //public static void DeleteAll(this ApplicationContext context, DbSet set)
        //{
        //    Type t = new 
        //    context.
        //}
    }
}
