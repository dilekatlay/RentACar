using Business.Request.Transmission;
using Business.Requests.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.Transmission
{
    public class AddTransmissionRequestValidator : AbstractValidator<AddTransmissionRequest>
    {
        public AddTransmissionRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(50);
            
        }

        
    }
    
}
