for (int i = 0; i < 10; i++)
{
    if (i % 3 != 0) // i を 3 で割ったあまりが 0 ではない場合、次の繰り返しに進む
    {
        continue;
    }

    Console.WriteLine(i);
}
