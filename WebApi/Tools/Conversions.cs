using WebApi.Extensions;

namespace WebApi.Tools;

public static class Conversions
{
    public static int CelsiusToFahrenheit(int degreesCelsius)
        => (int)
        (degreesCelsius / 0.5556) + 32;
}

public static class Enums
{
    public static TEnum Random<TEnum>() where TEnum : struct, Enum
        => Enum
        .GetValues<TEnum>()
        .ToList()
        .RandomElement();
}
