using System.Threading;
using System.Threading.Tasks;

namespace SimpleEventSource.Core {
    public interface IAsyncEventRepository<TEntity>
        where TEntity : IEntity {
            Task<TEntity> GetEntity(int id);
            Task SaveAction(int entityId, IAction<TEntity> action);
            Task<int[]> GetEntityIds();
        }
}