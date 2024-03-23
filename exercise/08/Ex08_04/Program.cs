Dictionary<string, int> scores = new Dictionary<string, int>()
{
    { "社会", 90 },
    { "国語", 80 },
    { "英語", 75 },
    { "数学", 85 },
    { "理科", 65 },
};

int total = 0;
foreach (var score in scores)
{
    if (score.Key == "国語" || score.Key == "英語" || score.Key == "数学")
    {
        total += score.Value;
    }
}

Console.WriteLine("国語、英語、数学の合計得点は" + total + "点です。");
