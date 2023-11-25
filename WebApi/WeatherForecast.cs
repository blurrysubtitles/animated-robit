namespace WebApi;

public record class WeatherForecast(
    DateOnly Date,
    int      TemperatureC,
    string?  Summary)
{
    public int TemperatureF => TemperatureConversions.CelsiusToFahrenheit(TemperatureC);
}

public static class TemperatureConversions
{
    public static int CelsiusToFahrenheit(int degreesCelsius) => (int)(degreesCelsius / 0.5556) + 32;
}
