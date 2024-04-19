using TypedRest.Endpoints;
using TypedRest.Endpoints.Generic;
using Web.API.Contracts.DTOs;


namespace Web.API.Client;

public class DomainEndpoint : ElementEndpoint<DomainDto>
{
    public DomainEndpoint(IEndpoint referrer)
        : base(referrer, relativeUri: "domain")
    {}
}
