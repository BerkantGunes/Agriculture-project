using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Person Name cannot be null!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title cannot be null!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image URL cannot be null!");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("You can type Max 50 Characters!");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("You can type Min 5 Characters!");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("You can type Max 50 Characters!");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("You can type Min 3 Characters!");
        }
    }
}
