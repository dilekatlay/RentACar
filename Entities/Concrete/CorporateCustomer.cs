using Core.Entities;

namespace Entities.Concrete
{
    public class CorporateCustomer : Entity<int>
    {
        public CorporateCustomer(int id, string companyName, int taxNo, int customersId)
        {
            Id = id;
            CompanyName = companyName;
            TaxNo = taxNo;
            CustomersId = customersId;
        }
        public CorporateCustomer()
        {

        }
        public int Id { get; set; }
        public int CustomersId { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public Customers Customers { get; set; } 
    }
}