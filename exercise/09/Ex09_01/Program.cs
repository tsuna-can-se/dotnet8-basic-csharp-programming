using Ex09_01;

Car car = new Car();

Console.WriteLine("==== 給油していない状態で車を走らせる ====");
car.Drive();

Console.WriteLine("==== ガソリンを30リットル給油してから走らせる ====");
var amount1 = car.Refill(30);
Console.WriteLine(amount1 + "リットル給油しました。");
car.Drive();

Console.WriteLine("==== ガソリンが50リットル以上になるまで給油する ====");
var amount2 = car.Refill(40);
Console.WriteLine(amount2 + "リットル給油しました。");

Console.WriteLine("==== 給油量が0リットル以下 ====");
var amount3 = car.Refill(0);
Console.WriteLine(amount3 + "リットル給油しました。");
