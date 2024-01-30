namespace Business
{
    public class DeleteCorporateCustomerResponse
    {
        public DeleteCorporateCustomerResponse(int ıd, string companyName, int taxNo, DateTime deletedAt, int customersId)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            DeletedAt = deletedAt;
            CustomersId = customersId;
        }


        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public DateTime DeletedAt { get; set; }
        public int CustomersId { get; set; }
    }
}