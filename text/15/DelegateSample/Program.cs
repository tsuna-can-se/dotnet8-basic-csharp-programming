using DelegateSample;

var calculator = new Calculator();
Func<int, int, int> addFunction = calculator.Add;
Func<int, int, int> subtractFunction = calculator.Subtract;

Console.WriteLine(addFunction(1,3));      // output: 4
Console.WriteLine(subtractFunction(1,3)); // output: -2
