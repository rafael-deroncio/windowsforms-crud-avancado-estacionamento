using EstacionamentoForms.Configurations.Enum;
using EstacionamentoForms.Models;
using EstacionamentoForms.Services;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    public partial class CadastroClienteForm : Form
    {
        public CadastroClienteForm()
        {
            InitializeComponent();
        }

        private void CadastroClienteForm_Load(object sender, EventArgs e)
        {
            this.TxtBoxId.Text = (1 + ClienteService.GetInstance().RecuperarTodos().Count()).ToString("D4");
            this.TxtBoxDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = new ClienteModel()
            {
                Id = int.Parse(this.TxtBoxId.Text),
                NomeCompleto = this.TxtBoxNomeCompleto.Text,
                Cpf = this.MaskTxtBoxCpf.Text,
                NumeroCelular = this.MaskTxtBoxTelefoneCelular.Text,
                DataCadastro = DateTime.ParseExact(this.TxtBoxDataCadastro.Text, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
            };
            

            if (!ClienteService.GetInstance().Cadastrar(cliente))
                MessageBox.Show("Não foi possível salvar os dados do cliente.");

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
    }
}
