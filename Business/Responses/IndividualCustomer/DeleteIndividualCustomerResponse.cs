namespace Business
{
    public class DeleteIndividualCustomerResponse
    {
        public DeleteIndividualCustomerResponse(int ıd, string firstName, string lastName, string nationalIdentity, DateTime deletedAt, int customersId)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            DeletedAt = deletedAt;
            CustomersId = customersId;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime DeletedAt { get; set; }
        public int CustomersId { get; set; }
    }
}