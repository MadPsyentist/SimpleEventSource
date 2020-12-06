namespace SimpleEventSource.Core {
    public interface IAction<TEntity>
        where TEntity : IEntity
    {
        TEntity Apply(TEntity entity);           
    }
}