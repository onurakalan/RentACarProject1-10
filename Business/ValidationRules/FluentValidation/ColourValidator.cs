using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColourValidator:AbstractValidator<Colour>
    {
        public ColourValidator()
        {
            RuleFor(co => co.ColourName).NotEmpty();
            RuleFor(co => co.ColourName).MinimumLength(2);
        }
    }
}
