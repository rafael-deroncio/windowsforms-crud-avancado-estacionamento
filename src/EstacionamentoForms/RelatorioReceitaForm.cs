using EstacionamentoForms.Services;
using System;
using System.Windows.Forms;
using System.Linq;
using EstacionamentoForms.Configurations.Enum;

namespace EstacionamentoForms
{

    public partial class RelatorioReceitaForm : Form
    {
        public RelatorioReceitaForm()
        {
            InitializeComponent();
            DataGridViewReceita_load();

            this.LblValorReceitaTotal.Text = $"{ReceitaService.GetInstance().RecuperarTodos().Sum(receita => receita.TicketValorTicket):F2}";
        }

        private void DataGridViewReceita_load()
        {
            DataGridViewReceita.Columns.Clear();
            DataGridViewReceita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DataGridViewReceita.AutoGenerateColumns = false;
            DataGridViewReceita.AllowUserToResizeColumns = true;
            DataGridViewReceita.ScrollBars = ScrollBars.Both;
            DataGridViewReceita.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewColumnHeaderCell headerCell = new DataGridViewColumnHeaderCell { Style = { WrapMode = DataGridViewTriState.False } };

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Guid",
                DataPropertyName = "Guid",
                HeaderText = "Guid",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cliente Id",
                DataPropertyName = "ClienteId",
                HeaderText = "Cliente Id",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cliente Nome Completo",
                DataPropertyName = "ClienteNomeCompleto",
                HeaderText = "Cliente Nome Completo",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cliente CPF",
                DataPropertyName = "ClienteCpf",
                HeaderText = "Cliente CPF",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cliente Número Celular",
                DataPropertyName = "ClienteNumeroCelular",
                HeaderText = "Cliente Número Celular",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cliente Data Cadastro",
                DataPropertyName = "ClienteDataCadastro",
                HeaderText = "Cliente Data Cadastro",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Ticket Id",
                DataPropertyName = "TicketId",
                HeaderText = "Ticket Id",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Ticket Ativo",
                DataPropertyName = "TicketAtivo",
                HeaderText = "Ticket Ativo",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Ticket Valor Por Minuto",
                DataPropertyName = "TicketValorPorMinuto",
                HeaderText = "Ticket Valor Por Minuto",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Ticket Entrada",
                DataPropertyName = "TicketEntrada",
                HeaderText = "Ticket Entrada",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Ticket Saída",
                DataPropertyName = "TicketSaida",
                HeaderText = "Ticket Saída",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Ticket Tempo Estacionado",
                DataPropertyName = "TicketTempoEstacionado",
                HeaderText = "Ticket Tempo Estacionado",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Ticket Valor Ticket",
                DataPropertyName = "TicketValorTicket",
                HeaderText = "Ticket Valor Ticket",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Veículo Placa",
                DataPropertyName = "VeiculoPlaca",
                HeaderText = "Placa",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Veículo Cor",
                DataPropertyName = "VeiculoCor",
                HeaderText = "Cor",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Veículo Fabricante",
                DataPropertyName = "VeiculoFabricante",
                HeaderText = "Fabricante",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Veículo Modelo",
                DataPropertyName = "VeiculoModelo",
                HeaderText = "Modelo",
                HeaderCell = headerCell
            });

            DataGridViewReceita.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Data de Cadastro do Veículo",
                DataPropertyName = "VeiculoDataCadastro",
                HeaderText = "Data de Cadastro do Veículo",
                HeaderCell = headerCell
            });

            DataGridViewReceita.DataSource= ReceitaService.GetInstance().RecuperarTodos();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LinkLblExportar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string caminhoExprt = ReceitaService.GetInstance().ExportarRelatorioCsv();
            MessageBox.Show(
                            $"Arquivo exportado com sucesso!\n{caminhoExprt}",
                            "Exportar Relatório de Receita",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }
    }
}
