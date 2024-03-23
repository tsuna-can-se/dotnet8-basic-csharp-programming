namespace LinqSample;

public static class SimpleQueries
{
    public static void Sample1()
    {
        int[] scores = new int[] { 90, 71, 82, 93, 75, 82 };

        Console.WriteLine("===90点以上のデータを取得する===");
        var over90 = scores.Where(x => x >= 90);
        foreach (int score in over90)
        {
            Console.WriteLine(score); // output: 90 と 93
        }

        Console.WriteLine("===合計得点を計算する===");
        int total = scores.Sum();
        Console.WriteLine(total); // output: 493
    }

    public static void ToList()
    {
        Console.WriteLine("===リストへの変換===");
        int[] scores = new int[] { 90, 71, 82, 93, 75, 82 };
        List<int> scoreList = scores.ToList();

        foreach (int score in scoreList)
        {
            Console.WriteLine(score);
        }
    }

    public static void ToArray()
    {
        Console.WriteLine("===配列への変換===");
        List<string> classes = new List<string>() { "A", "B", "C" };
        string[] classArray = classes.ToArray();

        foreach (string c in classArray)
        {
            Console.WriteLine(c);
        }
    }

    public static void FirstAndFirstOrDefault()
    {
        Console.WriteLine("===最初の項目の取得（要素あり）===");
        List<string> classes = new List<string>() { "A", "B", "C" };
        string first = classes.First(); // A
        string? firstOrDefault = classes.FirstOrDefault(); // A

        Console.WriteLine(first);
        Console.WriteLine(firstOrDefault);
    }

    public static void FirstAndFirstOrDefault2()
    {
        Console.WriteLine("===最初の項目の取得（要素なし）===");
        List<string> classes = new List<string>();
        // string first = classes.First(); // InvalidOperationException
        string? firstOrDefault = classes.FirstOrDefault(); // null

        Console.WriteLine(firstOrDefault);
    }

    public static void SingleAndSingleOrDefault()
    {
        Console.WriteLine("===単一項目の取得（要素あり）===");
        List<string> classes = new List<string>() { "A" };
        string single = classes.Single(); // A
        string? singleOrDefault = classes.SingleOrDefault(); // A

        Console.WriteLine(single);
        Console.WriteLine(singleOrDefault);
    }

    public static void SingleAndSingleOrDefault2()
    {
        Console.WriteLine("===単一項目の取得（要素なし）===");
        List<string> classes = new List<string>();
        // string single = classes.Single(); // InvalidOperationException
        string? singleOrDefault = classes.SingleOrDefault(); // null

        Console.WriteLine(singleOrDefault);
    }

    public static void Find()
    {
        Console.WriteLine("===Find===");
        List<string> fruits = new List<string>() { "apple", "banana", "orange", "berry" };
        string? fruit = fruits.Find(x => x.StartsWith("b")); // banana
        Console.WriteLine(fruit);
    }

    public static void NotFind()
    {
        Console.WriteLine("===NotFind===");
        List<string> fruits = new List<string>() { "apple", "banana", "orange", "berry" };
        string? fruit = fruits.Find(x => x.StartsWith("c")); // null
        Console.WriteLine(fruit);
    }

    public static void Count()
    {
        Console.WriteLine("===Count===");
        List<string> classes = new List<string>() { "A", "B", "C" };
        int count = classes.Count(); // 3
        Console.WriteLine(count);
    }

    public static void Sum()
    {
        Console.WriteLine("===Sum===");
        int[] scores = new int[] { 90, 71, 82, 93, 75, 82 };
        int total = scores.Sum(); // 493
        Console.WriteLine(total);
    }

    public static void Average()
    {
        Console.WriteLine("===Average===");
        int[] scores = new int[] { 90, 71, 82, 93, 75, 84 };
        double average = scores.Average(); // 82.5
        Console.WriteLine(average);
    }

    public static void MaxAndMin()
    {
        Console.WriteLine("===Max / Min===");
        int[] scores = new int[] { 90, 71, 82, 93, 75, 82 };
        int max = scores.Max(); // 93
        int min = scores.Min(); // 71
        Console.WriteLine(max);
        Console.WriteLine(min);
    }

    public static void Where()
    {
        Console.WriteLine("===Where===");
        List<Point> points = new List<Point>()
        {
            new Point(0,5),
            new Point(-2,-3),
            new Point(2,-4),
            new Point(-4,1),
        };
        var selectedPoints = points.Where(point => point.X >= 0); // { X = 0, Y = 5 }, { X = 2, Y = -4 }
        foreach (var point in selectedPoints)
        {
            Console.WriteLine(point);
        }
    }

    public static void Select1()
    {
        Console.WriteLine("===Select(大文字変換)===");
        List<string> fruits = new List<string>() { "apple", "banana", "orange", "berry" };
        var upperFruits = fruits.Select(fruit => fruit.ToUpper()); // APPLE, BANANA, ORANGE, BERRY
        foreach (var fruit in upperFruits)
        {
            Console.WriteLine(fruit);
        }
    }

    public static void Select2()
    {
        Console.WriteLine("===Select(文字列長の付加)===");
        List<string> fruits = new List<string>() { "apple", "banana", "orange", "berry" };
        var data = fruits.Select(fruit => new { Name = fruit, Length = fruit.Length });
        foreach (var item in data)
        {
            Console.WriteLine(item.Name + " (" + item.Length + "文字)");
        }
    }

    public static void OrderBy1()
    {
        Console.WriteLine("===int配列の並べ替え===");
        int[] scores = new int[] { 90, 71, 82, 93, 75, 82 };
        var asc = scores.OrderBy(score => score); // 71, 75, 82, 82, 90, 93
        var desc = scores.OrderByDescending(score => score); // 93, 90, 82, 82, 75, 71
        foreach (var score in asc)
        {
            Console.WriteLine("　" + score);
        }

        foreach (var score in desc)
        {
            Console.WriteLine("　" + score);
        }
    }

    public static void OrderBy2()
    {
        Console.WriteLine("===Point リストの並べ替え===");
        List<Point> points = new List<Point>()
        {
            new Point(0,5),
            new Point(-2,-3),
            new Point(2,-4),
            new Point(-4,1),
        };
        var ascByX = points.OrderBy(point => point.X); // { X = -4, Y = 1 }, { X = -2, Y = -3 }, { X = 0, Y = 5 }, { X = 2, Y = -4 }
        foreach (var point in ascByX)
        {
            Console.WriteLine("　" + point);
        }
    }
}
