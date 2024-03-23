namespace InterfaceSample;

public interface IPowerable
{
    bool IsPowerOn { get; }

    void PowerOn();

    void PowerOff();
}
