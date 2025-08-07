namespace StudentGradeManager;

public class Student
{
    public string Name { get; set; } 
    public double ID { get; set; }
    public List<double> Grades { get; set; } =  new List<double>();

    public void AddGrade(double grade)
    { 
        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }
        return Grades.Average();
    }

}