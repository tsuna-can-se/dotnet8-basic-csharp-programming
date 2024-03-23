namespace Ex18;

public class SalesAggregator
{
    public SalesAggregateResult Aggregate(List<SalesHistory> salesHistories)
    {
        return new SalesAggregateResult(
            salesHistories.Min(s => s.Date),
            salesHistories.Max(s => s.Date),
            salesHistories.Count,
            salesHistories.Sum(s => s.Quantity * s.UnitPrice));
    }
}
