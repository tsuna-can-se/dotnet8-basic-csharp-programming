namespace Ex09_02;

public class Student
{
    public string? Name { get; set; }

    public int EnglishScore { get; set; }

    public int MathScore { get; set; }

    public int TotalScore
    {
        get { return this.EnglishScore + this.MathScore; }
    }
}
