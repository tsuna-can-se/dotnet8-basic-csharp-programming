namespace Ex18;

public class SalesHistory
{
    public SalesHistory(long id, DateTime date, string productId, int quantity, decimal unitPrice)
    {
        ID = id;
        Date = date;
        ProductID = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public long ID { get; private set; }
    public DateTime Date { get; private set; }
    public string ProductID { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }
}
