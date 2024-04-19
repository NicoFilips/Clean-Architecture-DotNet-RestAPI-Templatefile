namespace Domain.Domain.ValueObjects;

public record DomainId(Guid Id = default)
{
    public Guid Id { get; init; } = Id == default ? Guid.NewGuid() : Id;
}
