using Business.Request.Brand;
using Business.Requests.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.Brand
{
    internal class AddBrandRequestValidator : AbstractValidator<AddBrandRequest>
    {
        public AddBrandRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(50);


            //RuleFor(model=> model.Name).Must(StartsWithA);
        }

    }
}
