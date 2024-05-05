namespace ConstructorSample;

public class Book1
{
    public Book1(string title, string author)
    {
        this.Title = title;
        this.Author = author;
    }

    public string Title { get; set; }

    public string Author { get; set; }

    public override string ToString()
    {
        return $"Title:{this.Title}, Author:{this.Author}";
    }
}
