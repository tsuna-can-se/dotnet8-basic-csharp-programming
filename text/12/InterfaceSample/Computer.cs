namespace InterfaceSample;

public class Computer : IPowerable
{
    public bool IsPowerOn { get; private set; }

    public void PowerOn()
    {
        this.IsPowerOn = true;
        Console.WriteLine("コンピューターの電源を入れました。");
    }

    public void PowerOff()
    {
        this.IsPowerOn = false;
        Console.WriteLine("コンピューターの電源を切りました。");
    }
}
