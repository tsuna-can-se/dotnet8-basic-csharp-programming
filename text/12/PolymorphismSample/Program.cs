using PolymorphismSample;

Console.WriteLine("===具象クラスを利用する例===");
Animal animal = new Cat();
animal.Walk();

Console.WriteLine("===抽象クラスを利用する例===");
string loggerType = "FlatText";

DoSomething(loggerType);

Console.WriteLine("===型の検査===");
CheckType();

Console.WriteLine("===as 演算子によるキャスト===");
ConvertTypeAs(new Cat());

Console.WriteLine("===is 演算子によるキャスト===");
ConvertTypeIs(new Animal());

static void DoSomething(string loggerType)
{
    ConsoleLoggerBase consoleLogger = CreateConsoleLogger(loggerType);
    consoleLogger.WriteLog("ログテキスト");
}

static ConsoleLoggerBase CreateConsoleLogger(string loggerType)
{
    switch (loggerType)
    {
        case "FlatText":
            return new FlatTextConsoleLogger();
        case "Json":
            return new JsonConsoleLogger();
        default:
            throw new NotSupportedException();
    }
}

#pragma warning disable CS0184 // 'is' 式の指定された式は指定された型ではありません
static void CheckType()
{
    Animal animal = new Animal();
    Console.WriteLine(animal is Cat);
    Console.WriteLine(animal is Animal);
    Console.WriteLine(animal is object);
    Console.WriteLine(animal is string);
}
#pragma warning restore CS0184 // 'is' 式の指定された式は指定された型ではありません

static void ConvertTypeAs(Animal animal)
{
    Cat? cat = animal as Cat;
    if (cat != null)
    {
        Console.WriteLine("animal は猫");
    }
    else
    {
        Console.WriteLine("animal は猫ではない");
    }
}

static void ConvertTypeIs(Animal animal)
{
    if (animal is Cat cat)
    {
        Console.WriteLine("animal は猫");
    }
    else
    {
        Console.WriteLine("animal は猫ではない");
    }
}
