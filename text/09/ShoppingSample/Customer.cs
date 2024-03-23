namespace ShoppingSample;

public class Customer
{
    private decimal cash;
    private List<string> shoppingList = new List<string>();
    private ShoppingCart? shoppingCart;
    private ProductShelf shelf;

    public Customer(List<string> shoppingList, ProductShelf shelf, decimal cash)
    {
        this.shoppingList.AddRange(shoppingList);
        this.shelf = shelf;
        this.cash = cash;
    }

    public void Shopping()
    {
        Console.WriteLine("買い物をはじめます。所持金は " + this.cash + " 円です。");
        this.shoppingCart = new ShoppingCart();
        foreach (var memo in this.shoppingList)
        {
            var memoTokens = memo.Split(',');
            var productName = memoTokens[0];
            var amount = Convert.ToInt32(memoTokens[1]);
            var product = this.shelf[productName];
            if (product != null)
            {
                for (int i = 0; i < amount; i++)
                {
                    this.shoppingCart.Add(product.DeepCopy());
                    Console.WriteLine(product.Name + " (" + product.UnitPriceWithTax + "円) を買い物かごに入れました。");
                }
            }
            else
            {
                Console.WriteLine(productName + " がみつかりません。");
            }
        }

        Staff staff = new Staff();
        Console.WriteLine("会計をお願いします。");
        decimal total = staff.CalculatePrice(this.shoppingCart);
        this.cash -= total;
        var products = staff.Checkout(total);
        Console.WriteLine(total + " 円支払いました。残金は " + this.cash + " 円です。");
    }
}
