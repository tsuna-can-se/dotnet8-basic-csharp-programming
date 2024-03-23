namespace MethodSample;

public class Dog
{
    private int barkCount = 0;

    public void Bark()
    {
        this.barkCount++;
        this.BarkByCalledCount();
    }

    private void BarkByCalledCount()
    {
        if (this.barkCount % 2 == 0)
        {
            Console.WriteLine("ワンワン！");
        }
        else
        {
            Console.WriteLine("ワン！");
        }
    }
}
