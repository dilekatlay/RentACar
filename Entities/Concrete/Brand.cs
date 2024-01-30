using Core.Entities;

namespace Entities.Concrete;

public class Brand : Entity<int> //Marka 
{
    public string Name { get; set; }

    public Brand()
    {
    }

    public Brand(string name)
    {
        Name = name;
    }
}