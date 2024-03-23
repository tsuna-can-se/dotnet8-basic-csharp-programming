using System.Runtime.CompilerServices;
using BclUsage;

Console.WriteLine("===Object class===");
ObjectUsage.Run();

Console.WriteLine("===Math class===");
MathUsage.Run();

Console.WriteLine("===DateTime / DateTimeOffset class===");
DateTimeUsage.Run();

Console.WriteLine("===TimeSpan class===");
TimeSpanUsage.Run();

Console.WriteLine("===HashSet class===");
HashSetUsage.Run();

Console.WriteLine("===Queue class===");
QueueUsage.Run();

Console.WriteLine("===Stack class===");
StackUsage.Run();

Console.WriteLine("===StringBuilder class===");
StringBuilderUsage.Run();

Console.WriteLine("===StreamReader class===");
StreamReaderUsage.Run();

Console.WriteLine("===StreamWriter class===");
StreamWriterUsage.Run();

Console.WriteLine("===Directory class===");
Directory.Delete("NewDirectory", true);
DirectoryUsage.Run();

Console.WriteLine("===File class===");
File.Delete("NewFile1.txt");
File.Delete("NewFile2.txt");
File.Delete("NewFile3.txt");
File.Delete("NewFile4.txt");
FileUsage.Run();
