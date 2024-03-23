namespace Ex12_02;

public class Rectangle : IAreaCalculable, IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public string Name
    {
        get { return "四角"; }
    }

    public double CalculateArea()
    {
        return this.width * this.height;
    }
}
