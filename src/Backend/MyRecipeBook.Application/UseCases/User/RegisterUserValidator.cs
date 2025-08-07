using FluentValidation;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Application.UseCases.User
{
    public class RegisterUserValidator : AbstractValidator<UserRegisterRequest>
    {

        public RegisterUserValidator()
        {

            RuleFor(x => x.Name).NotEmpty();

            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email é inválido!");

            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password.Length).GreaterThanOrEqualTo(6)
                .WithMessage("A senha deve ter pelo menos 6 caracteres.");
        }

    }
}
