namespace StaticMemberSample;

public class StaticPropertySample
{
    public static string? SharedData { get; set; }

    public void ShowData()
    {
        Console.WriteLine("データ:" + SharedData);
    }
}
