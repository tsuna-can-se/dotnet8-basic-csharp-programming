namespace InterfaceSample;

public class Recorder : IPowerable, IPlayable
{
    public bool IsPowerOn { get; private set; }
    public bool IsPlaying { get; private set; }

    public void PowerOn()
    {
        this.IsPowerOn = true;
        Console.WriteLine("◆レコーダーの電源を入れました。");
    }

    public void PowerOff()
    {
        if (this.IsPlaying)
        {
            this.Stop();
        }

        this.IsPowerOn = false;
        Console.WriteLine("◆レコーダーの電源を切りました。");
    }

    public void Play()
    {
        this.IsPlaying = true;
        Console.WriteLine("◆レコーダーを再生します。");
    }

    public void Stop()
    {
        this.IsPlaying = false;
        Console.WriteLine("◆レコーダーを停止します。");
    }
}
