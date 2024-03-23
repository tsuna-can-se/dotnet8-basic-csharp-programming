namespace Ex11_01;

public struct Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Show()
    {
        Console.WriteLine("(" + this.X + ", " + this.Y + ")");
    }

    public Point Add(Point p)
    {
        return new Point(this.X + p.X, this.Y + p.Y);
    }
}