namespace Business
{
    public class AddIndividualCustomerRequest
    {
        public AddIndividualCustomerRequest(string firstName, string lastName, string nationalIdentity, int customersId)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            CustomersId = customersId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public int CustomersId { get; set; }
    }
}