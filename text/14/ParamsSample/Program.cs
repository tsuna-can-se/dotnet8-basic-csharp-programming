// 可変長引数単独
ShowValues(); // output: 
Console.WriteLine("----");
ShowValues(1); // output: 1
Console.WriteLine("----");
ShowValues(1, 2, 3); // output: 1,2,3
Console.WriteLine("----");
try
{
    ShowValues(null!); // null 参照エラーで例外
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.ToString());
}
Console.WriteLine("----");

// 固定引数+可変長引数
ShowValuesWithSeparator("|"); // output:
Console.WriteLine("----");
ShowValuesWithSeparator("|", 4, 5, 6); // output: 4|5|6
Console.WriteLine("----");

// 配列で渡す方法
int[] values = new int[] { 7, 8, 9 };
ShowValues(values); // output: 7,8,9
Console.WriteLine("----");

static void ShowValues(params int[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        if (i == 0)
        {
            Console.Write(values[i]);
        }
        else
        {
            Console.Write($",{values[i]}");
        }
    }

    Console.WriteLine();
}

static void ShowValuesWithSeparator(string separator, params int[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        if (i == 0)
        {
            Console.Write(values[i]);
        }
        else
        {
            Console.Write($"{separator}{values[i]}");
        }
    }

    Console.WriteLine();
}
