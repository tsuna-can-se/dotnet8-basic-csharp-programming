namespace XmlDocumentCommentSample;

/// <summary>
///  X, Y 座標を表します。
/// </summary>
public class Point
{
    /// <summary>
    ///  X 座標を取得します。
    /// </summary>
    public int X { get; private set; }

    /// <summary>
    ///  Y 座標を取得します。
    /// </summary>
    public int Y { get; private set; }

    /// <summary>
    ///  <see cref="Point"/> クラスの新しいインスタンスを初期化します。
    /// </summary>
    /// <param name="x">X 座標。</param>
    /// <param name="y">Y 座標。</param>
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    /// <summary>
    ///  このインスタンスの文字列表現を取得します。
    /// </summary>
    /// <returns>(X, Y) 形式の文字列。</returns>
    public override string ToString()
    {
        return "(" + this.X + ", " + this.Y + ")";
    }
}
