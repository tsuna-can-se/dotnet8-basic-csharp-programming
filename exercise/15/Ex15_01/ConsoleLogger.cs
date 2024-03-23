namespace Ex15_01;

public static class ConsoleLogger
{
    public static void WriteLog(string message, Func<string, string> formatter)
    {
        var logMessage = formatter(message);
        Console.WriteLine(logMessage);
    }
}
