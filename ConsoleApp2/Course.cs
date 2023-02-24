namespace ConsoleApp2;

public class Course : ICourseService
{
    public string Name;
    public List<Student> Students;
    public Department Department;

    public Course(string name)
    {
        Name = name;
    }

    public void EnrollStudent(Student student)
    {
        student.EnrollCourse(this);
        Students.Add(student);
    }

    public void SetDepartment(Department department)
    {
        Department = department;
    }
}