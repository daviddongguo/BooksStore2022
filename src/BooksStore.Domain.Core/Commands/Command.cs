using BooksStore.Domain.Core.Events;

namespace BooksStore.Domain.Core.Commands;
public abstract class Command : Message
{
    public DateTime Timestamp { get; set; }
    protected Command()
    {
        Timestamp = DateTime.Now;
    }
}
