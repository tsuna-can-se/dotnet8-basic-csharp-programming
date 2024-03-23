string result = "表";
bool? isHead = result switch
{
    "表" => true,
    "裏" => false,
    _ => null,
};

Console.WriteLine(isHead); // output: True
Console.WriteLine("=========================");

int rand = Random.Shared.Next(1, 10);
string message = rand switch
{
    < 3 => "小さい",
    > 7 => "大きい",
    _ => "普通"
};

Console.WriteLine($"{rand}: {message}");
