using FluentValidation;
using SquadManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email)
                .NotNull()
                .WithMessage("Email can't be empty")
                .EmailAddress()
                .WithMessage("Email not valid");
            //RuleFor(user => user.Username).NotNull();
            RuleFor(user => user.Password).NotNull().WithMessage("Password can't be empty");
        }
    }
}
