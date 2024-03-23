int rand = Random.Shared.Next(1, 10); // 1～9の整数の乱数を生成します。
Console.WriteLine("生成した乱数は" + rand + "です。");

if (rand % 2 == 0) // 2の剰余が0かどうか
{
    Console.WriteLine("乱数は偶数です。");
}
else
{
    Console.WriteLine("乱数は奇数です。");
}
