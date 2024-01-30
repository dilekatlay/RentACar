namespace Business
{
    public class AddCorporateCustomerResponse
    {
        public AddCorporateCustomerResponse(int ıd, string companyName, int taxNo, DateTime createdAt, int customersId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            CreatedAt = createdAt;
            CustomersId = customersId;
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public int CustomersId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}