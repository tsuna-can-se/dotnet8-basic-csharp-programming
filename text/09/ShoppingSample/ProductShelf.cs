namespace ShoppingSample;

public class ProductShelf
{
    private List<Product> products = [];

    public Product? this[string productName]
    {
        get
        {
            foreach (var product in products)
            {
                if (product.Name == productName)
                {
                    return product;
                }
            }

            return null;
        }
    }

    public void Stock(List<Product> products)
    {
        this.products.AddRange(products);
    }
}
