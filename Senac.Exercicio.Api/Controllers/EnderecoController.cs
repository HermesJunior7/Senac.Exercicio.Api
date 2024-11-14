using Microsoft.AspNetCore.Mvc;
using Senac.Exercicio.Domain.DTO;
using Senac.Exercicio.Service;

namespace Senac.Exercicio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController
    {
        [HttpPost]
        public bool Gravar(EnderecoInputModel input)
            => new EnderecoService().GravarEnderecoService(input);
    }
}
