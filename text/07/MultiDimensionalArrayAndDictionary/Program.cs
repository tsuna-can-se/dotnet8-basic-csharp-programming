// 多次元配列（このサンプルは 2 次元配列）
Console.WriteLine("多次元配列");

int[,] matrix = new int[2, 3];
matrix[0, 0] = 0;
matrix[0, 1] = 1;
matrix[0, 2] = 2;
matrix[1, 0] = 3;
matrix[1, 1] = 4;
matrix[1, 2] = 5;

Console.WriteLine("|" + matrix[0, 0] + " " + matrix[0, 1] + " " + matrix[0, 2] + "|"); // output: |0 1 2|
Console.WriteLine("|" + matrix[1, 0] + " " + matrix[1, 1] + " " + matrix[1, 2] + "|"); // output: |3 4 5|

// ディクショナリ
Console.WriteLine("ディクショナリ");

Dictionary<string, decimal> score = new Dictionary<string, decimal>();
score.Add("英語", 80m);
score.Add("国語", 75m);
score["数学"] = 90m; // 添え字の要素が存在しない場合は追加
score["国語"] = 85m; // 添え字の要素が存在する場合は上書き

Console.WriteLine("英語:" + score["英語"] + "点"); // output: 英語:80点
Console.WriteLine("国語:" + score["国語"] + "点"); // output: 国語:85点
Console.WriteLine("数学:" + score["数学"] + "点"); // output: 数学:90点
