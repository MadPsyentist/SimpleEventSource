namespace SimpleEventSource.Core {
    public interface IEntity {
        int Id { get; }
        int Version { get; }
    }
}