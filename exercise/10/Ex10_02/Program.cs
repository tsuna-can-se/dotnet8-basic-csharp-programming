using Ex10_02;

Product p1 = new Product { Id = 10, Name = "初期値" };
SetIdAndName(p1);
Console.WriteLine("ID:" + p1.Id);
Console.WriteLine("製品名:" + p1.Name);

static void SetIdAndName(Product product)
{
    product.Id = 20;
    product.Name = "変更後";
}
