using WebApi.Enums;
using WebApi.Extensions;
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

    public static WeatherForecast NewRandomWeatherForecast(DateOnly date)
    {
        TemperatureDescriptor temperatureDescriptor = RandomExtensions.RandomValue<TemperatureDescriptor>();
        return new WeatherForecast(date, (int)temperatureDescriptor, temperatureDescriptor.ToString());
    }
}
