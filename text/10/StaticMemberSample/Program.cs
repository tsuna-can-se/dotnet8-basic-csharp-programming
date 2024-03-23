using StaticMemberSample;

Console.WriteLine("==フィールド==");
StaticFieldSample s1 = new StaticFieldSample();
StaticFieldSample s2 = new StaticFieldSample();

s1.ShowSharedData(); // output: データ:0
s2.ShowSharedData(); // output: データ:0

s1.UpdateSharedData(10);

s1.ShowSharedData(); // output: データ:10
s2.ShowSharedData(); // output: データ:10

Console.WriteLine("==プロパティ==");
StaticPropertySample.SharedData = "Hoge";

StaticPropertySample s3 = new StaticPropertySample();
s3.ShowData(); // output: データ:Hoge

Console.WriteLine("==メソッド==");
var result = StaticMethodSample.Add(2, 3);
Console.WriteLine("合計:" + result); // output: 合計:5

Console.WriteLine("==クラス==");
StaticClassSample.ShowMessage("Fuga"); // output: Fuga
