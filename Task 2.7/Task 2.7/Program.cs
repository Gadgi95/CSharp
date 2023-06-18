// See https://aka.ms/new-console-template for more information

///Задание 1
string FullName = "Мурат";
int Age = 28;
string Email = "Kh.M@mail.com";
double ProgrammingPoints = 40.5;
double MathPoints = 30.0;
double PhysicsPoints = 30.5;

string PatternWriteStudentInfo = $"Имя: {FullName}\nВозраст: {Age}\nЭлектронная почта: {Email}\n" +
    $"Баллы по программированию: {ProgrammingPoints}\nБаллы по математике: {MathPoints}\nБаллы по физике: {PhysicsPoints}";

Console.ReadKey();

Console.WriteLine(PatternWriteStudentInfo);


///Задание 2
double TotalPoints = ProgrammingPoints + MathPoints + PhysicsPoints;
double AveragePoints = TotalPoints / 3;

string PatternWritePointsInfo = $"Сумма баллов по всем предметам: {TotalPoints}\nСредний балл: {AveragePoints}";

Console.ReadKey();

Console.WriteLine (PatternWritePointsInfo);

Console.ReadKey();



