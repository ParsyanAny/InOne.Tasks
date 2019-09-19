using InOne.Task.RoomReserveDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InOne.Task.RoomReserveDB.Enums.Enums;
namespace InOne.Task.RoomReserveDB.Extensions
{

    public static class CreateRandomEntities
    {
        public static User CreateUser(this User user)
        {
            Random rand = new Random();
            user.Name = $"{(Names)rand.Next(0, Enum.GetValues(typeof(Names)).Cast<Names>().Distinct().Count())}";
            user.Surname = $"{(Surnames)rand.Next(0, Enum.GetValues(typeof(Surnames)).Cast<Surnames>().Distinct().Count())}";
            user.BirthYear = new DateTime(rand.Next(1920, 2010), rand.Next(1, 12), rand.Next(1, 28));
            return user;
        }
        public static void AddRandomUsers(this ApplicationContext context, int count)
        {
            while (count != 0)
            {
                User user = new User();
                context.Users.Add(user.CreateUser());
                count--;
            }
        }
        public static Room CreateRoom(this ApplicationContext context)
        {
            Room room = new Room();
            Random rand = new Random();
            int rn = rand.Next(1, 10);
            room.Number = rand.Next(1, 500);
            room.Price = rand.Next(20, 1500) / 3;
            room.IsEmpty = room.Number % 3 + 1 == 0 ? true : false;
            room.ParentRoom = room.Number % 5 == 0 ? context.Rooms.First(p=> p.Id % rn == 0) : null;
            room.ParentRoomId = room.ParentRoom?.Id;
            return room;
        }
        public static void AddRandomRooms(this ApplicationContext context, int count)
        {
            while (count != 0)
            {
                context.Rooms.Add(context.CreateRoom());
                count--;
            }
        }
        public static Reservation CreateReservation(this Reservation reservation)
        {
            Random rand = new Random();
            reservation.ReservationTimeId = rand.Next(1,24);
            reservation.RoomId = rand.Next(100, 500);
            reservation.UserId = rand.Next(0,500);
            return reservation;
        }
        public static void AddRandomReservations(this ApplicationContext context, int count)
        {
            while (count != 0)
            {
                Reservation reservation = new Reservation();
                context.Reservations.Add(reservation.CreateReservation());
                count--;
            }
        }
    }
}
