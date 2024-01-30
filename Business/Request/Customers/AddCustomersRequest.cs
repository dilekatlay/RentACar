namespace Business
{
    public class AddCustomersRequest
    {
        public AddCustomersRequest(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; set; }

    }
}