namespace SimpleEventSource.Core {
    public abstract record Entity {
        public int Id { get; init; }
        public int Version { get; init; } = 0;
    }
}