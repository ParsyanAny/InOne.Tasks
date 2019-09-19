using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InOne.Task.RoomReserveDB.Interfaces
{
    public interface IReadOnlyRepository<TEntity>
         where TEntity : class, new()
    {
        bool Any(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id);
    }
}
