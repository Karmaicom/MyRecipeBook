using MyRecipeBook.Application.UseCases.User.Register.Validators;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUseCase
    {
        private readonly RegisterUserRequestValidator _validator;

        public RegisterUseCase(RegisterUserRequestValidator validator)
        {
           _validator  = validator;
        }

        public UserRegisterResponse Execute(UserRegisterRequest request)
        {
            // Validar a request
            ValidateRequest(request);

            // Mapear a request para a entidade de usuário

            // Criptografar a senha

            // Salvar o usuário no banco de dados

            return new UserRegisterResponse
            {
                Name = request.Name
            };
        }

        private void ValidateRequest(UserRegisterRequest request)
        {
            var validationResult = _validator.Validate(request);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(error => error.ErrorMessage).ToList();

                throw new ArgumentException(string.Join(", ", errors));
            }
        }
    }
}
