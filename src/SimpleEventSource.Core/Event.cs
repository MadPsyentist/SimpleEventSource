using System;

namespace SimpleEventSource.Core {
    public class Event<TEntity> : IEvent<TEntity>
        where TEntity : Entity {
        public int Id { get; }
        public int EntityVersion { get; }
        public int EntityId { get; }
        public DateTime CreatedOn { get; }
        public IAction<TEntity> Action { get; }
        public TEntity Replay(TEntity entity) {
            var newEntity = entity with { Version = EntityVersion };
            newEntity = Action.Apply(newEntity);
            return newEntity;
        }
    }
}