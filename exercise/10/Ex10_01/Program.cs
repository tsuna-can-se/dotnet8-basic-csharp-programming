using Ex10_01;

Point p = new Point(0, 0);
for (int i = 1; i <= 3; i++)
{
    p = new Point(i, i * i);
}

// 以下2行のコンソール出力がどうなるか解答してください。
Console.WriteLine("p.X: " + p.X);
Console.WriteLine("p.Y: " + p.Y);
