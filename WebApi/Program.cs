using WebApi.Extensions;
using WebApi.Models;

namespace WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddSwaggerServices();

        WebApplication app = builder.Build();

        app.UseSwaggerWithUI();
        app.UseHttpsRedirection();

        app.MapGet("/WeatherForecast/", () => WeatherForecast.ThisWeek());

        app.Run();
    }
}
