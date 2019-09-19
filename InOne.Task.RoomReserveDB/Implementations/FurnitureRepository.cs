using InOne.Task.RoomReserveDB.Interfaces;
using InOne.Task.RoomReserveDB.Models;
using Mic.EFC.Repository;
using System.Data.Entity;

namespace InOne.Task.RoomReserveDB.Implementations
{
    public class FurnitureRepository : BaseRepository<Furniture>, IFurnitureRepository
    {
        public FurnitureRepository(DbContext context) : base(context) { }
    }
}
