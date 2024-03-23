using ShoppingSample;

Product candy = new Product() { Name = "あめ", UnitPrice = 10m };

// コンストラクターの () は省略可能
// Product candy = new Product { Name = "あめ", UnitPrice = 10m };

Product chewingGum = new Product() { Name = "ガム", UnitPrice = 20m };
Product cookie = new Product() { Name = "クッキー", UnitPrice = 50m };
Product chocolate = new Product() { Name = "チョコ", UnitPrice = 40m };
ProductShelf shelf = new ProductShelf();
shelf.Stock(new List<Product>() { candy, chewingGum, cookie, chocolate });

List<string> shoppingList = new List<string>()
{
    "あめ,3",
    "クッキー,2",
    "せんべい,1",
};
Customer customer1 = new Customer(shoppingList, shelf, 200);
customer1.Shopping();
