internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine($"Start:{DateTime.Now:HH:mm:ss.fff}");
        await Task.Delay(1000);
        Console.WriteLine($"End:{DateTime.Now:HH:mm:ss.fff}");
    }
}
