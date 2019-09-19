using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOne.Task.RoomReserveDB.Interfaces
{
    public interface IActionRepository<TEntity>
        where TEntity : class, new()
    {
        void Delete(TEntity entity);
        void DeleteById(int id);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
