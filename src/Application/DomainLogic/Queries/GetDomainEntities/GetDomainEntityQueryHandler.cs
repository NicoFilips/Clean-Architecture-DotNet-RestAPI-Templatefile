using Application.Persistence;
using Domain.Domain;
using Domain.Domain.Exception;
using MediatR;

namespace Application.DomainLogic.Queries.GetDomainEntities;

internal sealed class GetDomainEntityQueryHandler : IRequestHandler<GetDomainEntityQuery, DomainModel>
{
    private readonly IDomainRepository _repository;

    public GetDomainEntityQueryHandler(IDomainRepository repository)
    {
        _repository = repository;
    }

    public async Task<DomainModel> Handle(GetDomainEntityQuery request, CancellationToken cancellationToken)
    {
        var domainModel = _repository.GetAsync(request.DomainName)
                                      ?? throw new DomainNotFoundException(request.DomainName);
        //todo adapter
        ArgumentNullException.ThrowIfNull(domainModel);
        return domainModel;
    }
}
