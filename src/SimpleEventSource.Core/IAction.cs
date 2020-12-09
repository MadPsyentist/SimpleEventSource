namespace SimpleEventSource.Core {
    public interface IAction<TEntity>
        where TEntity : Entity {
        TEntity Apply(TEntity entity);           
    }
}