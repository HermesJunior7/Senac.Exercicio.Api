using Senac.Exercicio.Domain.Entities;
using Senac.Exercicio.Infraestrutura.Data;

namespace Senac.Exercicio.Infraestrutura.Repository
{
    public class EnderecoRepository
    {
        public bool Gravar(EnderecoEntity obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(@"insert into Endereco (IdPessoa, Logradouro, Numero, Complemento, Bairro) 
                values (@IdPessoa, @Logradouro, @Numero, @Complemento, @Bairro)",
                "@idPessoa", obj.IdPessoa, "@logradouro", obj.Logradouro, "@numero", obj.Numero, "@complemento", obj.Complemento, "@bairro", obj.Bairro);
            }
        }
    }
}
