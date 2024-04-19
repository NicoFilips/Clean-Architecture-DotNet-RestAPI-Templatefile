using ErrorOr;

namespace Application.DomainLogic.Errors;

public static class DomainErrors
{
    public static Error DomainNotFoundError(string domainName)
        => Error.NotFound("DOMAIN_ENTITY_NOT_FOUND", $"Domain entity '{domainName}' not found");
}
