using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.CorporateCustomer
{
    public class CorporateCustomerListItemDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public int CustomersId { get; set; }
    }
}
