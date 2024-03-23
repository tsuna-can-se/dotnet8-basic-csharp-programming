var directory = Directory.GetCurrentDirectory();
var files = Directory.GetFiles(directory, "*.dll");
foreach (var file in files)
{
    Console.WriteLine(file);
}
