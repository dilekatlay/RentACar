namespace Business
{
    public class DeleteUsersRequest
    {
        public DeleteUsersRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}