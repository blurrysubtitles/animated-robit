using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

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
        .Select(i => WeatherForecast.NewRandomWeatherForecast(DateOnly.FromDateTime(DateTime.Now.AddDays(i))))
        .ToArray();
}
