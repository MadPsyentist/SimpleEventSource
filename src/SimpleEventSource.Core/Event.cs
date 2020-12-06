using System;

namespace SimpleEventSource.Core {
    public class Event : IEvent {
        public int Id { get; }
        public int EntityVersion { get; }
        public int EntityId { get; }
        public DateTime CreatedOn { get; }
        public string ActionType { get; }
        public string ActionData { get; }
    }
}