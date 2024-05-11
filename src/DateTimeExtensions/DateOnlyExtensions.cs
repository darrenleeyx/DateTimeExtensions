namespace DateTimeExtensions;

public static class DateOnlyExtensions
{
    public static DateTime ToDateTime(this DateOnly date)
    {
        return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, DateTimeKind.Unspecified);
    }

    public static DateTime? ToNullableDateTime(this DateOnly? nullableDate)
    {
        if (nullableDate.HasValue is false)
        {
            return null;
        }

        var date = nullableDate.Value;

        return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, DateTimeKind.Unspecified);
    }
}