for (int i = 0; i < 5; i++)
{
    try
    {
        Console.WriteLine("数値を入力してください。");
        var num = int.Parse(Console.ReadLine() ?? string.Empty);
        DoSomething(num);
        break;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("入力可能な値は1～9の整数だけです。");
        Console.WriteLine(ex.ToString());
        Console.WriteLine("===========");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.WriteLine("===========");
    }
}

static void DoSomething(int num)
{
    if (num <= 0 || num > 10)
    {
        throw new ArgumentOutOfRangeException();
    }

    switch (num)
    {
        case 1:
            throw new InvalidOperationException();
        case 2:
            throw new ApplicationException();
        default:
            Console.WriteLine("正常終了");
            Console.WriteLine("入力値:" + num);
            break;
    }
}
