namespace Business
{
    public class DeleteUsersResponse
    {
        public DeleteUsersResponse(int ıd, string firstName, string lastName, string email, string password, DateTime deletedAt)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            DeletedAt = deletedAt;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}