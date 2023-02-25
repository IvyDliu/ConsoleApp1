namespace ConsoleApp3;

public class GenericRepository : IRepository<Entity>
{

    private List<Entity> entities = new List<Entity>();
    
    public int Add(Entity item)
    {
        if (GetById(item.Id) == null)
        {
            entities.Add(item);
            return 1;
        }
        return 0;
    }
    
    public int Remove(Entity item)
    {
        Entity c = GetById(item.Id);
        if (c != null)
        {
            entities.Remove(c);
            return 1;
        }

        return 0;
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Entity> GetAll()
    {
        return entities;
    }

    public Entity GetById(int id)
    {
        foreach (var item in entities)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
    
    
}