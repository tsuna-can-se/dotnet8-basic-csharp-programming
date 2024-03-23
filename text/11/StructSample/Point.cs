namespace StructSample;

public struct Point
{
    public double X { get; }
    public double Y { get; }

    public Point() : this(0, 0)
    {
    }

    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Show()
    {
        Console.WriteLine("(" + this.X + ", " + this.Y + ")");
    }
}
