using Ex12_02;

IShape[] shapes = new IShape[]
{
    new Circle(10),
    new Sphere(3),
    new Rectangle(5,3),
};

foreach (var shape in shapes)
{
    Console.Write("図形は" + shape.Name + "です。");
    if (shape is IAreaCalculable areaCalculable)
    {
        Console.WriteLine("面積（平面）は" + areaCalculable.CalculateArea() + "です。");
    }
    else
    {
        Console.WriteLine("面積（平面）は計算できません。");
    }
}
