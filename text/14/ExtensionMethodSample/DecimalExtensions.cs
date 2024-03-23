using System.Globalization;

namespace ExtensionMethodSample;

public static class DecimalExtensions
{
    public static string ToJPNYen(this decimal value)
    {
        return value.ToString("C", new CultureInfo("ja-JP"));
    }
}
