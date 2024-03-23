using System.Text;

namespace BclUsage;

public static class StringBuilderUsage
{
    public static void Run()
    {
        StringBuilder empty = new StringBuilder();
        Console.WriteLine(empty); // output:

        StringBuilder sb = new StringBuilder("Hello");
        Console.WriteLine(sb); // output: Hello

        // Length
        Console.WriteLine(sb.Length); // output: 5

        // Append
        Console.WriteLine(sb.Append(" World!"));　// output: Hello World!

        // AppendJoin
        object[] list = new object[] { "abc", 123, new DateTime(2023, 7, 6) };
        Console.WriteLine(empty.AppendJoin(",", list)); // output: abc,123,2023/07/06 0:00:00

        // AppendLine()
        Console.WriteLine(sb.AppendLine()); // output: Hello World!
                                            //         (空行)

        // AppendLine(string)
        Console.WriteLine(sb.AppendLine("Good morning!")); // output: Hello World!
                                                           //         Good morning!
                                                           //         (空行)

        // Clear
        Console.WriteLine(sb.Clear()); // output: (空行)

        // Insert
        Console.WriteLine(empty.Insert(7, "456")); // output: abc,123456,2023/07/06 0:00:00

        // Remove
        Console.WriteLine(empty.Remove(4, 3)); // output: abc,456,2023/07/06 0:00:00

        // Replace
        Console.WriteLine(empty.Replace("456","789"));  // output: abc,789,2023/07/06 0:00:00

        // ToString
        Console.WriteLine(empty.ToString()); // output: abc,789,2023/07/06 0:00:00
    }
}
