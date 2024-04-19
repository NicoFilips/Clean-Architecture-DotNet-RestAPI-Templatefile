namespace Domain.Models;

public abstract class AggregateRoot
{
    public Guid Id { get; protected init; }
    
    protected AggregateRoot(Guid id)
    {
        Id = id;
    }
}