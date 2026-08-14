using FluentValidation;
using HYBRIDAPP.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace HYBRIDAPP.Shared.Validators;

public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .Matches(@"^[0-9+\-\s]{7,15}$")
            .WithMessage("Enter a valid phone number.");

        RuleFor(x => x.Gender)
            .NotEmpty();
    }
}
