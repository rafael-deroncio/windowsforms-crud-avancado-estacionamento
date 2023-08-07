using EstacionamentoForms.Configurations.Enum;
using EstacionamentoForms.Extensions;
using EstacionamentoForms.Models;
using EstacionamentoForms.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    public partial class CadastroTicketForm : Form
    {
        private bool _pesquisaAtiva = false;

        public CadastroTicketForm()
        {
            InitializeComponent();
            DataGridViewVeiculosCliente_load();

            this.RdoIdCliente.Checked = true;
            this.RdoCpf.Checked = false;
            this.RdoIdVeiculo.Checked = false;
            this.RdoPlaca.Checked = false;

            this.TxtBoxId.Text = (1 + TicketService.GetInstance().RecuperarTodos().Count()).ToString("D4");
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            List<MovimentacaoModel> movimentacaes = MovimentacaoService.GetInstance().RecuperarTodos();
            MovimentacaoModel movimentacaoAtual = movimentacaes.Find(x => x.Id == movimentacaes.Max(y => y.Id));

            string idTicket = this.TxtBoxId.Text;
            string titulo = "Registrar Ticket";
            string mensagem = $"Valor por minuto: R$ {movimentacaoAtual.ValorPorMinuto}" + Environment.NewLine + $"Deseja Iniciar o tiket {idTicket}?";

            DialogResult result = MessageBox.Show(mensagem, titulo, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                IniciarTicket();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdoCpf_Click(object sender, EventArgs e)
        {
            this.RdoCpf.Checked = true;
            this.RdoIdCliente.Checked = false;
            this.RdoPlaca.Checked = false;
        }

        private void RdoIdCliente_Click(object sender, EventArgs e)
        {
            this.RdoCpf.Checked = false;
            this.RdoIdCliente.Checked = true;
            this.RdoPlaca.Checked = false;
        }

        private void RdoPlaca_Click(object sender, EventArgs e)
        {
            this.RdoCpf.Checked = false;
            this.RdoIdCliente.Checked = false;
            this.RdoPlaca.Checked = true;
        }

        private void MkdTxtPesquisa_Click(object sender, EventArgs e)
        {
            if (this.RdoCpf.Checked)
                this.MkdTxtPesquisa.Mask = "000.000.000-00";

            if (this.RdoIdCliente.Checked || this.RdoIdVeiculo.Checked)
                this.MkdTxtPesquisa.Mask = "0000";

            if (this.RdoPlaca.Checked)
                this.MkdTxtPesquisa.Mask = "AAAAAAA";
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (_pesquisaAtiva)
            {
                ActionLimpar();
                DataGridViewVeiculosCliente_load();
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
            }
            else
            {
                MessageBox.Show("Por favor, informar o CPF ou ID para a consulta.");
            }
        }

        private ClienteModel PesquisaPorCliente()
        {
            ClienteModel cliente = new ClienteModel();

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
                List<VeiculoModel> veiculos = VeiculoService.GetInstance().RecuperarTodos().FindAll(x => x.IdCliente == cliente.Id);
                
                if (veiculos.Count > 0)
                    DataGridViewVeiculosCliente_load(veiculos);
                else
                    MessageBox.Show($"Cliente {cliente.Id:D4} | {cliente.NomeCompleto} não possui veículo cadastrado.");
            }
            return cliente;
        }

        private VeiculoModel PesquisarPorVeiculo()
        {
            VeiculoModel veiculo = new VeiculoModel();

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
                    (this.RdoPlaca.Checked ? "Placa" : "ID"), this.MkdTxtPesquisa.Text));
            }
            else
            {
                ActionPesquisar();
                List<VeiculoModel> veiculos = new List<VeiculoModel>() { veiculo };
                DataGridViewVeiculosCliente_load(veiculos);
            }

            return veiculo;
        }

        private TicketModel IniciarTicket()
        {
            int idVeiculo = int.Parse(this.LblOcultoIdVeiculo.Text);
            int idCliente = int.Parse(this.LblOcultoIdCliente.Text);
            VeiculoModel veiculo = VeiculoService.GetInstance().RecuperarTodos().Find(x => x.Id == idVeiculo && x.IdCliente == idCliente);
            List<MovimentacaoModel> movimentacaes = MovimentacaoService.GetInstance().RecuperarTodos();
            MovimentacaoModel movimentacaoAtual = movimentacaes.Find(x => x.Id == movimentacaes.Max(y => y.Id));

            TicketModel ticket = new TicketModel()
            {
                
                ValorPorMinuto = movimentacaoAtual.ValorPorMinuto,
                Entrada = DateTime.ParseExact(this.TxtBoxEntrada.Text.Split(',')[0], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                Saida = null,

                IdCliente = idCliente,
                NomeCliente = veiculo.NomeCliente,

                IdVeiculo = idVeiculo,
                DescricaoVeiculo = this.TxtBoxDescricao.Text
            };

            if (TicketService.GetInstance().Cadastrar(ticket) && TicketService.GetInstance().IniciarTcket(ticket))
            {
                MessageBox.Show("Ticket Registrado com Sucesso!");
                this.Close();
            }
            else
                MessageBox.Show("Não foi possível iniciar o tícket. Contate o suporte.");

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
            this.TxtBoxNomeCliente.Text = string.Empty;
            this.TxtBoxDescricao.Text = string.Empty;
            this.TxtBoxEntrada.Text = string.Empty;
            this.TxtBoxModelo.Text = string.Empty;
            this.CmbBoxCor.Text = string.Empty;
            this.TxtBoxDataCadastro.Text = string.Empty;
        }

        private void DataGridViewVeiculosCliente_load(List<VeiculoModel> veiculos = null)
        {
            {
                DataGridViewVeiculosCliente.Columns.Clear();
                DataGridViewVeiculosCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                DataGridViewVeiculosCliente.AutoGenerateColumns = false;
                DataGridViewVeiculosCliente.AllowUserToResizeColumns = true;
                DataGridViewVeiculosCliente.ScrollBars = ScrollBars.Both;
                DataGridViewVeiculosCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridViewColumnHeaderCell headerCell = new DataGridViewColumnHeaderCell { Style = { WrapMode = DataGridViewTriState.False } };

                DataGridViewVeiculosCliente.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Id",
                    DataPropertyName = "Id",
                    HeaderText = "ID",
                    HeaderCell = headerCell
                });

                DataGridViewVeiculosCliente.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Placa",
                    DataPropertyName = "Placa",
                    HeaderText = "Placa",
                    HeaderCell = headerCell
                });

                DataGridViewVeiculosCliente.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Cor",
                    DataPropertyName = "Cor",
                    HeaderText = "Cor",
                    HeaderCell = headerCell
                });

                DataGridViewVeiculosCliente.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Fabricante",
                    DataPropertyName = "Fabricante",
                    HeaderText = "Fabricante",
                    HeaderCell = headerCell
                });

                DataGridViewVeiculosCliente.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Modelo",
                    DataPropertyName = "Modelo",
                    HeaderText = "Modelo",
                    HeaderCell = headerCell
                });

                DataGridViewVeiculosCliente.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "DataCadastro",
                    DataPropertyName = "DataCadastro",
                    HeaderText = "Data Cadastro",
                    HeaderCell = headerCell
                });

                DataGridViewVeiculosCliente.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "IdCliente",
                    DataPropertyName = "IdCliente",
                    HeaderText = "ID Cliente",
                    HeaderCell = headerCell
                });

                DataGridViewVeiculosCliente.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "NomeCliente",
                    DataPropertyName = "NomeCliente",
                    HeaderText = "Nome Cliente",
                    HeaderCell = headerCell
                });

                DataGridViewVeiculosCliente.DataSource = VeiculoService.GetInstance().RecuperarTodos();
            }

            DataGridViewVeiculosCliente.DataSource = veiculos;
        }

        private void DataGridViewVeiculosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewVeiculosCliente.SelectedRows[0];

                //Veiculo
                int idVeiculo = int.Parse(row.Cells["Id"].Value.ToString());
                VeiculoModel veiculoSelecionado = VeiculoService.GetInstance().RecuperarTodos().Find(veiculo => veiculo.Id == idVeiculo);
                ClienteModel cliente = ClienteService.GetInstance().RecuperarTodos().Find(x => x.Id == veiculoSelecionado.IdCliente);

                this.LblOcultoIdCliente.Visible = false;
                this.LblOcultoIdCliente.Text = cliente.Id.ToString();
                this.LblOcultoIdVeiculo.Visible = false;
                this.LblOcultoIdVeiculo.Text = veiculoSelecionado.Id.ToString();
                
                this.TxtBoxAtivo.Text = "Cadastro";
                this.TxtBoxNomeCliente.Text = $"ID: {cliente.Id:D4} | {cliente.NomeCompleto}";
                this.TxtBoxDescricao.Text = $"ID: {veiculoSelecionado.Id:D4} | {veiculoSelecionado.Placa} | {veiculoSelecionado.Fabricante} {veiculoSelecionado.Modelo}, {veiculoSelecionado.Cor}";
                this.TxtBoxEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss, dddd");

                this.BtnIniciarTicket.Enabled = ValidaSeExisteTicketAbertoParaOVeiculo();
            }
        }

        private bool ValidaSeExisteTicketAbertoParaOVeiculo()
        {
            int idVeiculo = int.Parse(this.LblOcultoIdVeiculo.Text);
            int idCliente = int.Parse(this.LblOcultoIdCliente.Text);
            TicketModel ticket = TicketService.GetInstance().RecuperarTodos().Find(x => x.IdCliente == idCliente && x.IdVeiculo == idVeiculo && x.Ativo);
            bool result = ticket is null;

            if (!(ticket is null)) { MessageBox.Show("Já existe um tiket aberto para esse veículo."); }
            
            return ticket is null;
        }
    }
}
