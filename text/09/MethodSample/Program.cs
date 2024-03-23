using MethodSample;

Dog pochi = new Dog();
pochi.Bark();
pochi.Bark();
pochi.Bark();

// private なフィールドやプロパティへのアクセスはコンパイルエラーになる。
// pochi.barkCount;
// pochi.BarkByCalledCount();

Console.WriteLine("========");

Calculator calculator = new Calculator();
calculator.ShowAddResult(4, 5);

Console.WriteLine("========");

int a = 2;
int b = 3;
calculator.ShowAddResult(a, b);
calculator.ShowAddResult(a * b, 10);

Console.WriteLine("========");
int sum = calculator.Add(6, 7);
Console.WriteLine("合計：" + sum);
