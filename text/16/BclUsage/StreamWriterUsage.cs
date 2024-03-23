namespace BclUsage;

public static class StreamWriterUsage
{
    public static void Run()
    {
        using (var writer = new StreamWriter("StreamWriterUsage_Write.txt"))
        {
            writer.Write("Hoge"); // "Hoge" をバッファーに書き込む
        }

        // WriteLine
        using (var writer = new StreamWriter("StreamWriterUsage_WriteLine.txt", true))
        {
            writer.WriteLine("Piyo"); // "Piyo" をバッファーに書き込み、改行文字を追加する
        }

        // Flush
        using (var writer = new StreamWriter("StreamWriterUsage_Flush.txt", true, System.Text.Encoding.UTF8))
        {
            writer.WriteLine("Fuga"); // "Fuga" をバッファーに書き込み、改行文字を追加する
            writer.Flush();           // バッファに書き込まれているデータをファイルに書き込む
        }

        // Close
        using (var writer = new StreamWriter("StreamWriterUsage_Close.txt"))
        {
            writer.WriteLine("Peke"); // "Peke" をバッファーに書き込み、改行文字を追加する
            writer.Close();           // バッファに書き込まれているデータをファイルに書き込み、ファイルを閉じる
        }

        // Dispose
        using (var writer = new StreamWriter("StreamWriterUsage_Dispose.txt"))
        {
            writer.Dispose();

            try
            {
                writer.WriteLine("Hoge"); // System.ObjectDisposedException: 'Cannot write to a closed TextWriter.'
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
        }
    }
}
