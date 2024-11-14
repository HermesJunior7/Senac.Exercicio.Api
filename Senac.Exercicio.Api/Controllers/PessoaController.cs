using Microsoft.AspNetCore.Mvc;
using Senac.Exercicio.Domain.DTO;
using Senac.Exercicio.Domain.Entities;
using Senac.Exercicio.Service;


namespace Senac.Exercicio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController
    {
        [HttpGet, Route("cpf")]
        public List<PessoaEntity> ObterPessoas(String cpf)
            => new PessoaService().ObterPessoas(cpf);

        [HttpGet, Route("nome")]
        public List<PessoaEntity> ObterPorNome(String nome)
            => new PessoaService().ObterPessoasPorNome(nome);

        [HttpGet, Route("all")]
        public List<PessoaEntity> ObterPessoas()
            => new PessoaService().ObterPessoas();

        [HttpPost]
        public bool GravarPessoa(PessoaInputModel input)
            => new PessoaService().GravarPessoa(input);

        [HttpPut]
        public bool AlterarPessoa(AlterarPessoaInputModel input)
            => new PessoaService().GravarPessoa(input);
        [HttpDelete]
        public bool EcluirPessoa(int Id)
            => new PessoaService().ExcluirPessoa(Id);
    }
}
