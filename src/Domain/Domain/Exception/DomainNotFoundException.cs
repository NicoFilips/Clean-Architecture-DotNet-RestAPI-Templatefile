namespace Domain.Domain.Exception;

public class DomainNotFoundException : KeyNotFoundException
{
        public DomainNotFoundException(string domainName)
            : base($"'{domainName}' not found")
        {}
}
