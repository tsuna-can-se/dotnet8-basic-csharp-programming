int[] items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var result = GetSumAndAverage(items);
Console.WriteLine("合計:" + result.Sum);
Console.WriteLine("平均:" + result.Average);

(double Sum, double Average) GetSumAndAverage(int[] items)
{
    double sum = 0;
    for (int i = 0; i < items.Length; i++)
    {
        sum += items[i];
    }

    double average = sum / items.Length;
    return (sum, average);
}
