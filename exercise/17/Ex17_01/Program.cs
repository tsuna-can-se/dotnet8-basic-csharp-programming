using Ex17_01;

// 機能は満たしているが、効率が悪い処理の回答例
//Console.WriteLine($"処理開始:{DateTime.Now:HH:mm:ss.fff}");
//var vendor100Total = await GetPurchaseTotalAsync(100);
//var vendor200Total = await GetPurchaseTotalAsync(200);
//var vendor300Total = await GetPurchaseTotalAsync(300);
//var total = vendor100Total + vendor200Total + vendor300Total;
//Console.WriteLine($"総仕入れ額:{total:c}");
//Console.WriteLine($"処理終了:{DateTime.Now:HH:mm:ss.fff}");

//static async Task<decimal> GetPurchaseTotalAsync(int vendorId)
//{
//    var histories = await PurchaseHistoryService.GetPurchaseHistoriesAsync(vendorId);
//    var total = histories.Sum(x => x.Quantity * x.UnitPrice);
//    Console.WriteLine($"VendorID {vendorId} 仕入れ額:{total:c}");
//    return total;
//}

// 効率化した処理の回答例(awaitを利用する場合)
//Console.WriteLine($"処理開始:{DateTime.Now:HH:mm:ss.fff}");
//var vendor100TotalTask = GetPurchaseTotalAsync(100);
//var vendor200TotalTask = GetPurchaseTotalAsync(200);
//var vendor300TotalTask = GetPurchaseTotalAsync(300);
//var vendor100Total = await vendor100TotalTask;
//var vendor200Total = await vendor200TotalTask;
//var vendor300Total = await vendor300TotalTask;
//var total = vendor100Total + vendor200Total + vendor300Total;
//Console.WriteLine($"総仕入れ額:{total:c}");
//Console.WriteLine($"処理終了:{DateTime.Now:HH:mm:ss.fff}");

//static async Task<decimal> GetPurchaseTotalAsync(int vendorId)
//{
//    var histories = await PurchaseHistoryService.GetPurchaseHistoriesAsync(vendorId);
//    var total = histories.Sum(x => x.Quantity * x.UnitPrice);
//    Console.WriteLine($"VendorID {vendorId} 仕入れ額:{total:c}");
//    return total;
//}

// 効率化した処理の回答例(Task.WhenAllを利用する場合)
Console.WriteLine($"処理開始:{DateTime.Now:HH:mm:ss.fff}");
var vendor100TotalTask = GetPurchaseTotalAsync(100);
var vendor200TotalTask = GetPurchaseTotalAsync(200);
var vendor300TotalTask = GetPurchaseTotalAsync(300);
var subTotals = await Task.WhenAll(vendor100TotalTask, vendor200TotalTask, vendor300TotalTask);
var total = subTotals.Sum();
Console.WriteLine($"総仕入れ額:{total:c}");
Console.WriteLine($"処理終了:{DateTime.Now:HH:mm:ss.fff}");

static async Task<decimal> GetPurchaseTotalAsync(int vendorId)
{
    var histories = await PurchaseHistoryService.GetPurchaseHistoriesAsync(vendorId);
    var total = histories.Sum(x => x.Quantity * x.UnitPrice);
    Console.WriteLine($"VendorID {vendorId} 仕入れ額:{total:c}");
    return total;
}