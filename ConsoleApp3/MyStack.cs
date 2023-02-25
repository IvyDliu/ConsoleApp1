namespace ConsoleApp3;

public class MyStack<T>
{
    private List<T> Elements = new List<T>();
    
    public int Count()
    {
        return Elements.Count;
    }

    public T Pop()
    {
        int last = Elements.Count - 1;
        T elment = Elements[last];
        Elements.RemoveAt(last);
        return elment;
    }

    public void Push(T element)
    {
        Elements.Add(element);
    }
}