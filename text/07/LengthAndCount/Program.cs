// 配列
string[] messages = new string[2];
Console.WriteLine(messages.Length); // output: 2

// リスト
List<string> fruitList = new List<string>();
Console.WriteLine(fruitList.Count); // output: 0

fruitList.Add("りんご");
Console.WriteLine(fruitList.Count); // output: 1

fruitList.Add("ぶどう");
Console.WriteLine(fruitList.Count); // output: 2

// ディクショナリ
Dictionary<string, decimal> score = new Dictionary<string, decimal>();
Console.WriteLine(score.Count); // output: 0

score.Add("英語", 80m);
Console.WriteLine(score.Count); // output: 1

score.Add("国語", 75m);
Console.WriteLine(score.Count); // output: 2
