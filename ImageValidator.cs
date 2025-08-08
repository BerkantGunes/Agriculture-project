using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Image title can not be null!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Image description can not be null!");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image URL can not be null!");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("You can type Maximum 20 characters!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("You can type Minimum 5 characters!");
            RuleFor(x => x.Description).MaximumLength(80).WithMessage("You can type Maximum 80 characters!");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("You can type Minimum 10 characters!");
        }
    }
}
