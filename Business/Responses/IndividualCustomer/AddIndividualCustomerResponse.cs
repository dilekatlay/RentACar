namespace Business
{
    public class AddIndividualCustomerResponse
    {
        public AddIndividualCustomerResponse(int ıd, string firstName, string lastName, string nationalIdentity, DateTime createdAt, int customersId)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            CreatedAt = createdAt;
            CustomersId = customersId;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CustomersId { get; set; }
    }
}