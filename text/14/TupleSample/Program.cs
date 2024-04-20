(double X, double Y) p1_2 = (1, 2);
Console.WriteLine("X:" + p1_2.X);
Console.WriteLine("Y:" + p1_2.Y);

Console.WriteLine(GetOrigin());

(double x, double y) = GetOrigin();
Console.WriteLine("X:" + x); // output: X:0
Console.WriteLine("Y:" + y); // output: Y:0

(int year, int month, int day, _, _) = Now();
var (_, _, _, hour, minute) = Now();
Console.WriteLine("Year:" + year);
Console.WriteLine("Month:" + month);
Console.WriteLine("Day:" + day);

Console.WriteLine("Hour:" + hour);
Console.WriteLine("Minute:" + minute);

static (double X, double Y) GetOrigin()
{
    return (0, 0);
}

static (int year, int month, int day, int hour, int minute) Now()
{
    var now = DateTime.Now;
    return (now.Year, now.Month, now.Day, now.Hour, now.Minute);
}
