using EnumSample;

Console.WriteLine("===単純な列挙型===");
Color color = Color.Red;
Console.WriteLine(color); // output: Red
Console.WriteLine(color == Color.Red); // output: True

Console.WriteLine("===フラグ===");
Days monday = Days.Monday;
Days weekend = Days.Saturday | Days.Sunday;
Console.WriteLine(monday);  // output: Monday
Console.WriteLine(weekend); // output: Saturday, Sunday
Console.WriteLine(monday == Days.Monday);    // output: True
Console.WriteLine(weekend == Days.Saturday); // output: False
Console.WriteLine(weekend.HasFlag(Days.Saturday)); // output: True
Console.WriteLine(weekend.HasFlag(Days.Sunday));   // output: True
