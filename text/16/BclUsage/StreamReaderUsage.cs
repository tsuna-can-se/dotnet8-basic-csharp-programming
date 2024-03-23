using System.Text;

namespace BclUsage;

public static class StreamReaderUsage
{
    public static void Run()
    {
        // ReadLine
        using (var reader = new StreamReader("StreamReaderUsage_Sample.txt"))
        {
            Console.WriteLine(reader.ReadLine()); // output: サンプル
            Console.WriteLine(reader.ReadLine()); // output: Hoge
            Console.WriteLine(reader.ReadLine()); // output: 
        }

        // ReadToEnd
        using (var reader = new StreamReader("StreamReaderUsage_Sample.txt", Encoding.UTF8))
        {
            Console.WriteLine(reader.ReadToEnd()); // output: サンプル
                                                   //         Hoge
        }

        // Close
        using (var reader = new StreamReader("StreamReaderUsage_Sample.txt"))
        {
            reader.Close();

            try
            {
                reader.ReadLine(); // System.ObjectDisposedException: 'Cannot read from a closed TextReader.'
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
        }

        // Dispose
        using (var reader = new StreamReader("StreamReaderUsage_Sample.txt"))
        {
            reader.Dispose();

            try
            {
                reader.ReadLine(); // System.ObjectDisposedException: 'Cannot read from a closed TextReader.'
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
        }
    }
}
