using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Description 1 can not be null!");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Description 2 can not be null!");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Description 3 can not be null!");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Description 4 can not be null!");
            RuleFor(x => x.Mapinfo).NotEmpty().WithMessage("Map info can not be null!");
            RuleFor(x => x.Description1).MaximumLength(25).WithMessage("You can type Maximum 25 characters");
            RuleFor(x => x.Description2).MaximumLength(25).WithMessage("You can type Maximum 25 characters");
            RuleFor(x => x.Description3).MaximumLength(25).WithMessage("You can type Maximum 25 characters");
            RuleFor(x => x.Description4).MaximumLength(25).WithMessage("You can type Maximum 25 characters");
        }
    }
}
