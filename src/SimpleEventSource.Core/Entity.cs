namespace SimpleEventSource.Core {
    public abstract class Entity : IEntity {
        public int Id { get; }
        public int Version { get; private set; } = 0;
    }
}