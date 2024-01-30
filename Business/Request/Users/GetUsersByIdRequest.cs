namespace Business
{
    public class GetUsersByIdRequest
    {
        public int Id { get; set; }

        public GetUsersByIdRequest(int ıd)
        {
            Id = ıd;
        }
    }
}