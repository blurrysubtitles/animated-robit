namespace WebApi.Extensions;

public static class DateTimeExtensions
{
    public static DateTime Today()
        => DateTime
        .Now
        .Date;

    public static DateOnly ToDateOnly(this DateTime dateTime)
        => DateOnly
        .FromDateTime(dateTime);
}