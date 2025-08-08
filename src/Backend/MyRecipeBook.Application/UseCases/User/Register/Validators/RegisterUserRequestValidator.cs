using FluentValidation;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Exceptions;

namespace MyRecipeBook.Application.UseCases.User.Register.Validators
{
    public class RegisterUserRequestValidator : AbstractValidator<UserRegisterRequest>
    {

        public RegisterUserRequestValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage(ResourceMessagesException.NAME_EMPTY);

            RuleFor(x => x.Email).NotEmpty().WithMessage(ResourceMessagesException.EMAIL_EMPTY);
            RuleFor(x => x.Email).EmailAddress().WithMessage(ResourceMessagesException.EMAIL_INVALID);

            RuleFor(x => x.Password).NotEmpty().WithMessage(ResourceMessagesException.PASSWORD_EMPTY);
            RuleFor(x => x.Password.Length).GreaterThanOrEqualTo(6)
                .WithMessage(ResourceMessagesException.PASSWORD_INVALID);
        }

    }
}
