using EstacionamentoForms.Models;
using EstacionamentoForms.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EstacionamentoForms.Services
{
    internal class ReceitaService : IBaseService<ReceitaModel>
    {
        #region Singleton
        private static ReceitaService instance;
        private ReceitaService() { }
        public static ReceitaService GetInstance()
        {
            if (instance == null)
                instance = new ReceitaService();
            return instance;
        }
        #endregion

        public bool Atualizar(ReceitaModel model)
        {
            GerarRelatorioReceita();
            return new bool();
        }

        public bool Cadastrar(ReceitaModel model)
        {
            GerarRelatorioReceita();
            return new bool();
        }

        public List<ReceitaModel> RecuperarTodos()
        {
            return GerarRelatorioReceita();
        }

        private List<ReceitaModel> GerarRelatorioReceita()
        {
            List<ReceitaModel> relatorioReceita = new List<ReceitaModel>();
            
            foreach (TicketModel ticket in TicketService.GetInstance().RecuperarTodos()) 
            {
                ReceitaModel registro = new ReceitaModel();
                registro = RecuperarInformacaoTickets(registro, ticket);
                registro = RecuperarInformacaoCleintes(registro, ticket);
                registro = RecuperarInformacaoVeiculos(registro, ticket);

                relatorioReceita.Add(registro);
            }

            return relatorioReceita;
        }

        private ReceitaModel RecuperarInformacaoVeiculos(ReceitaModel registro, TicketModel ticket)
        {
            // Ticket
            registro.TicketId = ticket.Id;
            registro.TicketAtivo = ticket.Ativo ? "Aberto" : "Fechado";
            registro.TicketValorPorMinuto = ticket.ValorPorMinuto;
            registro.TicketEntrada = ticket.Entrada;
            registro.TicketSaida = ticket.Saida.GetValueOrDefault();
            registro.TicketTempoEstacionado = ticket.TempoEstacionado;
            registro.TicketValorTicket = double.Parse(ticket.ValorTicket.Replace("R$ ", string.Empty).Trim());

            return registro;
        }

        private ReceitaModel RecuperarInformacaoCleintes(ReceitaModel registro, TicketModel ticket)
        {
            // Cliente
            ClienteModel cliente = ClienteService.GetInstance().RecuperarTodos().Find(x => x.Id == ticket.IdCliente);
            registro.ClienteId = cliente.Id;
            registro.ClienteNomeCompleto = cliente.NomeCompleto;
            registro.ClienteCpf = cliente.Cpf;
            registro.ClienteNumeroCelular = cliente.NumeroCelular;
            registro.ClienteDataCadastro = cliente.DataCadastro;

            return registro;
        }

        private ReceitaModel RecuperarInformacaoTickets(ReceitaModel registro, TicketModel ticket)
        {
            // Veiculo
            VeiculoModel veiculo = VeiculoService.GetInstance().RecuperarTodos().Find(x => x.Id == ticket.IdVeiculo);
            registro.VeiculoId = veiculo.Id;
            registro.VeiculoPlaca = veiculo.Placa;
            registro.VeiculoCor = veiculo.Cor;
            registro.VeiculoFabricante = veiculo.Fabricante;
            registro.VeiculoModelo = veiculo.Modelo;
            registro.VeiculoDataCadastro = veiculo.DataCadastro;

            return registro;
        }

        public string ExportarRelatorioCsv()
        {
            var caminhoArquivo = GerarCaminhoCompleto();

            // Cabeçalho do arquivo CSV
            var linhas = new List<string>();
            linhas.Add("Guid;ClienteId;ClienteNomeCompleto;ClienteCpf;ClienteNumeroCelular;ClienteDataCadastro;" +
                       "TicketId;TicketAtivo;TicketValorPorMinuto;TicketEntrada;TicketSaida;TicketTempoEstacionado;TicketValorTicket;" +
                       "VeiculoId;VeiculoPlaca;VeiculoCor;VeiculoFabricante;VeiculoModelo;VeiculoDataCadastro");

            // Adiciona uma linha para cada registro
            foreach (var registro in GerarRelatorioReceita())
            {
                var linha = $"{registro.Guid};" +
                            $"{registro.ClienteId};{registro.ClienteNomeCompleto};{registro.ClienteCpf};{registro.ClienteNumeroCelular};{registro.ClienteDataCadastro};" +
                            $"{registro.TicketId};{registro.TicketAtivo};{registro.TicketValorPorMinuto};{registro.TicketEntrada};{registro.TicketSaida};{registro.TicketTempoEstacionado};{registro.TicketValorTicket};" +
                            $"{registro.VeiculoId};{registro.VeiculoPlaca};{registro.VeiculoCor};{registro.VeiculoFabricante};{registro.VeiculoModelo};{registro.VeiculoDataCadastro}";
                
                linhas.Add(linha);
            }

            // Escreve as linhas no arquivo CSV
            using (var writer = new StreamWriter(caminhoArquivo, false, Encoding.UTF8))
            {
                foreach (var linha in linhas)
                {
                    writer.WriteLine(linha);
                }
            }

            return Path.GetFileName(caminhoArquivo);
        }

        private string GerarCaminhoCompleto()
        {
            string extensaoArquivo = ".csv";
            string nomeArquivo = "relatorio_receita_estacionamento_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + extensaoArquivo;
            string caminhoArquivo = Environment.CurrentDirectory.Replace("bin", string.Empty).Replace("Debug", string.Empty).Replace("\\\\", "\\Relatorios");

            if (!Directory.Exists(caminhoArquivo))
                Directory.CreateDirectory(caminhoArquivo);

            caminhoArquivo = Path.Combine(caminhoArquivo, nomeArquivo);

            return caminhoArquivo;
        }
    }
}
