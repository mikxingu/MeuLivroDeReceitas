using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.User.Create
{
    public class CreateUserUseCase
    {
        public ResponseCreateUserJson Execute(RequestCreateUserJson request)
        {
            // Validar a request.

            // Mapear a request para a entidade de domínio.

            // Criptografar a senha do usuário.

            // Salvar a entidade no repositório/banco de dados.

            return new ResponseCreateUserJson
            {
                Name = request.Name
            };
        }

        private void Validate(RequestCreateUserJson request)
        {
            var validator = new CreateUserValidator();

            var result = validator.Validate(request);
            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(e => e.ErrorMessage);
                throw new Exception();

            }


        }
    }
    
}
