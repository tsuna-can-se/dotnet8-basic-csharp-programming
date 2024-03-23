Console.WriteLine("1つ目の値を入力して下さい。");
var input1 = Console.ReadLine();
Console.WriteLine("2つ目の値を入力して下さい。");
var input2 = Console.ReadLine();

var val1 = Convert.ToInt32(input1);
var val2 = Convert.ToInt32(input2);

Console.WriteLine("和：");
Console.WriteLine(val1 + val2);
Console.WriteLine("積：");
Console.WriteLine(val1 * val2);
