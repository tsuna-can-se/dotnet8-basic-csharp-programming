namespace Ex09_02;

public class ClassRoom
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        this.students.Add(student);
    }

    public double GetEnglishScoreAverage()
    {
        double total = 0;
        foreach (Student student in this.students)
        {
            total += student.EnglishScore;
        }

        return total / this.students.Count;
    }

    public double GetMathScoreAverage()
    {
        double total = 0;
        foreach (Student student in this.students)
        {
            total += student.MathScore;
        }

        return total / this.students.Count;
    }


    public void ShowTopScoreStudent()
    {
        Student? top = null;
        foreach (Student student in this.students)
        {
            if (top == null || top.TotalScore < student.TotalScore)
            {
                top = student;
            }
        }

        if (top != null)
        {
            Console.WriteLine("このクラスの最高点数");
            Console.WriteLine("名前：" + top.Name);
            Console.WriteLine("英語：" + top.EnglishScore);
            Console.WriteLine("数学：" + top.MathScore);
            Console.WriteLine("合計：" + top.TotalScore);
        }
        else
        {
            Console.WriteLine("生徒が登録されていません。");
        }
    }
}
