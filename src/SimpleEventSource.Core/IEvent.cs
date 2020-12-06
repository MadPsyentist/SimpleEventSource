using System;

namespace SimpleEventSource.Core {
    public interface IEvent {
        int Id { get; }
        int EntityVersion { get; }
        int EntityId { get; }
        DateTime CreatedOn { get; }
    }
}