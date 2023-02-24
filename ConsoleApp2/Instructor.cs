namespace ConsoleApp2;

public class Instructor : Person, IInstructorService
{
    public DateTime DateEmployed;
    public Department Department;

    public Instructor(string birthday, string name, string dateEmployed) : base( birthday, name)
    {
        DateEmployed = DateTime.Parse(dateEmployed);
    }

    public decimal CalculateBonus()
    {
        return 1000 * ((DateTime.Today - DateEmployed).Days / 365);
    }

    public override decimal CalculateSalary()
    {
        return base.CalculateSalary() + CalculateBonus();
    }

    public void BecomeHead(Department department)
    {
        Department = department;
    }
}