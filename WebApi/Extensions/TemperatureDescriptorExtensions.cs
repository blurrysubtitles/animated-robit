namespace WebApi.Extensions;

public static class TemperatureDescriptorExtensions
{
    public static T? RandomElement<T>(this List<T?> anyList) => anyList.ElementAt(Random.Shared.Next(0, anyList.Count));
    public static TEnum RandomValue<TEnum>() where TEnum : struct, Enum => Enum.GetValues<TEnum>().ToList().RandomElement();
}
