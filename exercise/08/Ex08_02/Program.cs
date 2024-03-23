Console.WriteLine("カテゴリの値を入力して下さい。");
var category = Console.ReadLine();

switch (category)
{
    case "1":
        Console.WriteLine("本です。");
        break;
    case "2":
        Console.WriteLine("おもちゃです。");
        break;
    case "3":
        Console.WriteLine("家電製品です。");
        break;
    default:
        Console.WriteLine("定義されていません。");
        break;
}
