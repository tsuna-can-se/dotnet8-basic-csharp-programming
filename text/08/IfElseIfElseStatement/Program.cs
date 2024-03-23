int rand = Random.Shared.Next(-1, 2); // -1～1の整数の乱数を生成します。
Console.WriteLine("生成した乱数は" + rand + "です。");

if (rand > 0)
{
    Console.WriteLine("正の数です。");
}
else if (rand < 0)
{
    Console.WriteLine("負の数です。");
}
else
{
    Console.WriteLine("0です。");
}
