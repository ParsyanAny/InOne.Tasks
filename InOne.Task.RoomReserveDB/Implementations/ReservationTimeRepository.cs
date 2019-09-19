using InOne.Task.RoomReserveDB.Interfaces;
using InOne.Task.RoomReserveDB.Models;
using Mic.EFC.Repository;
using System.Data.Entity;

namespace InOne.Task.RoomReserveDB.Implementations
{
    public class ReservationTimeRepository : BaseRepository<ReservationTime>, IReservationTimeRepository
    {
        public ReservationTimeRepository(DbContext context) : base(context) { }

    }
}
