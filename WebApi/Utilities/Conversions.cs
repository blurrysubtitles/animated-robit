namespace WebApi.Utilities;

public static class Conversions
{
    public static int CelsiusToFahrenheit(int degreesCelsius)
        => (int)
        (degreesCelsius / 0.5556) + 32;
}
