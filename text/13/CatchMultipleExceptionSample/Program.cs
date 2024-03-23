Console.WriteLine("数値を入力してください。");

try
{
    string arg = ConsoleRead();
    int value = int.Parse(arg);
    Console.WriteLine("入力値:" + value);
}
catch (ArgumentException ex)
{
    Console.WriteLine("ArgumentExceptionが発生しました。");
    Console.WriteLine(ex.ToString());
}
catch (FormatException ex)
{
    Console.WriteLine("FormatExceptionが発生しました。");
    Console.WriteLine(ex.ToString());
}
catch
{
    Console.WriteLine("異常が発生しました。");
}

Console.WriteLine("処理を終了しました。");

static string ConsoleRead()
{
    string? arg = Console.ReadLine();
    if (string.IsNullOrEmpty(arg))
    {
        string message = "空の文字列は入力できません。";
        throw new ArgumentException(message);
    }

    return arg;
}
