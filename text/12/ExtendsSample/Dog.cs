namespace ExtendsSample;

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("ワンワン！");
    }

    public override void Walk()
    {
        base.Walk();
        Console.WriteLine("犬が歩く");
    }
}
