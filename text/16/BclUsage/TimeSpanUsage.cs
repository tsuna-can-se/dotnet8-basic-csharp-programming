namespace BclUsage;

public static class TimeSpanUsage
{
    public static void Run()
    {
        TimeSpan timeSpan = new TimeSpan(1, 2, 3, 4, 5);

        // Zero
        Console.WriteLine(TimeSpan.Zero); // output: 00:00:00

        // TotalDays
        Console.WriteLine(timeSpan.TotalDays); // output: 1.0854630208333333

        // TotalHours
        Console.WriteLine(timeSpan.TotalHours); // output: 26.0511125

        // TotalMinutes
        Console.WriteLine(timeSpan.TotalMinutes); // output: 1563.06675

        // TotalSeconds
        Console.WriteLine(timeSpan.TotalSeconds); // output: 93784.005

        // TotalMilliseconds
        Console.WriteLine(timeSpan.TotalMilliseconds); // output: 93784005

        // Add
        Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(10))); // output: 1.02:13:04.0050000

        // FromDays
        Console.WriteLine(TimeSpan.FromDays(1)); // output: 1.00:00:00

        // FromHours
        Console.WriteLine(TimeSpan.FromHours(1)); // output: 01:00:00

        // FromMinutes
        Console.WriteLine(TimeSpan.FromMinutes(1)); // output: 00:01:00

        // FromSeconds
        Console.WriteLine(TimeSpan.FromSeconds(1)); // output: 00:00:01

        // FromMilliseconds
        Console.WriteLine(TimeSpan.FromMilliseconds(1)); // output: 00:00:00.0010000

        // Parse
        Console.WriteLine(TimeSpan.Parse("1.02:03:04.005")); // output: 1.02:03:04.0050000

        // ToString
        Console.WriteLine(timeSpan.ToString("%d\\日h\\時\\間m\\分s\\秒")); // output: 1日2時間3分4秒
    }
}
