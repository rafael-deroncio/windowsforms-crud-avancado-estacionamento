using EstacionamentoForms.Configurations.Attributes;
using System;

namespace EstacionamentoForms.Models
{
    [Identifier("Id")]
    public class MovimentacaoModel
    {
        public int Id { get; set; }
        public string ValorPorMinuto { get; set; }
        public string TotalVagasDisponiveis { get; set; }
        public string TotalVeiculosEstacionados { get; set; }
        public bool TemVagaDisponivel { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;    
    }
}
