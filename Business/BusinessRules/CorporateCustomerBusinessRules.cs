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
    public class CorporateCustomerBusinessRules
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;
        public CorporateCustomerBusinessRules(ICorporateCustomerDal corporateCustomerDal)
        {
            _corporateCustomerDal = corporateCustomerDal;
        }

        public void CheckIfCorporateCustomerExists(CorporateCustomer? corporateCustomer)
        {
            if (corporateCustomer is null)
                throw new NotFoundException("CorporateCustomer not found.");
        }

        //public void CheckIfCorporateCustomersTaxNo(CorporateCustomer? corporateCustomer)
        //{
        //    if(corporateCustomer.TaxNo < 10 || corporateCustomer.TaxNo > 10)
        //    {
        //        throw new NotFoundException("Tax number must be 10 digits.");
        //    }
        //}

    }
}
