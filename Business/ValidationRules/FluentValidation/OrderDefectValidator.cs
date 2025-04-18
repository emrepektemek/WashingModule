using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderDefectValidator : AbstractValidator<OrderDefect>
    {

        public OrderDefectValidator()
        {
            RuleFor(od => od.OrderId).GreaterThan(0).WithMessage("Order is required");

            RuleFor(od => od.DefectId).GreaterThan(0).WithMessage("Defect is required");

            RuleFor(od => od.RowNumber).GreaterThan(0).WithMessage("Row is required");

            RuleFor(od => od.Decision).NotEmpty().WithMessage("Decision is required");

        }
    }
}
