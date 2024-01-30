using Business.Request.Fuel;
using Business.Requests.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.Fuel
{
    public class AddFuelRequestValidator : AbstractValidator<AddFuelRequest>
    {
        public AddFuelRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(50);
           

            
        }

       
    }
  
}
