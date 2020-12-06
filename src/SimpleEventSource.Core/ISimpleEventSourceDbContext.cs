using Microsoft.EntityFrameworkCore;

namespace SimpleEventSource.Core {
    public interface ISimpleEventSourceDbContext {
        DbSet<Event>
    }
}