using System;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Grade { get; set; }

    public Student(int id, string name, string grade)
    {
        Id = id;
        Name = name;
        Grade = grade;
    }
}

class StudentView
{
    public void DisplayStudentDetails(Student student)
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("------------------------");
        Console.WriteLine("ID    : " + student.Id);
        Console.WriteLine("Name  : " + student.Name);
        Console.WriteLine("Grade : " + student.Grade);
    }
}

class StudentController
{
    private Student model;
    private StudentView view;

    public StudentController(Student model, StudentView view)
    {
        this.model = model;
        this.view = view;
    }

    public void SetStudentName(string name)
    {
        model.Name = name;
    }

    public void SetStudentGrade(string grade)
    {
        model.Grade = grade;
    }

    public void UpdateView()
    {
        view.DisplayStudentDetails(model);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(101, "Ishan", "A");

        StudentView view = new StudentView();

        StudentController controller = new StudentController(student, view);

        Console.WriteLine("Initial Details:");
        controller.UpdateView();

        controller.SetStudentName("Rahul");
        controller.SetStudentGrade("A+");

        Console.WriteLine("\nUpdated Details:");
        controller.UpdateView();
    }
}