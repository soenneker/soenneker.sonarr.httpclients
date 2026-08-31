using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Sonarr.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Sonarr.HttpClients.Registrars;

/// <summary>
/// Registers the authenticated Sonarr HTTP client provider.
/// </summary>
public static class SonarrOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds the Sonarr HTTP client provider as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddSonarrOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ISonarrOpenApiHttpClient, SonarrOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds the Sonarr HTTP client provider as a scoped service. Each scope owns a separate cached HTTP client. <para/>
    /// </summary>
    public static IServiceCollection AddSonarrOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ISonarrOpenApiHttpClient, SonarrOpenApiHttpClient>();

        return services;
    }
}
