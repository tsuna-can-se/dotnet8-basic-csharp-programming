while (true)
{
    int rand = Random.Shared.Next(0, 5); // 0 ～ 4 の乱数を作成
    Console.WriteLine("乱数は" + rand + "でした。");
    if (rand == 0) // 乱数が 0 なら繰り返し処理を終了
    {
        break;
    }
}

Console.WriteLine("whileを終了します。");
