namespace Ex12_01;

public class Point
{
    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public double X { get; }

    public double Y { get; }

    public override string ToString()
    {
        return "(" + this.X + ", " + this.Y + ")";
    }
}
