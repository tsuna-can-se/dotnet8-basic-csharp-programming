namespace StaticMemberSample;

public class StaticFieldSample
{
    private static int sharedData = 0;

    public void UpdateSharedData(int newData)
    {
        sharedData = newData;
    }

    public void ShowSharedData()
    {
        Console.WriteLine("データ:" + sharedData);
    }
}
