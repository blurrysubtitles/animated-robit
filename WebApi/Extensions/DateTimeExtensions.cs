namespace WebApi.Extensions;

public static class DateTimeExtensions
{
    public static DateOnly ToDateOnly(this DateTime dateTime)
        => DateOnly
        .FromDateTime(dateTime);
}