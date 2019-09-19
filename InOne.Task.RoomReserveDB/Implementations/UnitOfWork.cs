using InOne.Task.RoomReserveDB.Implementations;
using InOne.Task.RoomReserveDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Mic.EFC.Repository.Impl
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private bool disposed;
        private readonly Dictionary<string, object> repositories;

        public UnitOfWork(DbContext _dbContext)
        {
            this._dbContext = _dbContext;
            repositories = new Dictionary<string, object>();
        }

        public IFurnitureRepository FurnitureRepository => Repository<FurnitureRepository>();
        public IReservationTimeRepository ReservationTimeRepository => Repository<ReservationTimeRepository>();
        public IReservationRepository ReservationRepository => Repository<ReservationRepository>();
        public IRoomRepository RoomRepository => Repository<RoomRepository>();
        public IUserRepository UserRepository => Repository<UserRepository>();


        private TRepository Repository<TRepository>()
        {
            var type = typeof(TRepository);
            if (!repositories.ContainsKey(type.Name))
            {
                var obj = Activator.CreateInstance(type, _dbContext);
                repositories.Add(type.Name, obj);
            }
            return (TRepository)repositories[type.Name];
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
        public void RejectChanges()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries()
                  .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            disposed = true;
        }
    }
}
