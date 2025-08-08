using System.Collections.Generic;
namespace StudentGradeManager;

class Program
{
    static void Main(string[] args)
    {
        //Initialized correct folder in terminal using git


        /************************ STEP 2: CREATE CLASSES *************************

        Create a class called Student
        Create a property called Name of type string
        Create a property called ID of type int
        Create a property called Grades of type List
        ***Be sure to initialize the list

        ************************ STEP 3: CREATE METHODS **************************

        4.  Create a method called AddGrade in the Student class
            The method will accept one parameter.
            It will be of type double.
            Name the parameter grade
            The return type will be void
            In the scope of the method add the grade to your Grades list

        5.  Create a method called AddGrade in the Student class
            The method will accept a parameter of type double[]
            Use the params keyword
            Name the parameter grades
            The return type will be void.
            In the scope of the method add the grades to your Grades list using this code:
            Grades.AddRange(grades);
            Stage and Commit your work.

        6.  Create a method called CalculateAverageGrade in the Student class
            The method will accept no parameters
            The return type will be a double.
            In the scope of the method, calculate a student’s grade average (use the Grades list).
            If there are no grades in the Grades list, the method should return 0.
            Stage and Commit your work.


           ************************** STEP 4: Create a List *****************************

           In the main method, create a List of type Student.
           Name it students
           */

        var students = new List<Student>();


        /************************ STEP 5: Create Instances **************************
        In the main method, create 4 instances (also called objects) of type Student.
        Each instance represents a student.
        You may use one or all of the following types of syntax to create your instances:
        Dot notation
        Object initializer syntax
        Custom constructor */

        // DOT NOTATION:
        Student student1 = new Student();
        student1.Name = "Bryant";
        student1.ID = 01234;

        // OBJECT INITIALIZER SYNTAX:
        Student student2 = new Student() { Name = "Devin", ID = 11234 };

        // DOT NOTATTION:
        Student student3 = new Student();
        student3.Name = "Devonte";
        student3.ID = 21234;

        // OBJECT INITIALIZER:
        Student student4 = new Student() { Name = "Bryson", ID = 031694 };


        /*********************** STEP 6: Populate the List **************************
        Populate the list with your instances.
        Stage and Commit your work. */

        students.AddRange(new[] { student1, student2, student3, student4 });


    /************************ STEP 7: Call Methods *******************************
    Call the AddGrade() method twice for each instance (or student) you create.
    Be sure to invoke the overloads.
    Examples:
    student1.AddGrade(94.3);
    student1.AddGrade(90.0, 78.9, 95.4); */
           student1.AddGrade(99);
           student1.AddGrade(98.8, 94.8, 99);
           
           student2.AddGrade(100);
           student2.AddGrade(88, 94, 89);
           
           student3.AddGrade(75);
           student3.AddGrade(100, 97.4, 99);
           
           student4.AddGrade(100);
           student4.AddGrade(100, 92, 100);


        /************************ STEP 8: Loop through your list and Display Info *****
       Loop through your list of students
       You will decide what type of loop to use.
       Display the ID, name, the list of grades, and average grade for each student
       Use string interpolation to do this.
       You may need to use a nested loop to see all the grades for each individual student in the list */
        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name}, ID: {student.ID}");
            
            Console.Write("Grades: ");
            foreach (double grade in student.Grades)
            {
                Console.Write($"{grade}, ");
            }

            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}");
            Console.WriteLine(); 
        }
        
           /************************ STEP 9: Push your work to Github *********************
           Remember the git workflow to do this!
           Note: You may need to reference a previous lesson to help you. */
           
           /*BONUS: Course Information
            Create a course and set the values of the properties.
            Add at least two students to the course.
            Display the course information and the students that are enrolled in it.*/

           // Create course
           Course course = new Course();
           course.courseName = "Introduction to Programming";
           course.courseCode = "CS101";
           
           // Create Students
           Student s1 = new Student();
           s1.Name = "Bryzen";
           s1.ID = 8888;
           s1.Grades.AddRange(new double[] { 85, 90, 95 });

           Student s2 = new Student();
           s2.Name = "Breece";
           s2.ID = 7777;
           s2.Grades.AddRange(new double[] { 78, 82, 88 });
           
           course.EnrollStudent(s1);
           course.EnrollStudent(s2);
           
           // Enroll students
           foreach (Student student in students)
           {
               course.EnrollStudent(student);
           }
           // Try enrolling duplicate, this should print a message and skip it
           
           // Display course info
           course.DisplayCourseInfo();
    }
}