﻿namespace Senac.Exercicio.Domain.DTO
{
    public class EnderecoInputModel
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public string Logradouro { get; set; }
        public string Numero {  get; set; }
        public string Complemento {  get; set; }
        public string Bairro { get; set; }

    }
}
