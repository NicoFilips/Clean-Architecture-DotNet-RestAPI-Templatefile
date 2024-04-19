using Domain.Domain;

namespace Application.Persistence;

public interface IDomainRepository
{
    public DomainModel GetAsync(string domainName);
}
