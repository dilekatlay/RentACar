using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CustomersBusinessRules
    {
        private readonly ICustomersDal _customersDal;
        public CustomersBusinessRules(ICustomersDal customersDal)
        {
            _customersDal = customersDal;
        }

        public void CheckIfCustomersExists(Customers? customers)
        {
            if (customers is null)
                throw new NotFoundException("Customers not found.");
        }
    }
}
