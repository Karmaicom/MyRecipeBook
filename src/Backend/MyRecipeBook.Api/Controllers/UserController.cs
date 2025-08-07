using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Application.UseCases.User.Register;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly RegisterUseCase _registerUseCase;

        public UserController(RegisterUseCase registerUseCase)
        {
            _registerUseCase = registerUseCase;
        }

        [HttpPost("/register")]
        [ProducesResponseType(type: typeof(UserRegisterResponse), statusCode: StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] UserRegisterRequest request)
        {
            var response = _registerUseCase.Execute(request);

            return StatusCode(StatusCodes.Status201Created, response);
        }

    }
}
