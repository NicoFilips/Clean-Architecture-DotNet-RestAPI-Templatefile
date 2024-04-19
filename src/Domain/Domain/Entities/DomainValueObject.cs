namespace Domain.Domain.ValueObjects;

public record DomainValueObject(string DomainValue1, string DomainValue2)
{
    public string DomainValue1 { get; }
    public string DomainValue2  { get; }
}
