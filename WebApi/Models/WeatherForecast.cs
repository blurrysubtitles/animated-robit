using WebApi.Utilities;

namespace WebApi.Models;

public record class WeatherForecast(
    DateOnly Date,
    int      TemperatureC,
    string?  Summary)
{
    public int TemperatureF
        => Conversions
        .CelsiusToFahrenheit(TemperatureC);
}
