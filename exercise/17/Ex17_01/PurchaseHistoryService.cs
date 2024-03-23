namespace Ex17_01;

public static class PurchaseHistoryService
{
    public static async Task<List<PurchaseHistory>> GetPurchaseHistoriesAsync(int vendorId)
    {
        var histories = new List<PurchaseHistory>();
        if (vendorId == 100)
        {
            await Task.Delay(3000);
            histories.Add(new PurchaseHistory(vendorId, "A001", 10, 3000));
            histories.Add(new PurchaseHistory(vendorId, "A002", 20, 2000));
            histories.Add(new PurchaseHistory(vendorId, "A003", 30, 1000));
        }
        else if (vendorId == 200)
        {
            await Task.Delay(2000);
            histories.Add(new PurchaseHistory(vendorId, "B001", 5, 15000));
            histories.Add(new PurchaseHistory(vendorId, "B002", 8, 9800));
            histories.Add(new PurchaseHistory(vendorId, "B003", 4, 80000));
            histories.Add(new PurchaseHistory(vendorId, "B004", 2, 120000));
        }
        else if (vendorId == 300)
        {
            await Task.Delay(2500);
            histories.Add(new PurchaseHistory(vendorId, "C001", 150, 150));
            histories.Add(new PurchaseHistory(vendorId, "C002", 20, 1280));
            histories.Add(new PurchaseHistory(vendorId, "C003", 80, 560));
            histories.Add(new PurchaseHistory(vendorId, "C004", 100, 310));
            histories.Add(new PurchaseHistory(vendorId, "C005", 200, 78));
        }
        else
        {
            throw new ArgumentException("vendorId には 100 または 200 または 300 を指定してください。", nameof(vendorId));
        }

        return histories;
    }
}

public record PurchaseHistory(int VendorId, string ProductId, int Quantity, decimal UnitPrice);
