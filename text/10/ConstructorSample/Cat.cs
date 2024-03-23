namespace ConstructorSample;

public class Cat
{
    private string voice;

    public Cat()
    {
        this.voice = "にゃー";
    }

    public void Meow()
    {
        Console.WriteLine(this.voice);
    }
}
