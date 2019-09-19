using InOne.Task.RoomReserveDB.Models;
using System;
using System.Collections.Generic;

namespace InOne.Task.RoomReserveDB.Extensions
{
    public static class Print
    {
        public static void PrintFurnitures(this IEnumerable<Furniture> furniture)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ID\tTypename - Price\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in furniture)
            {
                Console.WriteLine($"{item.Id}\t{item.TypeName} - {item.Price}$");
            }
            Console.ResetColor();
        }
        public static void PrintUsers(this IEnumerable<User> users)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ID\tFullname \t\tAge\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Id} \t{item.FullName}   \t{item.IsAdult}({item.Age})");
            }
            Console.ResetColor();
        }
        public static void PrintReservationTimes(this IEnumerable<ReservationTime> times)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Start    End");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in times)
            {
                Console.WriteLine($"{item.FullTime}");
            }
            Console.ResetColor();
        }
        public static void PrintRooms(this IEnumerable<Room> rooms)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ID\tNumber\tPrice\tParentRoom Id");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in rooms)
            {
                Console.WriteLine($"{item.Id}\t{item.Number}\t{item.Price}$\t{item.ParentRoomId}");
            }
            Console.ResetColor();
        }
        public static void PrintReservations(this IEnumerable<Reservation> reservations)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ID\tUserID\tRoomID\tReservationTimeID");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in reservations)
            {
                Console.WriteLine($"{item.Id}\t{item.UserId}\t{item.RoomId}\t{item.ReservationTimeId}");
            }
            Console.ResetColor();
        }
        public static void PrintReservationFurnitures(this IEnumerable<ReservationFurniture> resfurs)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FurnitureID ReservationID FurnitureCount");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var item in resfurs)
            {
                Console.WriteLine($"{item.FurnitureId}\t    {item.ReservationId}\t\t  {item.Count}");
            }
            Console.ResetColor();
        }
        public static void PrintRoomFurnitures(this IEnumerable<RoomFurniture> roomfurs)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ID\tReservationID   FurnitureID    Count");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in roomfurs)
            {
                Console.WriteLine($"{item.Id}\t{item.ReservationId}\t\t{item.FurnitureId}\t\t{item.Count}");
            }
            Console.ResetColor();
        }
    }
}
