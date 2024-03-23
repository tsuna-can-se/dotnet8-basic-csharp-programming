//　配列の初期化
Console.WriteLine("配列の初期化");
int[] array = new int[] { 0, 1, 2 };

Console.WriteLine(array[0]); // output: 0
Console.WriteLine(array[1]); // output: 1
Console.WriteLine(array[2]); // output: 2

// リストの初期化
Console.WriteLine("リストの初期化");
List<string> list = new List<string> { "abc", "def", "ghi" };

Console.WriteLine(list[0]); // output: abc
Console.WriteLine(list[1]); // output: def
Console.WriteLine(list[2]); // output: ghi

// ディクショナリの初期化
Console.WriteLine("ディクショナリの初期化");
Dictionary<string, int> dictionary = new Dictionary<string, int>
{
    { "item-A", 25000 },
    { "item-B", 60000 }
};

Console.WriteLine("item-A:" + dictionary["item-A"]); // output: item-A:25000
Console.WriteLine("item-B:" + dictionary["item-B"]); // output: item-B:60000
