namespace TaskSample;

public class MultipleAwait1
{
    public async Task DoSomethingAsync()
    {
        Console.WriteLine($"Start:{DateTime.Now:HH:mm:ss.fff}");
        await DoTaskAsync(1); // 1
        await DoTaskAsync(2); // 2
        Console.WriteLine($"End:{DateTime.Now:HH:mm:ss.fff}");
    }

    private async Task DoTaskAsync(int number)
    {
        Console.WriteLine($"DoTaskAsync[{number}] Start:{DateTime.Now:HH:mm:ss.fff}");
        await Task.Delay(1000);
        Console.WriteLine($"DoTaskAsync[{number}] End:{DateTime.Now:HH:mm:ss.fff}");
    }
}
