int rand = Random.Shared.Next(-1, 2); // -1～1の整数の乱数を生成します。
Console.WriteLine("生成した乱数は" + rand + "です。");

switch (rand)
{
    case > 0:
        Console.WriteLine("正の数です。");
        break;
    case < 0:
        Console.WriteLine("負の数です。");
        break;
    default:
        Console.WriteLine("0です。");
        break;
}

string color = "red";

switch (color)
{
    case "red":
        Console.WriteLine("赤です。");
        break;
    case "blue":
        Console.WriteLine("青です。");
        break;
    default:
        Console.WriteLine("不明な色です。");
        break;
}

double rate = 10.5d;

switch (rate)
{
    case < 0.0d:
    case > 10.0d:
        Console.WriteLine("レートは0～10の間に設定してください。");
        break;
    default:
        Console.WriteLine("レートは" + rate + "です。");
        break;
}
