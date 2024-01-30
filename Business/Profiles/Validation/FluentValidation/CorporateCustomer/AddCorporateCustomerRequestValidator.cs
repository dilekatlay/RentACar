using Business.Requests.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.CorporateCustomer
{
    public class AddCorporateCustomerRequestValidator : AbstractValidator<AddCorporateCustomerRequest>
    {
        public AddCorporateCustomerRequestValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().MinimumLength(2).MaximumLength(150);
            RuleFor(x => x.CustomersId).NotEmpty();
            RuleFor(x => x.TaxNo).NotEmpty();


            //RuleFor(model=> model.Name).Must(StartsWithA);
        }

        //private bool StartsWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
    
}
