namespace ExtendsSample;

public class Dachshund : Dog
{
    public override string ToString()
    {
        return "ダックスフント。生年月日:" + this.BirthDay.ToString("d");
    }
}
