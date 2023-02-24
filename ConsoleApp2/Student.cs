namespace ConsoleApp2;

public class Student : Person, IStudentService
{
    private Dictionary<Course, char> Gradings = new Dictionary<Course, char>();

    public Student(string birthday, string name) : base(birthday, name)
    {
        
    }

    public override decimal CalculateSalary()
    {
        return 0;
    }

    public void EnrollCourse(Course course)
    {
        if (!Gradings.ContainsKey(course))
        {
            Gradings.Add(course, '~');
        }
    }

    public void GetGrade(Course course, char grade)
    {
        if (Gradings.ContainsKey(course))
        {
            Gradings[course] = grade;
        }
    }

    public float CalculateGpa()
    {
        if (Gradings.Count == 0)
            return 0;
        
        float sum = 0;
        foreach (var grading in Gradings)
        {
            switch (grading.Value)
            {
                case 'A':
                    sum += 4;
                    break;
                case 'B':
                    sum += 3;
                    break;
                case 'C':
                    sum += 2;
                    break;
                case 'D':
                    sum += 1;
                    break;
                
            }
        }

        return sum / (float) Gradings.Count; 
    }
}