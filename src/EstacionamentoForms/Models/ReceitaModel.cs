using EstacionamentoForms.Configurations.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoForms.Models
{
    [Identifier("Guid")]
    public class ReceitaModel
    {

        public Guid Guid { get; set; } = Guid.NewGuid();

        // Cliente
        public int ClienteId { get; set; }
        public string ClienteNomeCompleto { get; set; }
        public string ClienteCpf { get; set; }
        public string ClienteNumeroCelular { get; set; }
        public DateTime ClienteDataCadastro { get; set; }

        // Movimentacao
        public int MovimentacaoId { get; set; }
        public string MovimentacaoValorPorMinuto { get; set; }
        public string MovimentacaoTotalVagasDisponiveis { get; set; }
        public string MovimentacaoTotalVeiculosEstacionados { get; set; }
        public bool MovimentacaoTemVagaDisponivel { get; set; }
        public DateTime MovimentacaoDataCadastro { get; set; }

        // Ticket
        public int TicketId { get; set; }
        public string TicketAtivo { get; set; }
        public string TicketValorPorMinuto { get; set; }
        public DateTime TicketEntrada { get; set; }
        public Nullable<DateTime> TicketSaida { get; set; }
        public string TicketTempoEstacionado { get; set; }
        public double TicketValorTicket { get; set; }

        // Veiculo
        public int? VeiculoId { get; set; }
        public string VeiculoPlaca { get; set; }
        public string VeiculoCor { get; set; }
        public string VeiculoFabricante { get; set; }
        public string VeiculoModelo { get; set; }
        public DateTime VeiculoDataCadastro { get; set; }
    }

}
