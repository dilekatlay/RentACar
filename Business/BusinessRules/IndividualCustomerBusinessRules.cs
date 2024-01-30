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
    public class IndividualCustomerBusinessRules
    {
        private readonly IIndividualCustomerDal _individualCustomerDal;
        public IndividualCustomerBusinessRules(IIndividualCustomerDal individualCustomerDal)
        {
            _individualCustomerDal = individualCustomerDal;
        }

        public void CheckIfIndividualCustomerExists(IndividualCustomer? individualCustomer)
        {
            if (individualCustomer is null)
                throw new NotFoundException("IndividualCustomer not found.");
        }

        
    }
}
