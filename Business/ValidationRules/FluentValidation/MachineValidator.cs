using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MachineValidator : AbstractValidator<Machine>
    {
        public MachineValidator()
        {
            RuleFor(m => m.MachineName).NotEmpty().WithMessage("Machine name is required.");

            RuleFor(m => m.MachineType).NotEmpty().WithMessage("Machine type is required.");
        }
    }
}
