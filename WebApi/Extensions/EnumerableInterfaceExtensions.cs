namespace WebApi.Extensions;

public static class EnumerableInterfaceExtensions
{
    public static int RandomIndex<T>(this IEnumerable<T?> enumerable)
        => Random
        .Shared
        .Next(0, enumerable.Count());

    public static T? RandomElement<T>(this IEnumerable<T?> enumerable)
        => enumerable
        .ElementAt(enumerable.RandomIndex());
}
