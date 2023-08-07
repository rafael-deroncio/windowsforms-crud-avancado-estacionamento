using EstacionamentoForms.Configurations.Attributes;
using System;

namespace EstacionamentoForms.Models
{
    [Identifier("Id")]
    public class TicketModel
    {
        // Ticket
        [IdentifierProperty("Id")]
        public int Id { get; set; }
        public bool Ativo { get; set; } = false;
        public string ValorPorMinuto { get; set; }
        public DateTime Entrada { get; set; } = DateTime.Now;
        public Nullable<DateTime> Saida { get; set; }

        // Detalhes Ticket
        public string TempoEstacionado { get; set; }
        public string ValorTicket { get; set; }

        // Cliente
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }

        // Veiculo
        public Nullable<int> IdVeiculo { get; set; }
        public string DescricaoVeiculo { get; set; }
    }
}