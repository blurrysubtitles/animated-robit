namespace WebApi;

public record class WeatherForecast(
    DateOnly Date,
    int      TemperatureC,
    string?  Summary)
{
    public int TemperatureF => (int)(TemperatureC / 0.5556) + 32;
}
