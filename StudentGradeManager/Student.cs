namespace StudentGradeManager;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<int> Grades { get; set; } =  new List<int>();

    public static void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    public static void AddGrade(double[] grades)
    {
        Grades.AddRange(grades);
    }

}