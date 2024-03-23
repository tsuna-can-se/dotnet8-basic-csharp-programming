namespace ExtendsSample;

public class Human : Animal
{
    public override sealed DateTime BirthDay { get; set; }

    public override sealed void Walk()
    {
        Console.WriteLine("テクテク歩く");
    }
}

// 以下はコンパイルエラーになる
// public class Taro : Human
// {
//     public override DateTime BirthDay { get; set; }
// 
//     public override void Walk()
//     {
//         Console.WriteLine("トコトコ歩く");
//     }
// }
