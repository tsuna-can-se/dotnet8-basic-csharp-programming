namespace BclUsage;

public static class FileUsage
{
    public static void Run()
    {
        // Create
        var file1 = File.Create("NewFile1.txt");
        var file2 = File.Create("NewFile2.txt");
        var file3 = File.Create("NewFile3.txt");
        file1.Close();
        file2.Close();
        file3.Close();

        // Delete
        File.Delete("NewFile1.txt");

        // Exists
        Console.WriteLine(File.Exists("NewFile3.txt")); // output: True
        Console.WriteLine(File.Exists("NewFile1.txt")); // output: False       

        // WriteAllText
        File.WriteAllText("NewFile3.txt", "Hoge");

        // AppendAllText
        File.AppendAllText("NewFile3.txt", "Fuga");

        // ReadAllText
        Console.WriteLine(File.ReadAllText("NewFile3.txt")); // output: HogeFuga

        // Copy
        File.Copy("NewFile3.txt", "NewFile4.txt");

        // Move
        File.Move("NewFile2.txt", "NewFile5.txt");
    }
}
