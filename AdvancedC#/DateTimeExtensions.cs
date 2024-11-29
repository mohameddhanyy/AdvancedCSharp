namespace AdvancedC_;

public static class DateTimeExtensions
{
    public static bool IsWeekend(this DateTime dateTime) => dateTime.DayOfWeek == DayOfWeek.Friday || dateTime.DayOfWeek == DayOfWeek.Saturday;

    public static bool IsWeekday(this DateTime dateTime) => !IsWeekend(dateTime);
    
}