namespace PrimaryConstructor;

public class Address(string zip, string state, string city, string street)
{
    public override string ToString()
    {
        return $"〒{zip} {state} {city} {street}";
    }
}