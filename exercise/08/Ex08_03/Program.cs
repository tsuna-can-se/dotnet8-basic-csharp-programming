Console.WriteLine("1からの総和を求める数値を入力して下さい。");
var input = Console.ReadLine();
var n = Convert.ToInt32(input);
int value = 0;

for (int i = 1; i <= n; i++)
{
    value += i;
}

Console.WriteLine("1から" + n + "の総和は" + value + "です。");
