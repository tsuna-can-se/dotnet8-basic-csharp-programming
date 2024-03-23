int a, b;

// 30, 10 という整数値を生成する式（右辺）の結果を変数 a, b に代入。
a = 30;
b = 10;

// a + b を計算する式の結果を変数 sum に代入。
int sum = a + b;

// 右辺の計算する式の結果を変数に代入。
int difference = a - b;
int product = a * b;
int quotient = a / b;

// hello, ツナ缶 という文字列値を生成する式（右辺）の結果を変数 hello, name に代入。
string hello = "hello";
string name = "ツナ缶";

// 同じ + 演算子であっても、型が変わると意味が変わる。
// 文字列に対する + は文字列の連結結果を生成する式になる。
string message = hello + ", " + name;

// 代入できるような結果を生成しない式もある。
Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(product);
Console.WriteLine(quotient);
Console.WriteLine(message);
