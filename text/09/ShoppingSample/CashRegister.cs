namespace ShoppingSample;

public static class CashRegister
{
    private static decimal totalSalesWithTax = 0m;
    private static decimal totalSales = 0m;

    public static void AddSales(decimal salesWithTax, decimal sales)
    {
        totalSalesWithTax += salesWithTax;
        totalSales += sales;
    }

    public static void ShowSales()
    {
        Console.WriteLine("税込み売上：" + totalSalesWithTax);
        Console.WriteLine("税抜き売上：" + totalSales);
    }
}
