using WebApi.Extensions;

namespace WebApi.Models;

public record class WeatherForecast(
    DateOnly Date,
    int      TemperatureC,
    string?  Summary)
{
    public int TemperatureF
        => TemperatureConversions
        .CelsiusToFahrenheit(TemperatureC);
}
