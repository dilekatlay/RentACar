namespace Business
{
    public class GetIndividualCustomerByIdResponse
    {
        public GetIndividualCustomerByIdResponse(int ıd, string firstName, string lastName, string nationalIDentity, int customersId)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIDentity = nationalIDentity;
            CustomersId = customersId;
        }
 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIDentity { get; set; }
        public int CustomersId { get; set; }
    }
}