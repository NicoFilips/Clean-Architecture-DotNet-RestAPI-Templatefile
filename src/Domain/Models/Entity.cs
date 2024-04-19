namespace Domain.Models;

public abstract class Entity 
{
    public Guid Id { get; protected init; }

    protected Entity(Guid Id)
    {
        this.Id = Id;
    }

}