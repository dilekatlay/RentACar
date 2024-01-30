using Core.Entities;

namespace Entities.Concrete
{
    public class Transmission : Entity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Transmission()
        {

        }
        public Transmission(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}