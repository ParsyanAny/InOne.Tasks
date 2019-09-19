namespace InOne.Task.RoomReserveDB.Interfaces
{
    public interface IUnitOfWork
    {
        IFurnitureRepository FurnitureRepository { get; }
        IReservationRepository ReservationRepository { get; }
        IReservationTimeRepository ReservationTimeRepository { get; }
        IRoomRepository RoomRepository { get; }
        IUserRepository UserRepository { get; }
        void Commit();
        void RejectChanges();
        void Dispose();
    }
}
