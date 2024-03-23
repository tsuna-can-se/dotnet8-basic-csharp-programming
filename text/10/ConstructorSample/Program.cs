using ConstructorSample;

Cat cat = new Cat();
Point point = new Point(1.5, 3.2);
Cat2 cat2 = new Cat2();

cat.Meow();
Console.WriteLine(point);
cat2.Meow();

Point p0_1 = new Point(0, 1);
Point p1_2 = new Point(1, 2);

Console.WriteLine(p0_1);
Console.WriteLine(p1_2);
