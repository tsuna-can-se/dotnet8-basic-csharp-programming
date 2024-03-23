using ExtensionMethodSample;

decimal value = 1200;
Console.WriteLine(value.ToJPNYen()); // output: ¥1,200
Console.WriteLine(DecimalExtensions.ToJPNYen(value)); // output: ¥1,200
