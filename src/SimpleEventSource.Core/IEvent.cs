using System;

namespace SimpleEventSource.Core {
    public interface IEvent<TEntity>
        where TEntity : IEntity {
        int Id { get; }
        int EntityVersion { get; }
        int EntityId { get; }
        DateTime CreatedOn { get; }
        IAction<TEntity> Action { get; }
        TEntity Replay(TEntity entity);
    }
}