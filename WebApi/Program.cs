using WebApi.Extensions;
using WebApi.Models;

namespace WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        WebApplication app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.MapGet("/WeatherForecast/", ()
            => Enumerable
            .Range(1, 7)
            .Select(i => WeatherForecast.InDays(i))
            .ToList());

        app.Run();
    }
}
