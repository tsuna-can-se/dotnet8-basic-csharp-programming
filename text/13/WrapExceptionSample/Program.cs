Console.WriteLine("数値を入力してください。");
string arg = Console.ReadLine() ?? string.Empty;
int value = ParseToInt(arg);
Console.WriteLine("数値:" + value);

static int ParseToInt(string value)
{
    try
    {
        return int.Parse(value);
    }
    catch (FormatException ex)
    {
        throw new ArgumentException(value + "は数値ではありません。", ex);
    }
}
