namespace Business
{
    public class DeleteCustomersResponse
    {
        public DeleteCustomersResponse(int ıd, int userId, DateTime deletedAt)
        {
            Id = ıd;
            UserId = userId;
            DeletedAt = deletedAt;
        }
 
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}