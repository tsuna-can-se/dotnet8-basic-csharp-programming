namespace Ex14_02;

public static class Int32Extensions
{
    public static int Power(this int value, int exponent)
    {
        if (exponent < 0)
        {
            throw new ArgumentException("指数には0以上の数値を指定してください。", "exponent");
        }

        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= value;
        }

        return result;
    }
}
