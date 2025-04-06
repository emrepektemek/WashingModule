using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WashValidator: AbstractValidator<Wash>
    {

        public WashValidator()
        {

            RuleFor(w => w.OrderId).NotEmpty().WithMessage("Order Id is required.");

            RuleFor(w => w.WashingTypeId).GreaterThan(0).WithMessage("Washing type is required");

            RuleFor(w => w.Shift).NotEmpty().WithMessage("Shift is required.");        
        }
    }
}
