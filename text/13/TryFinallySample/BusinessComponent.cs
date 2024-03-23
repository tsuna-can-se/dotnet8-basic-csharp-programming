namespace TryFinallySample;

public class BusinessComponent
{
    public bool IsBusy { get; private set; } = false;

    public void DoWork()
    {
        this.IsBusy = true;
        try
        {
            this.RandomThrowException();
        }
        finally
        {
            this.IsBusy = false;
        }
    }

    private void RandomThrowException()
    {
        var rand = new Random();
        var number = rand.Next(0, 3);
        switch (number)
        {
            case 0:
                throw new InvalidOperationException("処理に失敗しました。");
            default:
                Console.WriteLine("処理成功");
                break;
        }
    }
}
