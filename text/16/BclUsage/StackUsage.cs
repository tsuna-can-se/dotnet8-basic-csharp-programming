namespace BclUsage;

public static class StackUsage
{
    public static void Run()
    {
        var stack = new Stack<int>(new[] { 1, 2, 3 });

        // Count
        Console.WriteLine(stack.Count); // output: 3

        // Push
        stack.Push(4);
        Console.WriteLine(stack.Count); // output: 4

        // Pop
        Console.WriteLine(stack.Pop()); // output: 4
        Console.WriteLine(stack.Count); // output: 3

        // Peek
        Console.WriteLine(stack.Peek()); // output: 3
        Console.WriteLine(stack.Count);  // output: 3

        // Clear
        stack.Clear();
        Console.WriteLine(stack.Count); // output: 0
    }
}
