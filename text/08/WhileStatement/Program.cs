int rand = Random.Shared.Next(0, 5); // 0 ～ 4 の乱数を作成
while (rand != 0) // 乱数が 0 でない限り繰り返す
{
    Console.WriteLine("乱数は" + rand + "でした。");
    rand = Random.Shared.Next(0, 5); // 0 ～ 4 の乱数を再作成
}

Console.WriteLine("whileを終了します。");
