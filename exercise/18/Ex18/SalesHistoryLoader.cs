namespace Ex18;

public class SalesHistoryLoader
{
    private readonly string filePath;

    public SalesHistoryLoader(string filePath)
    {
        this.filePath = filePath;
    }

    public List<SalesHistory> Load()
    {
        var salesHistories = new List<SalesHistory>();
        using (var reader = new StreamReader(this.filePath))
        {
            // 最初の行はヘッダーなので読み飛ばす
            reader.ReadLine();
            var line = reader.ReadLine();
            while (line != null)
            {
                var fields = line.Split(',');
                var id = long.Parse(fields[0]);
                var date = DateTime.Parse(fields[1]);
                var productId = fields[2];
                var quantity = int.Parse(fields[3]);
                var unitPrice = decimal.Parse(fields[4]);
                var salesHistory = new SalesHistory(id, date, productId, quantity, unitPrice);
                salesHistories.Add(salesHistory);

                // 次の行を読み込む
                line = reader.ReadLine();
            }
        }

        return salesHistories;
    }
}
