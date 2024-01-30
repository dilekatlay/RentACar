namespace Business
{
    public class UpdateIndividualCustomerRequest
    {
        public UpdateIndividualCustomerRequest(int ıd, string firstName, string lastName, string nationalIdentity, int customersId)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            CustomersId = customersId;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public int CustomersId { get; set; }
    }
}