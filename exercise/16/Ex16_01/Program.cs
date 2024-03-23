Console.WriteLine("誕生日を入力してください。");
var input = Console.ReadLine() ?? string.Empty;
DateTime birthday;
try
{
    birthday = DateTime.Parse(input);
}
catch (FormatException)
{
    Console.WriteLine("日付として識別てきません。");
    return;
}

if (birthday > DateTime.Today)
{
    Console.WriteLine("未来の日付は入力できません。");
    return;
}

var days = (DateTime.Today - birthday).Days;
Console.WriteLine($"誕生日から本日までの経過日数は、{days}日です。");
