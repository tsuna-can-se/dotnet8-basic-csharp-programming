#pragma warning disable CS4014 // この呼び出しは待機されなかったため、現在のメソッドの実行は呼び出しの完了を待たずに続行されます（解説のためのプログラムであるため警告を抑制）
namespace TaskSample;

public class ForgetAwait
{
    public void DoSomething()
    {
        Console.WriteLine($"Start:{DateTime.Now:HH:mm:ss.fff}");
        this.WaitRandomAsync();
        Console.WriteLine($"End:{DateTime.Now:HH:mm:ss.fff}");
    }

    private async Task WaitRandomAsync()
    {
        var waitTime = 1000;
        await Task.Delay(waitTime);

        // 以下の処理が行われる前にプログラムの実行が終わってしまう
        Console.WriteLine($"{waitTime}ミリ秒待ちました。");
    }
}
#pragma warning restore CS4014 // この呼び出しは待機されなかったため、現在のメソッドの実行は呼び出しの完了を待たずに続行されます
