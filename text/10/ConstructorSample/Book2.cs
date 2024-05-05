namespace ConstructorSample;

public class Book2
{
    public required string Title { get; set; }

    public required string Author { get; set; }

    public override string ToString()
    {
        return $"Title:{this.Title}, Author:{this.Author}";
    }
}
