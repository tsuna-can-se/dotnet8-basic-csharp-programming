namespace BclUsage;

public static class QueueUsage
{
    public static void Run()
    {
        var queue = new Queue<int>(new[] { 1, 2, 3 });

        // Count
        Console.WriteLine(queue.Count); // output: 3

        // Enqueue
        queue.Enqueue(4);
        Console.WriteLine(queue.Count); // output: 4

        // Dequeue
        Console.WriteLine(queue.Dequeue()); // output: 1
        Console.WriteLine(queue.Count);     // output: 3

        // Peek
        Console.WriteLine(queue.Peek()); // output: 2
        Console.WriteLine(queue.Count); // output: 3

        // Clear
        queue.Clear();
        Console.WriteLine(queue.Count); // output: 0
    }
}
