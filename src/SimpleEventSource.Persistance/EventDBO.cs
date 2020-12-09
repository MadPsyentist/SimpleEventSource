using System;

namespace SimpleEventSource.Persistence {
    public record EventDBO {
        public int Id { get; }
        public int EntityVersion { get; }
        public int EntityId { get; }
        public DateTime CreatedOn { get; }
        public string ActionType { get; }
        public string ActionData { get; }
    }
}