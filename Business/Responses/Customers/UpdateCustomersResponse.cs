namespace Business
{
    public class UpdateCustomersResponse
    {
        public UpdateCustomersResponse(int ıd, int userId, DateTime updatedAt)
        {
            Id = ıd;
            UserId = userId;
            UpdatedAt = updatedAt;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}