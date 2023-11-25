namespace WebApi.Extensions;

public static class DateOnlyExtensions
{
    public static DateOnly Today()
        => DateTime
        .Now
        .ToDateOnly();

    public static DateOnly TodayPlus(int days = 0, int months = 0, int years = 0)
        => Today()
        .AddDays(days)
        .AddMonths(months)
        .AddYears(years);
}