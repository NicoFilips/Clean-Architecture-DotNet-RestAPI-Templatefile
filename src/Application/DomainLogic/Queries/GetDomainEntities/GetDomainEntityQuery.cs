using Domain.Domain;
using MediatR;

namespace Application.DomainLogic.Queries.GetDomainEntities;

public record GetDomainEntityQuery(string DomainName) : IRequest<DomainModel>;

