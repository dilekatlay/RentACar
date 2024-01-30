namespace Business
{
    public class UpdateIndividualCustomerResponse
    {
        public UpdateIndividualCustomerResponse(int ıd, string firstName, string lastName, string nationalIdentity, DateTime updatedAt, int customersId)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            UpdatedAt = updatedAt;
            CustomersId = customersId;
        }
 

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CustomersId { get; set; }
    }
}