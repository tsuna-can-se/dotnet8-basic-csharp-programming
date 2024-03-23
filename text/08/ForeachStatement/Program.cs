string[] exams = new string[] { "英語", "数学", "国語", "社会", "理科" };

foreach (string exam in exams)
{
    Console.WriteLine("試験科目は" + exam + "です。");
}

Dictionary<int, string> map = new Dictionary<int, string>()
{
    { 1, "英語" },
    { 2, "数学" },
    { 3, "国語" },
    { 4, "社会" },
    { 5, "理科" },
};

foreach (var record in map)
{
    // record は KeyValuePair<int, string> 型
    Console.WriteLine("key:" + record.Key + " value:" + record.Value);
}
