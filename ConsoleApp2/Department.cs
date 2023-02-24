namespace ConsoleApp2;

public class Department : IDepartmentService
{
    public string Name;
    public Instructor Head;
    public List<Course> Courses = new List<Course>();
    public Dictionary<Tuple<DateTime, DateTime>, decimal> Budget = new Dictionary<Tuple<DateTime, DateTime>, decimal>();

    public Department(string name)
    {
        Name = name;
    }

    public void SetInstructor(Instructor instructor)
    {
        instructor.BecomeHead(this);
        Head = instructor;
    }

    public void AddCourse(Course course)
    {
        course.SetDepartment(this);
        Courses.Add(course);
    }
}