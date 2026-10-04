using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Threads.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Threads.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class ThreadsOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="ThreadsOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddThreadsOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IThreadsOpenApiHttpClient, ThreadsOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="ThreadsOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddThreadsOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IThreadsOpenApiHttpClient, ThreadsOpenApiHttpClient>();

        return services;
    }
}
