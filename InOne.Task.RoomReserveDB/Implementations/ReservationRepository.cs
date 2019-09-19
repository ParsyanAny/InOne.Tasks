using InOne.Task.RoomReserveDB.Interfaces;
using InOne.Task.RoomReserveDB.Models;
using Mic.EFC.Repository;
using System.Data.Entity;

namespace InOne.Task.RoomReserveDB.Implementations
{
    public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(DbContext context) : base(context) { }

    }
}
