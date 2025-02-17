﻿using Senac.Exercicio.Domain.DTO;
using Senac.Exercicio.Domain.Entities;
using Senac.Exercicio.Infraestrutura.Repository;

namespace Senac.Exercicio.Service
{
    public class EnderecoService
    {
        public bool GravarEnderecoService(EnderecoInputModel endereco)
        {
            EnderecoEntity en = new EnderecoEntity(0, endereco.IdPessoa, endereco.Logradouro, endereco.Numero, endereco.Complemento, endereco.Bairro);
            return new EnderecoRepository().Gravar(en);
        }
    }
}
