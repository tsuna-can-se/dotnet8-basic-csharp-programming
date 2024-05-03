namespace RecordSample;

public record Point2
{
    public Point2(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public int X { get; init; }
    public int Y { get; init; }
}
