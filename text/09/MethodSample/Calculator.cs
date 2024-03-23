namespace MethodSample;

public class Calculator
{
    public void ShowAddResult(int value1, int value2)
    {
        int sum = value1 + value2;
        Console.WriteLine("和：" + sum);
    }

    public int Add(int value1, int value2)
    {
        return value1 + value2;
    }
}
