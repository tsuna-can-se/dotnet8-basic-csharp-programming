using StructSample;

Console.WriteLine("===コンストラクター===");
Point p0_0 = new Point();
p0_0.Show(); // output: (0, 0)

Point p1_3 = new Point(1, 3);
p1_3.Show(); // output: (1, 3)

Console.WriteLine("===値型の特性確認===");
Point2 p1_1 = new Point2(1, 1);
ChangeValue(p1_1);
Console.WriteLine("(" + p1_1.X + ", " + p1_1.Y + ")"); // output: (1, 1)

static void ChangeValue(Point2 p)
{
    p.X = 10;
    p.Y = 20;
}
