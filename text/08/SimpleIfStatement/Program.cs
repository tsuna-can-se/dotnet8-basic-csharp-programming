// 条件式に bool 型の変数を利用する場合
bool b1 = true;
if (b1)
{
    Console.WriteLine("b1 は true。");
}

// 条件式に論理演算子（条件付き論理 OR）を利用する場合
bool b2 = false;
bool b3 = true;

if (b2 || b3)
{
    Console.WriteLine("b2 || b3 は true。");
}

// 条件式に比較演算子（非等値）を利用する場合
int a = 10;
int b = 15;

if (a != b)
{
    Console.WriteLine("a と b は非等値。");
}

// 条件式に比較演算子（小なり）を利用する場合
if (a < b)
{
    Console.WriteLine("a より b のほうが大きい。");
}
