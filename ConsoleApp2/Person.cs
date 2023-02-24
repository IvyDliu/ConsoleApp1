namespace ConsoleApp2;

public abstract class Person : IPersonService
{
   public DateTime Birthday;
   public string Name;
   public List<string>? Addresses;

   public Person(string birthday, string name)
   {
      Birthday = DateTime.Parse(birthday);
      Name = name;
   }

   public int CalculateAge()
   {
      return (DateTime.Today - Birthday).Days / 365;
   }

   public virtual decimal CalculateSalary()
   {
      return 120000;
   }

   public List<string> GetAddresses()
   {
      return Addresses;
   }

   public void AddAddress(string address)
   {
      Addresses.Add(address);
   }
}