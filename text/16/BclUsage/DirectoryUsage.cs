namespace BclUsage;

public static class DirectoryUsage
{
    public static void Run()
    {
        // CreateDirectory
        Directory.CreateDirectory("NewDirectory");
        Directory.CreateDirectory("NewDirectory\\sub1");
        Directory.CreateDirectory("NewDirectory\\sub2");

        // Exists
        Console.WriteLine(Directory.Exists("NewDirectory"));       // output: True
        Console.WriteLine(Directory.Exists("NewDirectory\\sub1")); // output: True
        Console.WriteLine(Directory.Exists("NewDirectory\\sub3")); // output: False

        // GetCurrentDirectory
        Console.WriteLine(Directory.GetCurrentDirectory());

        // GetDirectories
        var directories = Directory.GetDirectories("NewDirectory");
        foreach (var directory in directories)
        {
            Console.WriteLine(directory); // output: NewDirectory\sub1
                                          //         NewDirectory\sub2
        }

        // GetFiles
        var files = Directory.GetFiles(".");
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }

        // Delete
        Directory.Delete("NewDirectory\\sub1");

        // Move
        Directory.Move("NewDirectory\\sub2", "NewDirectory\\sub3");
    }
}
