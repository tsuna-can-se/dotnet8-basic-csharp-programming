(double X, double Y) p1_2 = (1, 2);
Console.WriteLine("X:" + p1_2.X);
Console.WriteLine("Y:" + p1_2.Y);

Console.WriteLine(GetOrigin());

static (double X, double Y) GetOrigin()
{
    return (0, 0);
}
