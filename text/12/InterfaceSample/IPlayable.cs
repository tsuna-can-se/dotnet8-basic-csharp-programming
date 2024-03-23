namespace InterfaceSample;

public interface IPlayable
{
    bool IsPlaying { get; }
    void Play();
    void Stop();
}
