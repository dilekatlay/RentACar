namespace Business
{
    public class AddCustomersResponse
    {
        public AddCustomersResponse(int ıd, int userId, DateTime createdAt)
        {
            Id = ıd;
            UserId = userId;
            CreatedAt = createdAt;
        }
  

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}