Console.WriteLine("任意の年を入力して下さい。");
var input = Console.ReadLine();
var year = Convert.ToInt32(input);

if (year % 4 == 0 && year % 100 != 0)
{
    Console.WriteLine(year + "年はうるう年です。");
}
else if (year % 400 == 0)
{
    Console.WriteLine(year + "年はうるう年です。");
}
else
{
    Console.WriteLine(year + "年は平年です。");
}
