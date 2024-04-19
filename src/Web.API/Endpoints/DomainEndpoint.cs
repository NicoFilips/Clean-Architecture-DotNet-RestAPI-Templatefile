using Application.DomainLogic.Queries.GetDomainEntities;
using Carter;
using Domain.Domain;
using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Web.API.Contracts.DTOs;

namespace Web.API.Endpoints;

public class DomainEndpoint : EndpointBase, ICarterModule
{
    public override void AddRoutes(IEndpointRouteBuilder app) => app.MapGet("/domain-entity/{domainName}", async (string domainName, IMapper mapper, ISender sender) =>
    {
        var query = new GetDomainEntityQuery(domainName);
        ErrorOr<DomainModel> domainModel = await sender.Send(query);
        return domainModel.IsError
            ? Problem(domainModel.Errors)
            : Results.Ok(mapper.Map<DomainDto>(domainModel));
    });
}
