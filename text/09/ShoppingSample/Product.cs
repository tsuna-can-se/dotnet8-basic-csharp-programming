namespace ShoppingSample;

public class Product
{
    private string? name;

    public string Name
    {
        get { return this.name != null ? this.name : string.Empty; }
        set { this.name = value; }
    }

    public decimal UnitPrice { get; set; }

    public decimal UnitPriceWithTax
    {
        get { return this.UnitPrice * 1.1m; }
    }

    public Product DeepCopy()
    {
        return new Product()
        {
            Name = this.Name,
            UnitPrice = this.UnitPrice
        };
    }
}