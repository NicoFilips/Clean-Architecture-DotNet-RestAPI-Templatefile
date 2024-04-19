using Domain.Domain;
using Domain.Domain.ValueObjects;

namespace Application.Persistence;

public class DomainRepository : IDomainRepository
{
    public DomainModel GetAsync(string domainName) => new DomainModel(new DomainId(), new DomainValueObject(string.Empty, string.Empty));
}
