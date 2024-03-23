namespace TaskSample;

internal class TaskT1
{
    public async Task DoSomethingAsync1()
    {
        Console.WriteLine($"Start:{DateTime.Now:HH:mm:ss.fff}");
        int waitTime = await this.WaitRandomAsync();
        Console.Out.WriteLine($"{waitTime} ミリ秒待ちました。");
        Console.WriteLine($"End:{DateTime.Now:HH:mm:ss.fff}");
    }

    public async Task DoSomethingAsync2()
    {
        Console.WriteLine($"Start:{DateTime.Now:HH:mm:ss.fff}");
        Task<int> waitRandomTask = this.WaitRandomAsync();
        int waitTime = await waitRandomTask;
        Console.Out.WriteLine($"{waitTime} ミリ秒待ちました。");
        Console.WriteLine($"End:{DateTime.Now:HH:mm:ss.fff}");
    }

    public void DoSomething()
    {
        Console.WriteLine($"Start:{DateTime.Now:HH:mm:ss.fff}");
        int waitTime = this.WaitRandom();
        Console.Out.WriteLine($"{waitTime} ミリ秒待ちました。");
        Console.WriteLine($"End:{DateTime.Now:HH:mm:ss.fff}");
    }

    private async Task<int> WaitRandomAsync()
    {
        int waitTime = Random.Shared.Next(2000);
        await Task.Delay(waitTime);
        return waitTime;
    }

    private int WaitRandom()
    {
        int waitTime = Random.Shared.Next(2000);
        Task.Delay(waitTime).Wait();
        return waitTime;
    }
}
