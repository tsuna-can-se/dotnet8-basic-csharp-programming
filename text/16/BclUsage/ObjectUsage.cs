namespace BclUsage;

public static class ObjectUsage
{
    public static void Run()
    {
        object object1 = new object();
        object object2 = new object();
        object object3 = object1;
        string str = "hoge";
        int i = 1;
        Person person = new Person("Taro", "Yamada");

        // Equals
        Console.WriteLine(object1.Equals(object2)); // output: False
        Console.WriteLine(object1.Equals(object3)); // output: True

        // GetHashCode
        Console.WriteLine(object1.GetHashCode()); // output: 54267293（値は環境によって変わる）
        Console.WriteLine(object2.GetHashCode()); // output: 18643596（値は環境によって変わる）
        Console.WriteLine(object3.GetHashCode()); // output: 54267293（object1と同じ値）

        // GetType
        Console.WriteLine(object1.GetType()); // output: System.Object
        Console.WriteLine(str.GetType());     // output: System.String
        Console.WriteLine(person.GetType());  // output: BclUsage.Person

        // ToString
        Console.WriteLine(object1.ToString()); // output: System.Object
        Console.WriteLine(i.ToString());       // output: 1
        Console.WriteLine(person.ToString());  // output: Person { FirstName = Taro, LastName = Yamada }
    }
}

public record Person(string FirstName, string LastName);
