using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Application.UseCases.User.Create;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreateUserJson), StatusCodes.Status201Created)]
        public IActionResult CreateUser(RequestCreateUserJson request)
        {
            var useCase = new CreateUserUseCase();

            var result = useCase.Execute(request);

            return Created(string.Empty, result);
        }
    }
}
