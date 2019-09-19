using InOne.Task.RoomReserveDB.Interfaces;
using InOne.Task.RoomReserveDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOne.Task.RoomReserveDB.Extensions
{
    public static class BaseExtentions
    {
        public static void DeleteAllRooms(this ApplicationContext context)
        {
            int count = context.Rooms.Count();
            while (count != 0)
            {
                Room room = context.Rooms.FirstOrDefault();  
                context.Rooms.Remove(room);
                count--;
            }
        }
    }
}
