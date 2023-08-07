using EstacionamentoForms.Services;
using System;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    public partial class ListagemVeiculoForm : Form
    {
        #region Singleton
        private static ListagemVeiculoForm instance;
        public static ListagemVeiculoForm GetInstance()
        {
            if (instance == null)
                instance = new ListagemVeiculoForm();

            return instance;
        }
        #endregion

        public ListagemVeiculoForm()
        {
            InitializeComponent();
            DataGridViewVeiculos_load();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewVeiculos_load()
        {
            DataGridViewVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewVeiculos.AutoGenerateColumns = false;
            DataGridViewVeiculos.ScrollBars = ScrollBars.Vertical;
            DataGridViewVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewColumnHeaderCell headerCell = new DataGridViewColumnHeaderCell { Style = { WrapMode = DataGridViewTriState.False } };

            DataGridViewVeiculos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Id",
                DataPropertyName = "Id",
                HeaderText = "ID",
                HeaderCell = headerCell
            });

            DataGridViewVeiculos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Placa",
                DataPropertyName = "Placa",
                HeaderText = "Placa",
                HeaderCell = headerCell
            });

            DataGridViewVeiculos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cor",
                DataPropertyName = "Cor",
                HeaderText = "Cor",
                HeaderCell = headerCell
            });

            DataGridViewVeiculos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Fabricante",
                DataPropertyName = "Fabricante",
                HeaderText = "Fabricante",
                HeaderCell = headerCell
            });

            DataGridViewVeiculos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Modelo",
                DataPropertyName = "Modelo",
                HeaderText = "Modelo",
                HeaderCell = headerCell
            });

            DataGridViewVeiculos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DataCadastro",
                DataPropertyName = "DataCadastro",
                HeaderText = "Data Cadastro",
                HeaderCell = headerCell
            });

            DataGridViewVeiculos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "IdCliente",
                DataPropertyName = "IdCliente",
                HeaderText = "ID Cliente",
                HeaderCell = headerCell
            });

            DataGridViewVeiculos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "NomeCliente",
                DataPropertyName = "NomeCliente",
                HeaderText = "Nome Cliente",
                HeaderCell = headerCell
            });

            DataGridViewVeiculos.DataSource = VeiculoService.GetInstance().RecuperarTodos();
        }

        private void DataGridViewVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewVeiculos.SelectedRows[0];
                this.TxtBoxId.Text = int.Parse(row.Cells["Id"].Value.ToString()).ToString("D4");
                this.TxtBoxIdCliente.Text = row.Cells["IdCliente"].Value.ToString();
                this.TxtBoxNomeCliente.Text = row.Cells["NomeCliente"].Value.ToString();
                this.TxtBoxPlaca.Text = row.Cells["Placa"].Value.ToString();
                this.TxtBoxFabricante.Text = row.Cells["Fabricante"].Value.ToString();
                this.TxtBoxModelo.Text = row.Cells["Modelo"].Value.ToString();
                this.TxtBoxCor.Text = row.Cells["Cor"].Value.ToString();
                this.TxtBoxDataCadastro.Text = row.Cells["DataCadastro"].Value.ToString();
            }
        }
    }
}
