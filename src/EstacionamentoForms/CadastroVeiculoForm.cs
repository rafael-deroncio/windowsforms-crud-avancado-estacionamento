using EstacionamentoForms.Models;
using EstacionamentoForms.Services;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    public partial class CadastroVeiculoForm : Form
    {
        private bool _pesquisaAtiva = false;

        #region Singleton
        private static CadastroVeiculoForm instance;
        public CadastroVeiculoForm() 
        {
            InitializeComponent();
            this.RdoCpf.Checked = false;
            this.RdoIdCliente.Checked = true;
        }
        public static CadastroVeiculoForm GetInstance()
        {
            if (instance == null)
                instance = new CadastroVeiculoForm();

            return instance;
        }
        #endregion

        private void CadastroVeiculoForm_Load(object sender, EventArgs e)
        {
            this.TxtBoxId.Text = (1 + VeiculoService.GetInstance().RecuperarTodos().Count()).ToString("D4");
            this.TxtBoxDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            VeiculoModel veiculo = new VeiculoModel()
            {
                Id = int.Parse(this.TxtBoxId.Text),
                IdCliente = int.Parse(this.TxtBoxIdCliente.Text),
                NomeCliente = this.TxtBoxNomeCliente.Text,
                Placa = this.MkdTxtBoxPlaca.Text,
                Fabricante = this.CmbBoxFabricante.Text,
                Modelo = this.TxtBoxModelo.Text,
                Cor = this.CmbBoxCor.Text,
                DataCadastro = DateTime.ParseExact(this.TxtBoxDataCadastro.Text, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
            };

            if (!VeiculoService.GetInstance().Cadastrar(veiculo))
                MessageBox.Show("Não foi possível salvar os dados do cliente. Verifique se todos os campos ~foram digitados corretamente.");
            
            else
            {
                MessageBox.Show("Cadastro realizada com sucesso!");
                this.Close();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdoCpf_Click(object sender, EventArgs e)
        {
            this.RdoCpf.Checked = true;
            this.RdoIdCliente.Checked = false;
        }

        private void RdoIdCliente_Click(object sender, EventArgs e)
        {
            this.RdoCpf.Checked = false;
            this.RdoIdCliente.Checked = true;
        }

        private void MkdTxtPesquisaCliente_Click(object sender, EventArgs e)
        {
            if (this.RdoCpf.Checked)
                this.MkdTxtPesquisaCliente.Mask = "000.000.000-00";

            if (this.RdoIdCliente.Checked)
                this.MkdTxtPesquisaCliente.Mask = "0000";
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (_pesquisaAtiva)
            {
                ActionLimpar();
                return;
            }

            if (this.MkdTxtPesquisaCliente.Text != null)
            {
                ClienteModel cliente = new ClienteModel();

                if (this.RdoCpf.Checked)
                { 
                    cliente = ClienteService.GetInstance().RecuperarTodos()
                        .FirstOrDefault(x => x.Cpf == this.MkdTxtPesquisaCliente.Text);
                }
                else
                {
                    int id = 0;
                    int.TryParse(this.MkdTxtPesquisaCliente.Text, out id);
                    cliente = ClienteService.GetInstance().RecuperarTodos()
                        .FirstOrDefault(x => x.Id == id);

                }

                if (cliente is null)
                { 
                    MessageBox.Show(string.Format("Cliente não pelo {0}: {1}", 
                        (this.RdoCpf.Checked ? "CPF" : "ID"), this.MkdTxtPesquisaCliente.Text));
                }
                else
                {
                    ActionPesquisar();
                    this.TxtBoxIdCliente.Text = cliente.Id.ToString("D4");
                    this.TxtBoxNomeCliente.Text = cliente.NomeCompleto;

                    this.CmbBoxFabricante.DataSource = VeiculoService.GetInstance().OpcoesFabricantes();
                    this.CmbBoxCor.DataSource = VeiculoService.GetInstance().OpcoesCores();
                }
            }
            else
            {
                MessageBox.Show("Por favor, informar o CPF ou ID para a consulta.");
            }
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
            this.MkdTxtPesquisaCliente.Text = string.Empty;
            this.BtnAction.ForeColor = Color.Blue;
            this.BtnAction.Text = "Pesquisar";
            this.TxtBoxIdCliente.Text = string.Empty;
            this.TxtBoxNomeCliente.Text = string.Empty;
            this.MkdTxtBoxPlaca.Text = string.Empty;
            this.CmbBoxFabricante.Text = string.Empty;
            this.TxtBoxModelo.Text = string.Empty;
            this.CmbBoxCor.Text= string.Empty;
            this.TxtBoxDataCadastro.Text = string.Empty;
        }

        private void CmbBoxFabricante_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                string itemText = this.CmbBoxFabricante.GetItemText(CmbBoxFabricante.Items[e.Index]);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds, stringFormat);
                }

                e.DrawFocusRectangle();
            }
        }

        private void CmbBoxCor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                string itemText = this.CmbBoxCor.GetItemText(CmbBoxCor.Items[e.Index]);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds, stringFormat);
                }

                e.DrawFocusRectangle();
            }
        }
    }
}
