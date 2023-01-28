
using VisitorPattern;

class Program
{
    static void Main(string[] args)
    {
        School school = new School();
        var visitor1 = new Doctor("Suliman Alhabib");

        var visitor2 = new Teacher("Abdul-Khaleq");

        school.performOperation(visitor1);
        school.performOperation(visitor2);
        Console.WriteLine(school);
    }
}
