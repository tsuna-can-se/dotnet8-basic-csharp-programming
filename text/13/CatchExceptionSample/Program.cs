Console.WriteLine("文字列を入力してください。");

try
{
    string arg = ConsoleRead();
    Console.WriteLine("入力値:" + arg);
}
catch (ArgumentException ex)
{
    Console.WriteLine("ArgumentExceptionが発生しました。");
    Console.WriteLine(ex.ToString());
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