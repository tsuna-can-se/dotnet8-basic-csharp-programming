namespace LinqSample;

public static class StandardQueries
{
    private static readonly List<Product> products = new List<Product>()
    {
        new Product("C#の本", 2500, Category.Book),
        new Product("Visual Studioの本", 2800, Category.Book),
        new Product("りんご", 100, Category.Food),
        new Product("みかん", 390, Category.Food),
        new Product(".NETの本", 2200, Category.Book),
        new Product("C#入門", 2400, Category.Book),
        new Product("さくらんぼ", 500, Category.Food),
        new Product("もも", 250, Category.Food),
    };

    public static void Sample1()
    {
        Console.WriteLine("===C#関連書籍の検索===");
        var csharpBooks = products
            .Where(product => product.CategoryId == Category.Book && product.Name.Contains("C#"));
        foreach (var product in csharpBooks)
        {
            Console.WriteLine(product);
        }
    }

    public static void Sample2()
    {
        Console.WriteLine("===検索と並び替え===");
        var orderedProducts = products
            .Where(product => product.Price <= 2400)
            .OrderBy(product => product.Price)
            .OrderBy(product => product.CategoryId);
        foreach (var product in orderedProducts)
        {
            Console.WriteLine(product);
        }
    }

    public static void Sample3()
    {
        Console.WriteLine("===検索と集計===");
        var foodPriceAverage = products
            .Where(product => product.CategoryId == Category.Food)
            .Average(product => product.Price);
        Console.WriteLine(foodPriceAverage);
    }
}
