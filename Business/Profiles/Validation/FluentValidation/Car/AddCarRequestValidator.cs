using Business.Request.Car;
using Business.Requests.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Validation.FluentValidation.Car
{
    public class AddCarRequestValidator : AbstractValidator<AddCarRequest>
    {
        public AddCarRequestValidator()
        {
            RuleFor(x => x.ColorId).NotEmpty().GreaterThan(0);
            RuleFor(x => x.ModelId).NotEmpty().GreaterThan(0);
            RuleFor(x => x.CarState).NotEmpty();
            RuleFor(x => x.Kilometer).NotEmpty();
            RuleFor(x => x.Plate).NotEmpty().MaximumLength(7);

            //RuleFor(model=> model.Name).Must(StartsWithA);
        }

        //private bool StartsWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
    
}
