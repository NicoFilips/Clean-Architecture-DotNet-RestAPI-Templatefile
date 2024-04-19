﻿using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
        => serviceCollection
            .AddMediatR(config => config.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly));
}