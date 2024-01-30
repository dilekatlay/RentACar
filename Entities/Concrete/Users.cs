using Core.Entities;

namespace Entities.Concrete
{
    public class Users : Entity<int>
    {
        public Users(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        public Users()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Customers Customers { get; set; }
    }
}