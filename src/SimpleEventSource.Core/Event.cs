using System;

namespace SimpleEventSource.Core {
    public class Event<TEntity> : IEvent<TEntity>
        where TEntity : IEntity {
        public int Id { get; }
        public int EntityVersion { get; }
        public int EntityId { get; }
        public DateTime CreatedOn { get; }
        public IAction<TEntity> Action { get; }
        public TEntity Replay(TEntity entity) {
            entity = Action.Apply(entity);
            entity.Version = EntityVersion;
            return entity;
        }
    }
}