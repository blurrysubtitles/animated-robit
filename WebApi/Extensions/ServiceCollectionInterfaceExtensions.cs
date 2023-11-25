using Swashbuckle.AspNetCore.SwaggerGen;

namespace WebApi.Extensions;

public static class ServiceCollectionInterfaceExtensions
{
    public static IServiceCollection AddSwaggerServices(this IServiceCollection services, Action<SwaggerGenOptions>? setupAction = null)
        => services
        .AddEndpointsApiExplorer()
        .AddSwaggerGen(setupAction);
}