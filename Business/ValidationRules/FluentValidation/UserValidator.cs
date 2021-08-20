using Core.Entities.Concrete;
using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).MinimumLength(2);
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u => u.Email).MinimumLength(5);
            RuleFor(u => u.Email).Must(contain).WithMessage("EMail adresi yanlış.");
        }

        private bool contain(string arg)
        {
            return arg.Contains("@");
        }
    }
}
