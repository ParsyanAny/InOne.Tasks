namespace InOne.Task.RoomReserveDB.Interfaces
{
    public interface IBaseRepository<TEntity> :  IActionRepository<TEntity>, IReadOnlyRepository<TEntity>
         where TEntity : class, new()
    { }
}
