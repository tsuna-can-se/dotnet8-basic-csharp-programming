ShowMessage(); // output: こんにちは
ShowMessage("こんばんは"); // output: こんばんは

Greet(); // output: こんにちは, 太郎
Greet("次郎"); // output: こんにちは, 次郎
Greet(phrase: "こんばんは"); // output: こんばんは, 太郎

static void ShowMessage(string message = "こんにちは")
{
    Console.WriteLine(message);
}

static void Greet(string name = "太郎", string phrase = "こんにちは")
{
    Console.WriteLine(phrase + ", " + name);
}
