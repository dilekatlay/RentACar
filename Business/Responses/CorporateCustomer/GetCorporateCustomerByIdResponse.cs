namespace Business
{
    public class GetCorporateCustomerByIdResponse
    {
        public GetCorporateCustomerByIdResponse(int ıd, string companyName, int taxNo, int customersId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            CustomersId = customersId;
        }
  
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public int CustomersId { get; set; }
    }
}