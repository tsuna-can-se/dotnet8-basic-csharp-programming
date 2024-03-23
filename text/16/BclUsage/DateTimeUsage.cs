namespace BclUsage;

public static class DateTimeUsage
{
    public static void Run()
    {
        DateTime dateTime = new DateTime(2023, 9, 26, 15, 30, 45);
        DateTimeOffset dateTimeOffset = new DateTimeOffset(2024, 1, 2, 17, 20, 50, TimeSpan.FromHours(9));

        // Now
        Console.WriteLine(DateTime.Now);       // output: 2023/09/26 15:00:00
        Console.WriteLine(DateTimeOffset.Now); // output: 2023/09/26 15:00:00 +09:00

        // UtcNow
        Console.WriteLine(DateTime.UtcNow);       // output: 2023/09/26 06:00:00
        Console.WriteLine(DateTimeOffset.UtcNow); // output: 2023/09/26 06:00:00 +00:00

        // Year
        Console.WriteLine(dateTime.Year);       // output: 2023
        Console.WriteLine(dateTimeOffset.Year); // output: 2024

        // Month
        Console.WriteLine(dateTime.Month);       // output: 9
        Console.WriteLine(dateTimeOffset.Month); // output: 1

        // Day
        Console.WriteLine(dateTime.Day);       // output: 26
        Console.WriteLine(dateTimeOffset.Day); // output: 2

        // Hour
        Console.WriteLine(dateTime.Hour);       // output: 15
        Console.WriteLine(dateTimeOffset.Hour); // output: 17

        // Minute
        Console.WriteLine(dateTime.Minute);       // output: 30
        Console.WriteLine(dateTimeOffset.Minute); // output: 20

        // Second
        Console.WriteLine(dateTime.Second);       // output: 45
        Console.WriteLine(dateTimeOffset.Second); // output: 50

        // Offset
        Console.WriteLine(dateTimeOffset.Offset); // output: 09:00:00

        // Add
        Console.WriteLine(dateTime.Add(TimeSpan.FromDays(1)));       // output: 2023/09/27 15:30:45
        Console.WriteLine(dateTimeOffset.Add(TimeSpan.FromDays(1))); // output: 2024/01/03 17:20:50 +09:00

        // AddYears
        Console.WriteLine(dateTime.AddYears(1));       // output: 2024/09/26 15:30:45
        Console.WriteLine(dateTimeOffset.AddYears(1)); // output: 2025/01/02 17:20:50 +09:00

        // AddMonths
        Console.WriteLine(dateTime.AddMonths(1));       // output: 2023/10/26 15:30:45
        Console.WriteLine(dateTimeOffset.AddMonths(1)); // output: 2024/02/02 17:20:50 +09:00

        // AddDays
        Console.WriteLine(dateTime.AddDays(1));       // output: 2023/09/27 15:30:45
        Console.WriteLine(dateTimeOffset.AddDays(1)); // output: 2024/01/03 17:20:50 +09:00

        // AddHours
        Console.WriteLine(dateTime.AddHours(1));       // output: 2023/09/26 16:30:45
        Console.WriteLine(dateTimeOffset.AddHours(1)); // output: 2024/01/02 18:20:50 +09:00

        // AddMinutes
        Console.WriteLine(dateTime.AddMinutes(1));       // output: 2023/09/26 15:31:45
        Console.WriteLine(dateTimeOffset.AddMinutes(1)); // output: 2024/01/02 17:21:50 +09:00

        // AddSeconds
        Console.WriteLine(dateTime.AddSeconds(1));       // output: 2023/09/26 15:30:46
        Console.WriteLine(dateTimeOffset.AddSeconds(1)); // output: 2024/01/02 17:20:51 +09:00

        // Parse
        Console.WriteLine(DateTime.Parse("2023/11/05 12:13:10"));       // output: 2023/11/05 12:13:10
        Console.WriteLine(DateTimeOffset.Parse("2024/04/06 21:33:42")); // output: 2024/04/06 21:33:42 +09:00

        // ToString
        Console.WriteLine(dateTime.ToString("yyyy/MM/dd HH:mm:ss"));       // output: 2023/09/26 15:30:45
        Console.WriteLine(dateTimeOffset.ToString("yyyy-MM-dd HH:mm:ss zzz")); // output: 2024-01-02 17:20:50 +09:00
    }
}
