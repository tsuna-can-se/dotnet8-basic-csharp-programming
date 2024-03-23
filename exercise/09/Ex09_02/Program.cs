using Ex09_02;

ClassRoom classRoom = new ClassRoom();
classRoom.AddStudent(new Student() { Name = "翔太", EnglishScore = 68, MathScore = 85 });
classRoom.AddStudent(new Student() { Name = "大輝", EnglishScore = 83, MathScore = 93 });
classRoom.AddStudent(new Student() { Name = "拓海", EnglishScore = 95, MathScore = 61 });
classRoom.AddStudent(new Student() { Name = "海斗", EnglishScore = 76, MathScore = 58 });
classRoom.AddStudent(new Student() { Name = "陸", EnglishScore = 83, MathScore = 66 });
classRoom.AddStudent(new Student() { Name = "美咲", EnglishScore = 81, MathScore = 63 });
classRoom.AddStudent(new Student() { Name = "萌", EnglishScore = 64, MathScore = 77 });
classRoom.AddStudent(new Student() { Name = "葵", EnglishScore = 78, MathScore = 62 });
classRoom.AddStudent(new Student() { Name = "彩乃", EnglishScore = 90, MathScore = 92 });
classRoom.AddStudent(new Student() { Name = "さくら", EnglishScore = 59, MathScore = 80 });

double englishAverage = classRoom.GetEnglishScoreAverage();
double mathAverage = classRoom.GetMathScoreAverage();
Console.WriteLine("英語の平均点数：" + englishAverage);
Console.WriteLine("数学の平均点数：" + mathAverage);
Console.WriteLine("====");
classRoom.ShowTopScoreStudent();
