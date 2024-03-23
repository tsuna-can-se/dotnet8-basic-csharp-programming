List<int> items = new List<int>();

items.Add(1);
items.Add(2);
items.Add(3);

items[0] = 4;

Console.WriteLine(items[0]); // output: 4
Console.WriteLine(items[1]); // output: 2
Console.WriteLine(items[2]); // output: 3
