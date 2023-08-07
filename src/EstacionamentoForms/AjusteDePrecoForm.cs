using EstacionamentoForms.Models;
using EstacionamentoForms.Repositories;
using EstacionamentoForms.Repositories.Interfaces;
using EstacionamentoForms.Services;
using EstacionamentoForms.Services.Persistence;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    public partial class AjusteDePrecoForm : Form
    {
        private static double _globalValorAtual = 0.25;

        public AjusteDePrecoForm()
        {
            InitializeComponent();
        }

        public static double GetValorAtual()
        {
            return _globalValorAtual;
        }

        private void AjusteDePreco_Load(object sender, EventArgs e)
        {
            MovimentacaoModel movimentacao = MovimentacaoService.GetInstance().RecuperarAtual();
            this.TextBoxPreco.Text = movimentacao.ValorPorMinuto;
        }

        private void BtnSalvarAlterarPreco_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.TextBoxPreco.Text.ToUpper().Replace("R$", string.Empty).Trim(), out double novoValor))
            {
                _globalValorAtual = novoValor;
                MovimentacaoModel novaMovimentacao = new MovimentacaoModel();
                novaMovimentacao.ValorPorMinuto = $"{novoValor:F2}";

                if (!MovimentacaoService.GetInstance().Cadastrar(novaMovimentacao))
                    MessageBox.Show("No momento não é possível alterar o valor. Contate o suporte.");
                else
                    this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, informe um valor válido!");
            }
        }

        private void BtnCancelarAlterarPreco_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
