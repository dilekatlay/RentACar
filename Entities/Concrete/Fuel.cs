using Core.Entities;

namespace Entities.Concrete;

public class Fuel : Entity<int> // Yakıt 
{
    public int Id { get; set; }
    public string Name { get; set; } // Benzin, dizel, gaz, elektrik 

    public Fuel()
    {

    }
    public Fuel(int id, string name)
    {
        Id = id;
        Name = name;
    }
}