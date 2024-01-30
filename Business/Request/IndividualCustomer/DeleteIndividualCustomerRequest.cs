namespace Business
{
    public class DeleteIndividualCustomerRequest
    {
        public DeleteIndividualCustomerRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}