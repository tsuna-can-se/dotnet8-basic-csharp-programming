namespace Ex12_02;

public class Circle : IAreaCalculable, IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public string Name
    {
        get { return "円"; }
    }

    public double CalculateArea()
    {
        return Math.PI * this.radius * this.radius;
    }
}