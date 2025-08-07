using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost("/register")]
        [ProducesResponseType(type: typeof(UserRegisterResponse), statusCode: StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] UserRegisterRequest request)
        {
            return Created();
        }

    }
}
