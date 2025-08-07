namespace StudentGradeManager;

public class Course
{
    // Properties:
    //CourseName & CourseCode of type string
    public string courseName {get; set;}
    public string courseCode {get; set;}

    // Fields (or Property) to hold enrolled students
    public List<Student> EnrolledStudents;
    
    // Default constructor with initialized list in its scope
    public Course()
    {
        EnrolledStudents = new List<Student>();
    }
    
    // Method to enroll students (no duplicates allowed)
    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Any(s => s.ID == student.ID))
        {
            EnrolledStudents.Add(student);
        }
        else
        {
            Console.WriteLine($"Student {student.Name} is already enrolled.");
        }
    }
    
    // Method to display course info
    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {courseName} ({courseCode})");
        Console.WriteLine("Enrolled Students:");
        foreach (var s in EnrolledStudents)
        {
            Console.WriteLine($" - {s.Name}, Grades: {string.Join(", ", s.Grades)}, Avg: {s.CalculateAverageGrade():F2}");
        }
    }
}