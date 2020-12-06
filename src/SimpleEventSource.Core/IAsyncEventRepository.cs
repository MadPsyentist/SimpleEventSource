namespace SimpleEventSource.Core {
    public interface IAsyncEventRepository<TEntity>
        where TEntity : IEntity {
            TEntity GetEntity(int id);
        }
}