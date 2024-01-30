using Business.Requests.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.Customers
{
    public class AddCustomersRequestValidator : AbstractValidator<AddCustomersRequest>
    {
        public AddCustomersRequestValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().GreaterThan(0);
            
        }

      
    }
    
}
