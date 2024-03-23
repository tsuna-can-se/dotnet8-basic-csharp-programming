namespace PolymorphismSample;

public class FlatTextConsoleLogger : ConsoleLoggerBase
{
    protected override string Format(DateTime date, string message)
    {
        return date.ToString("yyyy/MM/dd HH:mm:ss") + " " + message;
    }
}
