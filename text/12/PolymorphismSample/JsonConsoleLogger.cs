namespace PolymorphismSample;

public class JsonConsoleLogger : ConsoleLoggerBase
{
    protected override string Format(DateTime date, string message)
    {
        return "{ \"date\": \"" + date.ToString("yyyy/MM/dd HH:mm:ss") + "\", \"message\": \"" + message + "\" }";
    }
}
