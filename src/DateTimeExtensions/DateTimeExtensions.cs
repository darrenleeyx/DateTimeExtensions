namespace DateTimeExtensions;

public static class DateTimeExtensions
{
    public static DateOnly? ToNullableDateOnly(this DateTime? nullableDateTime)
    {
        if (nullableDateTime.HasValue is false)
        {
            return null;
        }

        var dateTime = nullableDateTime.Value;

        return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
    }

    public static DateOnly ToDateOnly(this DateTime dateTime)
    {
        return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
    }
}
