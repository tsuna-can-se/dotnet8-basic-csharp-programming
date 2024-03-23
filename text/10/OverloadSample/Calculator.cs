namespace OverloadSample;

public class Calculator
{
    public int Add(int x, int y)
    {
        Console.WriteLine("int型引数をとるAddメソッドが呼ばれました。");
        return x + y;
    }

    public long Add(long x, long y)
    {
        Console.WriteLine("long型引数をとるAddメソッドが呼ばれました。");
        return x + y;
    }

    public double Add(double x, double y)
    {
        Console.WriteLine("double型引数をとるAddメソッドが呼ばれました。");
        return x + y;
    }
}
