using Microsoft.EntityFrameworkCore;

namespace SimpleEventSource.Persistence {
    public interface ISimpleEventSourceDbContext {
        DbSet<EventDBO> GetEvents();
    }
}