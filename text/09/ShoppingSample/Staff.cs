namespace ShoppingSample;

public class Staff
{
    private decimal totalPrice = 0m;
    private decimal totalPriceWithTax = 0m;
    private List<Product> purchasedProducts = new List<Product>();

    public decimal CalculatePrice(ShoppingCart shoppingCart)
    {
        Product? cartItem = shoppingCart.TakeOut();
        while (cartItem != null)
        {
            this.purchasedProducts.Add(cartItem);
            this.totalPriceWithTax += cartItem.UnitPriceWithTax;
            this.totalPrice += cartItem.UnitPrice;
            cartItem = shoppingCart.TakeOut();
        }
        Console.WriteLine("税込み合計は " + this.totalPriceWithTax + " 円です。");
        return this.totalPriceWithTax;
    }

    public List<Product> Checkout(decimal finalBill)
    {
        if (this.totalPriceWithTax != finalBill)
        {
            throw new InvalidOperationException("税込み価格 " + this.totalPriceWithTax + "円に対して、支払金額 " + finalBill + "円 が一致していません。");
        }

        CashRegister.AddSales(this.totalPriceWithTax, this.totalPrice);
        return this.purchasedProducts;
    }
}
