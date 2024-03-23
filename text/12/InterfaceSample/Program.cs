using InterfaceSample;

Console.WriteLine("===インターフェイスの実装===");
Computer computer = new Computer();
ShowPowerStatus(computer);
computer.PowerOn();
ShowPowerStatus(computer);
computer.PowerOff();
ShowPowerStatus(computer);

Console.WriteLine("===インターフェイスの多重実装===");
Recorder recorder = new Recorder();
ShowPowerAndPlayingStatus(recorder);
recorder.PowerOn();
ShowPowerAndPlayingStatus(recorder);
recorder.Play();
ShowPowerAndPlayingStatus(recorder);
recorder.Stop();
ShowPowerAndPlayingStatus(recorder);
recorder.PowerOff();
ShowPowerAndPlayingStatus(recorder);

static void ShowPowerStatus(Computer computer)
{
    Console.WriteLine("電源は" + (computer.IsPowerOn ? "入っています" : "切れています") + "。");
}

static void ShowPowerAndPlayingStatus(Recorder recorder)
{
    Console.WriteLine("レコーダーは" + (recorder.IsPlaying ? "再生中です" : "停止中です") + "。");
    Console.WriteLine("レコーダーの電源は" + (recorder.IsPowerOn ? "入っています" : "切れています") + "。");
}
