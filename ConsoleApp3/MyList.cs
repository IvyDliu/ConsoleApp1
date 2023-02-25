namespace ConsoleApp3;

public class MyList<T>
{ 
    List<T> Elements = new List<T>();

    public void Add(T element)
    {
        Elements.Add(element);
    }

    public T Remove(int index)
    {
        
        if (index >= 0 && index < Elements.Count)
        {
            T element = Elements[index];
            Elements.RemoveAt(index);
            return element;
        }

        throw new IndexOutOfRangeException();
    }

    public bool Contains(T element)
    {
        return Elements.Contains(element);
    }

    public void Clear()
    {
        Elements = new List<T>();
    }

    public void InsertAt(T element, int index)
    {
        Elements.Insert(index , element);
    }

    public void DeleteAt(int index)
    {
        Elements.RemoveAt(index);
    }

    public T Find(int index)
    {
        if (index >= 0 && index < Elements.Count)
        {
            T element = Elements[index];
            return element;
        }

        throw new IndexOutOfRangeException();
    }
}