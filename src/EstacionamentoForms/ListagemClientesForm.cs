using EstacionamentoForms.Services;
using System;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    public partial class ListagemClienteForm : Form
    {

        public ListagemClienteForm()
        {
            InitializeComponent();
            DataGridViewClientes_load();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewClientes_load()
        {
            DataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewClientes.AutoGenerateColumns = false;
            DataGridViewClientes.ScrollBars = ScrollBars.Vertical;
            DataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewColumnHeaderCell headerCell = new DataGridViewColumnHeaderCell { Style = { WrapMode = DataGridViewTriState.False } };

            DataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "ID",
                HeaderCell = headerCell
            });

            DataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "NomeCompleto",
                DataPropertyName = "NomeCompleto",
                HeaderText = "Nome Completo",
                HeaderCell = headerCell
            });

            DataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cpf",
                DataPropertyName = "Cpf",
                HeaderText = "CPF",
                HeaderCell = headerCell
            });

            DataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "NumeroCelular",
                DataPropertyName = "NumeroCelular",
                HeaderText = "Número de Celular",
                HeaderCell = headerCell
            });

            DataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DataCadastro",
                DataPropertyName = "DataCadastro",
                HeaderText = "Data Cadastro",
                HeaderCell = headerCell
            });

            DataGridViewClientes.DataSource = ClienteService.GetInstance().RecuperarTodos();
        }

        private void DataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewClientes.SelectedRows[0];
                this.TxtBoxId.Text = int.Parse(row.Cells["Id"].Value.ToString()).ToString("D4");
                this.TxtBoxNomeCompleto.Text = row.Cells["NomeCompleto"].Value.ToString();
                this.MaskTxtBoxCpf.Text = row.Cells["Cpf"].Value.ToString();
                this.MaskTxtBoxTelefoneCelular.Text = row.Cells["NumeroCelular"].Value.ToString();
                this.TxtBoxDataCadastro.Text = row.Cells["DataCadastro"].Value.ToString();
            }
        }
    }
}
