Console.WriteLine("===式形式のラムダ===");

Func<int, int, int> addFunction = (x, y) => x + y;

Console.WriteLine("===ステートメント形式のラムダ===");
Func<int, int, int> subtractFunction = (x, y) =>
{
    return x - y;
};

Console.WriteLine(addFunction(1, 3));      // output: 4
Console.WriteLine(subtractFunction(1, 3)); // output: -2

Console.WriteLine("===入力パラメーターのバリエーション===");

Action blank = () => Console.WriteLine();
blank();

Func<int, int> square = x => x * x;
Console.WriteLine(square(5));

var isTooBig = (int x, int y) => x > y;
Console.WriteLine(isTooBig(5, 3));

Func<int, int, int> getTestData = (_, _) => 0;
Console.WriteLine(getTestData(10, 20));

Console.WriteLine("===明示的な戻り値の型===");
var getLength = dynamic (string? str) => string.IsNullOrEmpty(str) ? "Empty" : str.Length;
Console.WriteLine(getLength(null));
Console.WriteLine(getLength("Hoge"));
