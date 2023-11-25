using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger = logger;

    private static readonly string[] _summaries =
    [

    ];

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
        => Enumerable
        .Range(1, 7)
        .Select(i => new WeatherForecast(
            Date:         DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
            TemperatureC: Random.Shared.Next(-20, 55),
            Summary:      _summaries[Random.Shared.Next(_summaries.Length)]))
        .ToArray();
}

public enum TemperatureDescriptor
{
    Freezing   =  0,
    Bracing    =  5,
    Chilly     = 10,
    Cool       = 15,
    Mild       = 20,
    Warm       = 25,
    Balmy      = 30,
    Hot        = 35,
    Sweltering = 40,
    Scorching  = 45
}
