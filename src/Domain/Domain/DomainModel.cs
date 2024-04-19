using Domain.Domain.ValueObjects;

namespace Domain.Domain;

public class DomainModel
{
    public DomainId Id { get; }
    public DomainValueObject ValueObject { get; }
    
    public DomainModel(DomainId id, DomainValueObject valueObject)
    {
        Id = id;
        ValueObject = valueObject;
    }
}