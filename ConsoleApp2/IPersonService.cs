namespace ConsoleApp2;

public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    List<string> GetAddresses();
    void AddAddress(string address);
}

public interface IInstructorService: IPersonService
{
    decimal CalculateBonus();
    void BecomeHead(Department department);
}

public interface IStudentService : IPersonService
{
    void EnrollCourse(Course course);
    void GetGrade(Course course, char grade);
    float CalculateGpa();
    
}

public interface ICourseService
{
    void EnrollStudent(Student student);
    void SetDepartment(Department department);
}

public interface IDepartmentService
{
    void SetInstructor(Instructor instructor);
    void AddCourse(Course course);
}