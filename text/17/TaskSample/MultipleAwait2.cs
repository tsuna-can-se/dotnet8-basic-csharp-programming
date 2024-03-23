namespace TaskSample;

public class MultipleAwait2
{
    public async Task DoSomethingAsync()
    {
        Console.WriteLine($"Start:{DateTime.Now:HH:mm:ss.fff}");
        Task task1 = DoTaskAsync(1); // 1
        Task task2 = DoTaskAsync(2); // 2
        await task1;
        await task2;
        Console.WriteLine($"End:{DateTime.Now:HH:mm:ss.fff}");
    }

    private async Task DoTaskAsync(int number)
    {
        Console.WriteLine($"DoTaskAsync[{number}] Start:{DateTime.Now:HH:mm:ss.fff}");
        await Task.Delay(1000);
        Console.WriteLine($"DoTaskAsync[{number}] End:{DateTime.Now:HH:mm:ss.fff}");
    }
}
