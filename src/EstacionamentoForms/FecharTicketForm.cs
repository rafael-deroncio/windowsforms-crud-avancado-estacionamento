using EstacionamentoForms.Extensions;
using EstacionamentoForms.Models;
using EstacionamentoForms.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    public partial class FecharTicketForm : Form
    {
        private bool _pesquisaAtiva = false;

        #region Singleton
        private static FecharTicketForm instance;
        public static FecharTicketForm GetInstance()
        {
            if (instance == null)
                instance = new FecharTicketForm();

            return instance;
        }
        #endregion

        public FecharTicketForm()
        {
            InitializeComponent();
            DataGridViewTickets_load();

            this.RdoIdTicket.Checked = true;
            this.RdoIdCliente.Checked = false;
            this.RdoCpf.Checked = false;
            this.RdoIdVeiculo.Checked = false;
            this.RdoPlaca.Checked = false;
        }

        private void BtnFecharTicket_Click(object sender, EventArgs e)
        {
            int idTicket = int.Parse(this.TxtBoxId.Text);
            TicketModel ticket = TicketService.GetInstance().RecuperarTodos().Find(x => x.Id == idTicket);

            string titulo = "Fechar Ticket";
            string mensagem = 
                $"Deseja Fechar o tiket {idTicket}?"  + Environment.NewLine 
                + $"Valor do ticket: R$ {ticket.ValorTicket:F2}";

            DialogResult result = MessageBox.Show(mensagem, titulo, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                FecharTicket();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdoCpf_Click(object sender, EventArgs e)
        {
            this.RdoIdTicket.Checked = false;
            this.RdoIdCliente.Checked = false;
            this.RdoCpf.Checked = true;
            this.RdoIdVeiculo.Checked = false;
            this.RdoPlaca.Checked = false;
        }

        private void RdoIdCliente_Click(object sender, EventArgs e)
        {
            this.RdoIdTicket.Checked = false;
            this.RdoIdCliente.Checked = true;
            this.RdoCpf.Checked = false;
            this.RdoIdVeiculo.Checked = false;
            this.RdoPlaca.Checked = false;
        }

        private void RdoPlaca_Click(object sender, EventArgs e)
        {
            this.RdoIdTicket.Checked = false;
            this.RdoIdCliente.Checked = false;
            this.RdoCpf.Checked = false;
            this.RdoIdVeiculo.Checked = false;
            this.RdoPlaca.Checked = true;
        }

        private void RdoTicket_Click(object sender, EventArgs e)
        {
            this.RdoIdTicket.Checked = true;
            this.RdoIdCliente.Checked = false;
            this.RdoCpf.Checked = false;
            this.RdoIdVeiculo.Checked = false;
            this.RdoPlaca.Checked = false;
        }

        private void MkdTxtPesquisa_Click(object sender, EventArgs e)
        {
            if (this.RdoCpf.Checked)
                this.MkdTxtPesquisa.Mask = "000.000.000-00";

            if (this.RdoIdCliente.Checked || this.RdoIdVeiculo.Checked || this.RdoIdTicket.Checked)
                this.MkdTxtPesquisa.Mask = "0000";

            if (this.RdoPlaca.Checked)
                this.MkdTxtPesquisa.Mask = "AAAAAAA";
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (_pesquisaAtiva)
            {
                ActionLimpar();
                DataGridViewTickets_load();
                return;
            }

            if (this.MkdTxtPesquisa.Text != null)
            {

                // Pesquisa pelo Cliente
                if (this.RdoCpf.Checked || this.RdoIdCliente.Checked)
                    PesquisaPorCliente();

                // Pesquisa pelo Veículo
                if (this.RdoPlaca.Checked || this.RdoIdVeiculo.Checked)
                    PesquisarPorVeiculo();

                // Pesquisar pelo Ticket
                if (this.RdoIdTicket.Checked)
                    PesquisarPorTicket();
            }
            else
            {
                MessageBox.Show("Por favor, informar o CPF ou ID para a consulta.");
            }
        }

        private ClienteModel PesquisaPorCliente()
        {
            ClienteModel cliente;

            if (this.RdoCpf.Checked)
            {
                cliente = ClienteService.GetInstance().RecuperarTodos()
                    .FirstOrDefault(x => x.Cpf == this.MkdTxtPesquisa.Text.Replace(",", "."));
            }
            else
            {
                int id = 0;
                int.TryParse(this.MkdTxtPesquisa.Text, out id);
                cliente = ClienteService.GetInstance().RecuperarTodos()
                    .FirstOrDefault(x => x.Id == id);
            }

            if (cliente is null)
            {
                MessageBox.Show(string.Format("Cliente não encontrado por {0}: {1}",
                    (this.RdoCpf.Checked ? "CPF" : "ID"), (this.RdoCpf.Checked ? this.MkdTxtPesquisa.Text.ToCpfNormalized() : $"{int.Parse(this.MkdTxtPesquisa.Text):D4}")));
            }
            else
            {
                ActionPesquisar();
                List<TicketModel> tickets = TicketService.GetInstance().RecuperarTodos().FindAll(x => x.IdCliente == cliente.Id && x.Ativo);
                
                if (tickets.Count > 0)
                    DataGridViewTickets_load(tickets);
                else
                    MessageBox.Show($"Cliente {cliente.Id:D4} | {cliente.NomeCompleto} não possui ticket aberto.");
            }
            
            return cliente;
        }

        private VeiculoModel PesquisarPorVeiculo()
        {
            VeiculoModel veiculo;

            if (this.RdoPlaca.Checked)
            {
                veiculo = VeiculoService.GetInstance().RecuperarTodos()
                    .FirstOrDefault(x => x.Placa == this.MkdTxtPesquisa.Text);
            }
            else
            {
                int id = 0;
                int.TryParse(this.MkdTxtPesquisa.Text, out id);
                veiculo = VeiculoService.GetInstance().RecuperarTodos()
                    .FirstOrDefault(x => x.Id == id);
            }

            if (veiculo is null)
            {
                MessageBox.Show(string.Format("Veículo não encontrado por {0}: {1}",
                    (this.RdoCpf.Checked ? "Placa" : "ID"), (this.RdoPlaca.Checked ? this.MkdTxtPesquisa.Text : $"{int.Parse(this.MkdTxtPesquisa.Text):D4}")));
            }
            else
            {
                ActionPesquisar();
                List<TicketModel> tickets = TicketService.GetInstance().RecuperarTodos().FindAll(x => x.IdVeiculo == veiculo.Id && x.Ativo);

                if (tickets.Count > 0)
                    DataGridViewTickets_load(tickets);
                else
                    MessageBox.Show($"Cliente {veiculo.IdCliente:D4} | {veiculo.NomeCliente} não possui ticket aberto para o veículo {veiculo.Fabricante} {veiculo.Modelo}, placa {veiculo.Placa}.");
            }

            return veiculo;
        }

        private TicketModel PesquisarPorTicket()
        {
            int id = 0;
            int.TryParse(this.MkdTxtPesquisa.Text, out id);

            TicketModel ticket = TicketService.GetInstance().RecuperarTodos().Find(x => x.Id == id && x.Ativo);

            if (ticket is null)
            {
                MessageBox.Show($"Ticket não encontrado por ID: {id:D4}");
            }
            else
            {
                ActionPesquisar();
                List<TicketModel> tickets = new List<TicketModel>() { ticket };
                DataGridViewTickets_load(tickets);
            }

            return ticket;
        }

        private TicketModel FecharTicket()
        {
            int idTicket = int.Parse(this.LblOcultoIdTickt.Text);
            TicketModel ticket = TicketService.GetInstance().RecuperarTodos().Find(x => x.Id == idTicket);

            if (TicketService.GetInstance().FecharTicket(ticket))
            {
                MessageBox.Show("Ticket Fechado com Sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Não foi possível Fechar o tícket. Contate o suporte.");

            return ticket;
        }

        private void ActionPesquisar()
            {
                _pesquisaAtiva = true;
                this.BtnAction.ForeColor = Color.DarkGoldenrod;
                this.BtnAction.Text = "Limpar";
            }

        private void ActionLimpar()
        {
            _pesquisaAtiva = false;
            this.MkdTxtPesquisa.Text = string.Empty;
            this.BtnAction.ForeColor = Color.Blue;
            this.BtnAction.Text = "Pesquisar";
            this.TxtBoxAtivo.Text = string.Empty;
            this.TxtBoxCliente.Text = string.Empty;
            this.TxtBoxDescricao.Text = string.Empty;
            this.TxtBoxEntrada.Text = string.Empty;
            this.TxtBoxSaida.Text = string.Empty;
            this.TxtBoxTempoEstacionado.Text = string.Empty;
            this.TxtBoxValorTicket.Text = string.Empty;
        }

        private void DataGridViewTickets_load(List<TicketModel> tickets = null)
        {
            DataGridViewTickets.Columns.Clear();
            DataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DataGridViewTickets.AutoGenerateColumns = false;
            DataGridViewTickets.AllowUserToResizeColumns = true;
            DataGridViewTickets.ScrollBars = ScrollBars.Both;
            DataGridViewTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewColumnHeaderCell headerCell = new DataGridViewColumnHeaderCell { Style = { WrapMode = DataGridViewTriState.False } };

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ID Ticket",
                DataPropertyName = "Id",
                HeaderText = "Id",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ID Cliente",
                DataPropertyName = "IdCliente",
                HeaderText = "IdCliente",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cliente",
                DataPropertyName = "NomeCliente",
                HeaderText = "NomeCliente",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ID Veiculo",
                DataPropertyName = "IdVeiculo",
                HeaderText = "IdVeiculo",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Descrição Veículo",
                DataPropertyName = "DescricaoVeiculo",
                HeaderText = "DescricaoVeiculo",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                DataPropertyName = "Ativo",
                HeaderText = "Ativo",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Valor Por Minuto",
                DataPropertyName = "ValorPorMinuto",
                HeaderText = "ValorPorMinuto",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Entrada",
                DataPropertyName = "Entrada",
                HeaderText = "Entrada",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Saída",
                DataPropertyName = "Saida",
                HeaderText = "Saída",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Tempo Estacionado",
                DataPropertyName = "TempoEstacionado",
                HeaderText = "TempoEstacionado",
                HeaderCell = headerCell
            });

            DataGridViewTickets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Valor Ticket",
                DataPropertyName = "ValorTicket",
                HeaderText = "ValorTicket",
                HeaderCell = headerCell
            });

            if (tickets is null || tickets.Count == 0)
            {
                DataGridViewTickets.DataSource = TicketService.GetInstance().RecuperarTodos()
                    .Where(ticket => ticket.Ativo)
                    .OrderByDescending(ticket => ticket.Entrada)
                    .ToList();
            }
            else 
            {
                DataGridViewTickets.DataSource = tickets;
            }

        }

        private void DataGridViewTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.BtnFecharTicket.Enabled = true;
                DataGridViewRow row = DataGridViewTickets.SelectedRows[0];

                int idTicket = int.Parse(row.Cells["ID Ticket"].Value.ToString());
                TicketModel ticket = TicketService.GetInstance().RecuperarTodos().Find(x => x.Id == idTicket);
                this.LblOcultoIdTickt.Text = ticket.Id.ToString();

                this.TxtBoxId.Text = $"{ticket.Id:D4}"; 
                this.TxtBoxAtivo.Text = ticket.Ativo ? "Aberto" : "Fechado"; 
                this.TxtBoxCliente.Text = $"ID: {ticket.IdCliente:D4} | {ticket.NomeCliente}";
                this.TxtBoxDescricao.Text = ticket.DescricaoVeiculo;
                this.TxtBoxEntrada.Text = ticket.Entrada.ToString("dd/MM/yyyy HH:mm:ss, dddd");
                this.TxtBoxSaida.Text = ticket.Saida.HasValue ? ticket.Saida.Value.ToString("dd/MM/yyyy, dddd") : string.Empty; 
                this.TxtBoxTempoEstacionado.Text = ticket.TempoEstacionado;
                this.TxtBoxValorTicket.Text = ticket.ValorTicket;
            }
        }
    }
}
