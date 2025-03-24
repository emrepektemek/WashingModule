using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {

            RuleFor(o => o.PantId).GreaterThan(0).WithMessage("Pant model required");

            RuleFor(o => o.PantQuantity).GreaterThan(0).WithMessage("Pant quantity required");

        }
    }
}
