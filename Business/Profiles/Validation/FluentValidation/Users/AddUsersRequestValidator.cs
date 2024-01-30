using Business.Requests.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.Users
{
    public class AddUsersRequestValidator : AbstractValidator<AddUsersRequest>
    {
        public AddUsersRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.Email).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(4).MaximumLength(12);
           
        }

       
    }
  
}
