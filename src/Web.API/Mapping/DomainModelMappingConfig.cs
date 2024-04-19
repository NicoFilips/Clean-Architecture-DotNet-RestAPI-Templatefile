using Domain.Domain;
using Mapster;
using Web.API.Contracts.DTOs;

namespace Web.API.Mapping;

public class DomainModelMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config) => config.NewConfig<DomainModel, DomainDto>()
                                                            .Map(dest => dest.DtoId, src => src.Id.Id)
                                                            .Map(dest => dest.DtoValueObject1, src => src.ValueObject.DomainValue1)
                                                            .Map(dest => dest.DtoValueObject2, src => src.ValueObject.DomainValue2);
}
