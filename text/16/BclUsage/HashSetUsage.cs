namespace BclUsage;

public static class HashSetUsage
{
    public static void Run()
    {
        var hashSet = new HashSet<int> { 1, 2, 3 };

        // Count
        Console.WriteLine(hashSet.Count); // output: 3

        // Add
        Console.WriteLine(hashSet.Add(4)); // output: True
        Console.WriteLine(hashSet.Add(4)); // output: False

        // Contains
        Console.WriteLine(hashSet.Contains(1)); // output: True
        Console.WriteLine(hashSet.Contains(5)); // output: False

        // Remove
        Console.WriteLine(hashSet.Remove(4)); // output: True
        Console.WriteLine(hashSet.Remove(4)); // output: False

        // IsSubsetOf
        Console.WriteLine(hashSet.IsSubsetOf(new HashSet<int> { 1, 2, 3 })); // output: True
        Console.WriteLine(hashSet.IsSubsetOf(new HashSet<int> { 1, 2 }));    // output: False

        // IsSupersetOf
        Console.WriteLine(hashSet.IsSupersetOf(new HashSet<int> { 1, 2, 3 }));    // output: True
        Console.WriteLine(hashSet.IsSupersetOf(new HashSet<int> { 1, 2, 3, 4 })); // output: False

        // Clear
        hashSet.Clear();
        Console.WriteLine(hashSet.Count); // output: 0
    }
}
