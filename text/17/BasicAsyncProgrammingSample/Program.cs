Console.WriteLine($"Start:{DateTime.Now:HH:mm:ss.fff}");
var task1 = Task1Async();
var task2 = Task2Async();
var task3 = Task3Async();
await Task.WhenAll(task1, task2, task3);
Console.WriteLine($"End:{DateTime.Now:HH:mm:ss.fff}");

async Task Task1Async()
{
    await Task.Delay(1000);
    Console.WriteLine("1");
}

async Task Task2Async()
{
    await Task.Delay(1000);
    Console.WriteLine("2");
}

async Task Task3Async()
{
    await Task.Delay(1000);
    Console.WriteLine("3");
}
