namespace PolymorphismSample;

public abstract class ConsoleLoggerBase
{
    protected abstract string Format(DateTime date, string message);

    public void WriteLog(string message)
    {
        string logMessage = this.Format(DateTime.Now, message);
        Console.WriteLine(logMessage);
    }
}
