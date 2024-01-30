using Business.Requests.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.IndividualCustomer
{
    public class AddIndividualCustomerRequestValidator : AbstractValidator<AddIndividualCustomerRequest>
    {
        public AddIndividualCustomerRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(2).MaximumLength(60);
            RuleFor(x => x.NationalIdentity).NotEmpty().Must(x => x.Length == 11);
            RuleFor(x => x.CustomersId).NotEmpty();

        }

      
    }
    
}
