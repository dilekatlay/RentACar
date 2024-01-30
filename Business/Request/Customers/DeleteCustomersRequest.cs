namespace Business
{
    public class DeleteCustomersRequest
    {
        public DeleteCustomersRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}