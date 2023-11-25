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

    public static WeatherForecast Create(DateOnly date)
    {
        TemperatureDescriptor temperatureDescriptor = RandomExtensions.RandomValue<TemperatureDescriptor>();
        return new WeatherForecast(date, (int)temperatureDescriptor, temperatureDescriptor.ToString());
    }

    public static WeatherForecast OnDay(DateOnly date)
        => Create(date);

    public static WeatherForecast InDays(int daysFromToday)
        => OnDay(DateOnlyExtensions.TodayPlus(daysFromToday));

    public static WeatherForecast Today()
        => InDays(0);

    public static WeatherForecast Tomorrow()
        => InDays(1);

    public WeatherForecast Next
        => Create(Date.AddDays(1));
}
