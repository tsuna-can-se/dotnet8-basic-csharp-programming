namespace ExtendsSample;

public class Animal
{
    public virtual DateTime BirthDay { get; set; }

    public virtual void Walk()
    {
        Console.WriteLine("歩く");
    }
}
