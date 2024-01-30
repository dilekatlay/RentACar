namespace Business
{
    public class UpdateCorporateCustomerResponse
    {
        public UpdateCorporateCustomerResponse(int ıd, string companyName, int taxNo, DateTime updatedAt, int customersId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            UpdatedAt = updatedAt;
            CustomersId = customersId;
        }
  

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CustomersId { get; set; }
    }
}