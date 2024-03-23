using Ex18;

var filePath = "SalesData.csv";
var salesHistoryLoader = new SalesHistoryLoader(filePath);
var salesHistories = salesHistoryLoader.Load();

var salesAggregator = new SalesAggregator();
var result = salesAggregator.Aggregate(salesHistories);

Console.WriteLine($"集計期間: {result.StartDate} - {result.EndDate}");
Console.WriteLine($"データ件数: {result.Count}件");
Console.WriteLine($"売上合計: {result.TotalSales.ToJPNYen()}");
