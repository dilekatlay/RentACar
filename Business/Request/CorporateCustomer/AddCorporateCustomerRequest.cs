using Entities.Concrete;

namespace Business
{
    public class AddCorporateCustomerRequest
    {
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public int CustomersId { get; set; }


        public AddCorporateCustomerRequest(string companyName, int taxNo, int customersId)
        {
            CompanyName = companyName;
            TaxNo = taxNo;
            CustomersId = customersId;
        }
    }

    
}