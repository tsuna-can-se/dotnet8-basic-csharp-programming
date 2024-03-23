namespace ShoppingSample;

public class ShoppingCart
{
    private Stack<Product> products = new Stack<Product>();

    public void Add(Product product)
    {
        this.products.Push(product);
    }

    public Product? TakeOut()
    {
        if (this.products.Count == 0)
        {
            return null;
        }

        return this.products.Pop();
    }
}
