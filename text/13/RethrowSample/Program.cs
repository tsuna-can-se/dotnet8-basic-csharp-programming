Console.WriteLine("数値を入力してください。");

string arg = Console.ReadLine() ?? string.Empty;
int value;

try
{
    value = int.Parse(arg);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("int型に変換できない値[" + arg + "]が指定されました。");
    Console.WriteLine("==========");
    throw;
}

Console.WriteLine("入力値:" + value);
