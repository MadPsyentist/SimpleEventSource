using SimpleEventSource.Core;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleEventSource.Persistence {
    public interface IAsyncEventRepository<TEntity>
        where TEntity : Entity {
            Task<TEntity> GetEntity(int id);
            Task SaveAction(int entityId, IAction<TEntity> action);
            Task<int[]> GetEntityIds();
            void AddAction(IAction<TEntity> action);
        }
}