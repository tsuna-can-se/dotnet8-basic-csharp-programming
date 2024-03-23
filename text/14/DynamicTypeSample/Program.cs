dynamic? point = GetPoint();
Console.WriteLine(point.ToString()); // output: Point { X = 10, Y = 20 }

dynamic point2 = new Point(1, 2);
Console.WriteLine(point2.X); // output: 1
Console.WriteLine(point2.Z); // 実行時エラー

static dynamic GetPoint()
{
    return new Point(10, 20);
}

record Point(int X, int Y);
