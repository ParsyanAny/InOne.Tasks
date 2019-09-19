using InOne.Task.RoomReserveDB.Interfaces;
using InOne.Task.RoomReserveDB.Models;
using Mic.EFC.Repository;
using System.Data.Entity;

namespace InOne.Task.RoomReserveDB.Implementations
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(DbContext context) : base(context) { }
    }
}
