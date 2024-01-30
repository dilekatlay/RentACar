namespace Business
{
    public class UpdateCustomersRequest
    {
        public UpdateCustomersRequest(int ıd, int userId)
        {
            Id = ıd;
            UserId = userId;
        }

        public int Id { get; set; }
        public int UserId { get; set; }

    }
}