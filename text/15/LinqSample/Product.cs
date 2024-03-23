namespace LinqSample;

public record Product(string Name, decimal Price, Category CategoryId);

public enum Category
{
    Book,
    Food,
}
