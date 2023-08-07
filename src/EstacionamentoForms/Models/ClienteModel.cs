using EstacionamentoForms.Configurations.Attributes;
using System;

namespace EstacionamentoForms.Models
{
    [Identifier("Id")]
    public class ClienteModel
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string NumeroCelular { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}