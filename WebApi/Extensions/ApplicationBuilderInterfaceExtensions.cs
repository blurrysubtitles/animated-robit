using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace WebApi.Extensions;

public static class ApplicationBuilderInterfaceExtensions
{
    public static IApplicationBuilder UseSwaggerWithUI(this IApplicationBuilder applicationBuilder, SwaggerOptions swaggerOptions, SwaggerUIOptions swaggerUIOptions)
        => applicationBuilder
        .UseSwagger(swaggerOptions)
        .UseSwaggerUI(swaggerUIOptions);

    public static IApplicationBuilder UseSwaggerWithUI(this IApplicationBuilder applicationBuilder, Action<SwaggerOptions>? swaggerSetupAction = null, SwaggerUIOptions? swaggerUIAction = null)
        => applicationBuilder
        .UseSwagger(swaggerSetupAction)
        .UseSwaggerUI(swaggerUIAction);
}