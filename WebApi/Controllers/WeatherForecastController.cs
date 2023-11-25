using Microsoft.AspNetCore.Mvc;
using WebApi.Extensions;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger = logger;

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
        => Enumerable
        .Range(1, 7)
        .Select(i => WeatherForecast.NewRandomWeatherForecast(DateTime.Now.AddDays(i).ToDateOnly()))
        .ToArray();
}
