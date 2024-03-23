namespace ExtendExceptionSample;

internal class CustomException : Exception
{
    public CustomException()
        : this("既定の例外メッセージ")
    {
    }

    public CustomException(string? message)
        : base(message)
    {
    }

    public CustomException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}
