using ValueAndRefArguments;

Console.WriteLine("====値型===");
int i = 50;
ChangeValue(i);
Console.WriteLine("メソッド呼び出し後の値:" + i); // output: メソッド呼び出し後の値:50

Console.WriteLine("====参照型(ヒープの変更)===");
Product p1 = new Product { Id = 10, Name = "初期値" };
SetIdAndName(p1);
Console.WriteLine("メソッド呼び出し後のID:" + p1.Id); // output: メソッド呼び出し後のID:20
Console.WriteLine("メソッド呼び出し後の製品名:" + p1.Name); // output: メソッド呼び出し後の製品名:メソッド内で設定した名前

Console.WriteLine("====参照型(スタックの変更)===");
Product p2 = new Product { Id = 30, Name = "初期値" };
ChangeProduct(p2);
Console.WriteLine("メソッド呼び出し後のID:" + p2.Id); // output: メソッド呼び出し後のID:30
Console.WriteLine("メソッド呼び出し後の製品名:" + p2.Name); // output: メソッド呼び出し後の製品名:初期値

static void ChangeValue(int value)
{
    Console.WriteLine("引数に設定された値:" + value); // output: 引数に設定された値:50
    value = 100;
}

static void SetIdAndName(Product product)
{
    Console.WriteLine("引数に設定されたID:" + product.Id); // output: 引数に設定されたID:10
    Console.WriteLine("引数に設定された製品名:" + product.Name); // output: 引数に設定された製品名:初期値
    product.Id = 20;
    product.Name = "メソッド内で設定した名前";
}

static void ChangeProduct(Product product)
{
    Console.WriteLine("引数に設定されたID:" + product.Id); // output: 引数に設定されたID:30
    Console.WriteLine("引数に設定された製品名:" + product.Name); // output: 引数に設定された製品名:初期値
    Product newProduct = new Product { Id = 40, Name = "メソッド内で設定した名前" };
    product = newProduct;
}
