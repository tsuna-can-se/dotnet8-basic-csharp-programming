namespace Ex12_02;

public class Sphere : IShape
{
    private double radius;

    public Sphere(double radius)
    {
        this.radius = radius;
    }

    public string Name
    {
        get { return "球"; }
    }
}
