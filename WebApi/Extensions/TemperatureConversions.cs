namespace WebApi.Extensions;

public static class TemperatureConversions
{
    public static int CelsiusToFahrenheit(int degreesCelsius)
        => (int)
        (degreesCelsius / 0.5556) + 32;
}
