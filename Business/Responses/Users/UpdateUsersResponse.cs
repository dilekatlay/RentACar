namespace Business
{
    public class UpdateUsersResponse
    {
        public UpdateUsersResponse(int ıd, string firstName, string lastName, string email, string password, DateTime updatedAt)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            UpdatedAt = updatedAt;
        }
   

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}