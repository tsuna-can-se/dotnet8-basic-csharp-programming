using OverloadSample;

Calculator calculator = new Calculator();
var result1 = calculator.Add((int)10, (int)20);
Console.WriteLine("10+20=" + result1);
var result2 = calculator.Add((long)30, (long)40);
Console.WriteLine("30+40=" + result2);
var result3 = calculator.Add((double)1.5, (double)2.3);
Console.WriteLine("1.5+2.3=" + result3);

Point p0_0 = new Point();
Console.WriteLine(p0_0); // output: (0,0)

Point p1_2 = new Point(1, 2);
Console.WriteLine(p1_2); // output: (1,2)
