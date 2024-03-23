Console.WriteLine("文字列を入力してください。");

string arg = ConsoleRead();
Console.WriteLine("入力値:" + arg);

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
