using EstacionamentoForms.Models;
using EstacionamentoForms.Services;
using EstacionamentoForms.Extensions;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using EstacionamentoForms.Configurations.Enum;

namespace EstacionamentoForms
{
    public partial class Estacionamento : Form
    {
        private bool _driverChecked;
        private string _driverName;

        private static DriverTypeEnum _globalDriver;
        private static int _globalQuantidadeVagas = 5;

        // Services
        private MovimentacaoService _movimentacaoService;

        public Estacionamento()
        {
            InitializeComponent();
            CarregarDriver();
        }

        // Getters
        public static DriverTypeEnum GetDriver()
        {
            return _globalDriver;
        }
        
        public static int GetVagas()
        {
            return _globalQuantidadeVagas;
        }

        // Home
        public void InitializeMovimentacao(bool driverAlterado = false)
        {
            MovimentacaoModel movimentacao;

            if (_movimentacaoService is null)
                _movimentacaoService = MovimentacaoService.GetInstance();

            if (driverAlterado)
                movimentacao  = _movimentacaoService.RecuperarAtual(driverAlterado);
            else
                movimentacao = _movimentacaoService.RecuperarAtual();


            this.LblLogo.Text = "Bem-Vindx ao GamaParking";
            this.LblLogo.ForeColor = Color.Green;
            this.LblLogo.Font = new Font(this.LblLogo.Font, FontStyle.Bold);

            this.LblColHome1.Text = nameof(movimentacao.ValorPorMinuto).SepararString();
            this.LblColHome1.Font = new Font(this.LblColHome1.Font, FontStyle.Bold);

            this.LblColHome2.Text = nameof(movimentacao.TotalVagasDisponiveis).SepararString();
            this.LblColHome2.Font = new Font(this.LblColHome2.Font, FontStyle.Bold);

            this.LblColHome3.Text = nameof(movimentacao.TotalVeiculosEstacionados).SepararString();
            this.LblColHome3.Font = new Font(this.LblColHome3.Font, FontStyle.Bold);

            this.LblColHome4.Text = nameof(movimentacao.TemVagaDisponivel).SepararString();
            this.LblColHome4.Font = new Font(this.LblColHome4.Font, FontStyle.Bold);

            this.LblRowHome1.Text = movimentacao.ValorPorMinuto;
            this.LblRowHome2.Text = movimentacao.TotalVagasDisponiveis;
            this.LblRowHome3.Text = movimentacao.TotalVeiculosEstacionados;
            this.LblRowHome4.Font = new Font(this.LblRowHome4.Font, FontStyle.Bold);
            this.LblRowHome4.Text = movimentacao.TemVagaDisponivel ? "Sim" : "Não";
            this.LblRowHome4.ForeColor = movimentacao.TemVagaDisponivel ? Color.Green : Color.Red;

        }

        // Arquivo > Ajustes > Preços > OK
        private void AjusteDePrecos_Click(object sender, EventArgs e)
        {
            Form form = new AjusteDePrecoForm();
            form.ShowDialog(this);
            InitializeMovimentacao(true);
        }

        // Arquivo > Sair > OK
        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clientes > Listagem de Clientes > OK
        private void LoadListagemClientes_Click(object sender, EventArgs e)
        {
            Form form = new ListagemClienteForm();
            form.ShowDialog(this);
            InitializeMovimentacao(true);
        }

        // Clientes > Cadastrar > OK
        private void CadastrarClientes_Click(object sender, EventArgs e)
        {
            Form form = new CadastroClienteForm();
            form.ShowDialog(this);
            InitializeMovimentacao(true);
        }

        // Veículos > Listagem de Veículos > OK
        private void LoadListagemVeiculos_Click(object sender, EventArgs e)
        {
            Form form = new ListagemVeiculoForm();
            form.ShowDialog(this);
            InitializeMovimentacao(true);
        }

        // Veículos > Cadastrar > OK
        private void CadastrarVeiculos_Click(object sender, EventArgs e)
        {
            Form form = new CadastroVeiculoForm();
            form.ShowDialog(this);
            InitializeMovimentacao(true);
        }

        // Tickets > Listagem de Tickets > OK
        private void LoadListagemTickets_Click(object sender, EventArgs e)
        {
            Form form = new ListagemTicketForm();
            form.ShowDialog(this);
            InitializeMovimentacao(true);
        }

        // Tickets > Cadastrar > OK
        private void CadastrarTicket_Click(object sender, EventArgs e)
        {
            if (_movimentacaoService.RecuperarAtual().TemVagaDisponivel)
            {
                Form form = new CadastroTicketForm();
                form.ShowDialog(this);
                InitializeMovimentacao(true);
            }
            else
            {
                MessageBox.Show(
                    "No momento não há vagas disponíveis!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Tickets > Fechar > OK
        private void FecharTicket_Click(object sender, EventArgs e)
        {
            Form form = new FecharTicketForm();
            form.ShowDialog(this);
            InitializeMovimentacao(true);
        }

        // Receita > Relatório de Receita > OK
        private void LoadRelatorioReceita_Click(object sender, EventArgs e)
        {
            Form form = new RelatorioReceitaForm();
            form.ShowDialog(this);
            InitializeMovimentacao(true);
        }

        private void CarregarDriver()
        {
            List<string> drivers = DriverType.GetKeys().ToList();

            this.toolDriver1.Text = drivers[0];
            this.toolDriver2.Text = drivers[1];
            this.toolDriver3.Text = drivers[2];
            this.toolDriver4.Text = drivers[3];

            _globalDriver = DriverType.GetByKey(this.toolDriver2.Text);
            _driverName = $"Estacionamento (driver_{_globalDriver.ToString().ToLower()})";
            this.Text = _driverName;

            InitializeMovimentacao(true);
        }

        private void toolDriver1_Click(object sender, EventArgs e)
        {
            _globalDriver = DriverType.GetByKey(this.toolDriver1.Text);
            _driverChecked = true;
            _driverName = $"Estacionamento (driver_{_globalDriver.ToString().ToLower()})";

            this.Text = _driverName;

            this.toolDriver1.Checked = true;
            this.toolDriver2.Checked = false;
            this.toolDriver3.Checked = false;
            this.toolDriver4.Checked = false;

            InitializeMovimentacao(true);
        }

        private void toolDriver2_Click(object sender, EventArgs e)
        {
            _globalDriver = DriverType.GetByKey(this.toolDriver2.Text);
            _driverChecked = true;
            _driverName = $"Estacionamento (driver_{_globalDriver.ToString().ToLower()})";

            this.Text = _driverName;

            this.toolDriver1.Checked = false;
            this.toolDriver2.Checked = true;
            this.toolDriver3.Checked = false;
            this.toolDriver4.Checked = false;

            InitializeMovimentacao(true);
        }

        private void toolDriver3_Click(object sender, EventArgs e)
        {
            _globalDriver = DriverType.GetByKey(this.toolDriver3.Text);
            _driverChecked = true;
            _driverName = $"Estacionamento (driver_{_globalDriver.ToString().ToLower()})";

            this.Text = _driverName;

            this.toolDriver1.Checked = false;
            this.toolDriver2.Checked = false;
            this.toolDriver3.Checked = true;
            this.toolDriver4.Checked = false;

            InitializeMovimentacao(true);
        }

        private void toolDriver4_Click(object sender, EventArgs e)
        {
            _globalDriver = DriverType.GetByKey(this.toolDriver4.Text);
            _driverChecked = true;
            _driverName = $"Estacionamento (driver_{_globalDriver.ToString().ToLower()})";

            this.Text = _driverName;

            this.toolDriver1.Checked = false;
            this.toolDriver2.Checked = false;
            this.toolDriver3.Checked = false;
            this.toolDriver4.Checked = true;

            InitializeMovimentacao(true);
        }
    }
}
