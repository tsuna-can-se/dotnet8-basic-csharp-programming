namespace Ex15_02;

public static class Data
{
    public static Dictionary<int, string> Departments { get; } = new()
    {
        { 10, "営業部" },
        { 20, "開発部" },
        { 30, "総務部" },
        { 40, "経理部" },
    };

    public static List<Employee> Employees { get; } = new List<Employee>()
    {
        new Employee("太郎","佐藤", 35, 10),
        new Employee("花子","鈴木", 40, 10),
        new Employee("次郎","田中", 23, 10),
        new Employee("三郎","渡辺", 56, 10),
        new Employee("美紀","高橋", 49, 10),
        new Employee("正彦","伊藤", 26, 20),
        new Employee("恵子","山本", 31, 20),
        new Employee("健太","中村", 51, 20),
        new Employee("由美","小林", 29, 20),
        new Employee("大輔","加藤", 46, 20),
        new Employee("麻衣","吉田", 57, 30),
        new Employee("直樹","山田", 33, 30),
        new Employee("真理子","佐々木", 45, 30),
        new Employee("裕子","山口", 52, 30),
        new Employee("健太郎","松本", 30, 40),
        new Employee("優香","井上", 26, 40),
        new Employee("誠","木村", 43, 40),
        new Employee("瞳","清水", 55, 40),
        new Employee("幸子","斉藤", 41, 40),
        new Employee("大和","林", 38, 40),
    };
}

public record Employee(string FirstName, string LastName, int Age, int DepartmentCode);

public record Worker(string Name, int Age, string Department);
