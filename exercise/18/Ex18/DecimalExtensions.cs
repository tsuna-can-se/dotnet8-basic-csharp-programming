using System.Globalization;

namespace Ex18;

public static class DecimalExtensions
{
    public static string ToJPNYen(this decimal value)
    {
        return value.ToString("C", new CultureInfo("ja-JP"));
    }
}
