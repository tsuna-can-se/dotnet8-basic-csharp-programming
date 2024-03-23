Console.WriteLine("===単純な例===");
int value = 100;
Console.WriteLine($"valueの値は{value}です。"); // output: valueの値は100です。


Console.WriteLine("===文字列連結方式の比較===");
string name = "太郎";
int age = 22;

Console.WriteLine(name + "は" + age + "歳です。"); // + 演算子を使った連結
Console.WriteLine("{0}は{1}歳です。", name, age);  // 複合書式指定を使った連結
Console.WriteLine($"{name}は{age}歳です。");       // 文字列補間を使った連結

Console.WriteLine("===アライメント（位置合わせ）===");
List<Person> people = new List<Person>()
{
    new Person("taro", 32, 172.5),
    new Person("aoi", 15, 158.9),
    new Person("kanako", 4, 95.2),
};
foreach (var person in people)
{
    Console.WriteLine($"|{person.Name,-8}|{person.Age,3}歳|{person.Height,6}cm|");
}

Console.WriteLine("===フォーマット===");
double data = 6.48;
Console.WriteLine($"data:{data:F1}"); // output: data:6.5

DateTime now = new DateTime(2023, 7, 10);
Console.WriteLine($"日時:{now:yyyy/MM/dd}"); // output: 日時:2023/07/10

public record Person(string Name, int Age, double Height);
