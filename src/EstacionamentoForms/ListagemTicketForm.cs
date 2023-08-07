using EstacionamentoForms.Configurations.Enum;
using EstacionamentoForms.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    public partial class ListagemTicketForm : Form
    {
        #region Singleton
        private static ListagemTicketForm instance;
        public static ListagemTicketForm GetInstance(DriverTypeEnum driver)
        {
            if (instance == null)
                instance = new ListagemTicketForm();

            return instance;
        }
        #endregion

        public ListagemTicketForm()
        {
            InitializeComponent();
            DataGridViewTickets_load();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewTickets_load()
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

            DataGridViewTickets.DataSource = TicketService.GetInstance().RecuperarTodos()
                .OrderByDescending(ticket => ticket.Ativo)
                .ThenBy(ticket => ticket.Entrada)
                .ToList();
        }

        private void DataGridViewVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewTickets.SelectedRows[0];
                this.TxtBoxId.Text = int.Parse(row.Cells["ID Ticket"].Value.ToString()).ToString("D4");
                this.TxtBoxAtivo.Text = (bool)row.Cells["Status"].Value ? "Aberto" : "Fechado";
                this.TxtBoxCliente.Text = "ID: " + int.Parse(row.Cells["ID Cliente"].Value.ToString()).ToString("D4") + " | " + row.Cells["Cliente"].Value.ToString();
                this.TxtBoxDescricao.Text = row.Cells["Descrição Veículo"].Value.ToString();
                this.TxtBoxEntrada.Text = row.Cells["Entrada"].Value.ToString();
                this.TxtBoxSaida.Text = row.Cells["Saída"]?.Value?.ToString() ?? string.Empty;
                this.CmbBoxTempoEstacionado.Text = row.Cells["Tempo Estacionado"].Value.ToString();
                this.TxtBoxValorTicket.Text = row.Cells["Valor Ticket"].Value.ToString();
            }
        }
    }
}
