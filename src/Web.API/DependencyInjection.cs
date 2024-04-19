using Carter;
using Microsoft.Extensions.DependencyInjection;
using Web.API.Mapping;

namespace Web.API;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
        => services
          .AddCarter()
          .AddMappings();
}
