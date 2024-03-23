namespace BclUsage;

public static class MathUsage
{
    public static void Run()
    {
        // E
        Console.WriteLine(Math.E); // output: 2.718281828459045

        // PI
        Console.WriteLine(Math.PI); // output: 3.141592653589793

        // Abs
        Console.WriteLine(Math.Abs(2));  // output: 2
        Console.WriteLine(Math.Abs(-1)); // output: 1

        // Exp
        Console.WriteLine(Math.Exp(1)); // output: 2.718281828459045

        // Log
        Console.WriteLine(Math.Log(8, 2)); // output: 3

        // Max
        Console.WriteLine(Math.Max(1, 2)); // output: 2

        // Min
        Console.WriteLine(Math.Min(1, 2)); // output: 1

        // Pow
        Console.WriteLine(Math.Pow(2, 3)); // output: 8

        // Round
        Console.WriteLine(Math.Round(2.5m)); // output: 2
        Console.WriteLine(Math.Round(2.4m)); // output: 2
        Console.WriteLine(Math.Round(2.5m, MidpointRounding.AwayFromZero)); // output: 3
        Console.WriteLine(Math.Round(2.4m, MidpointRounding.AwayFromZero)); // output: 2
        Console.WriteLine(Math.Round(2.5m, MidpointRounding.ToEven)); // output: 2
        Console.WriteLine(Math.Round(2.4m, MidpointRounding.ToEven)); // output: 2
    }
}
