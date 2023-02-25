namespace ConsoleApp3;

public interface IRepository<T> where T : class
{
    int Add(T item);
    int Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);    
}