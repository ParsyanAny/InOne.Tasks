using InOne.Task.RoomReserveDB.Extensions;
using InOne.Task.RoomReserveDB.Interfaces;
using InOne.Task.RoomReserveDB.Models;
using Mic.EFC.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InOne.Task.RoomReserveDB.Enums.Enums;

namespace InOne.Task.RoomReserveDB
{

    class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationContext();
            IUnitOfWork unit = new UnitOfWork(context);

            #region Users Test
            //context.DeleteAllUsers();
            //context.AddRandomUsers(25);
            //context.SaveChanges();
            //context.AddRandomUsers(50);
            //context.Users.ToArray().PrintUsers();
            #endregion

            #region  Furniture Test
            //context.Furnitures.ToArray().PrintFurnitures();
            #endregion

            #region Reservation Time Test
            //context.ReservationTimes.ToArray().PrintReservationTimes();
            #endregion

            #region Room Test ???
            //context.AddRandomRooms(50);
            //context.SaveChanges();
            //context.DeleteAllRooms();
            //context.SaveChanges();
            //context.Rooms.ToArray().PrintRooms();
            #endregion

            #region Reservation

            //context.AddRandomReservations(10);
            //context.SaveChanges();
            //context.Reservations.ToArray().PrintReservations();
            #endregion

            #region RoomFurniture Test
            //context.AddRandomRoomFurnitures(5);
            //context.SaveChanges();
            //context.RoomFurnitures.ToArray().PrintRoomFurnitures();
            #endregion

            #region ReservationFurniture Test

            //context.AddRandomReservationFurnitures(1);
            //context.SaveChanges();
            //context.ReservationFurnitures.ToArray().PrintReservationFurnitures();

            #endregion

            Console.Read();
        }
    }
}
