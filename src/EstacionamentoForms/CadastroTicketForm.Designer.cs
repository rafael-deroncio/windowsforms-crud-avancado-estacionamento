using System.Windows.Forms;

namespace EstacionamentoForms
{
    partial class CadastroTicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnIniciarTicket = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.TxtBoxDataCadastro = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblDecricao = new System.Windows.Forms.Label();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.LblSaida = new System.Windows.Forms.Label();
            this.LblTempoEstacionado = new System.Windows.Forms.Label();
            this.LblValorTicket = new System.Windows.Forms.Label();
            this.TxtBoxDescricao = new System.Windows.Forms.TextBox();
            this.TxtBoxAtivo = new System.Windows.Forms.TextBox();
            this.TxtBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.TxtBoxEntrada = new System.Windows.Forms.TextBox();
            this.CmbBoxCor = new System.Windows.Forms.TextBox();
            this.TxtBoxModelo = new System.Windows.Forms.TextBox();
            this.RdoIdCliente = new System.Windows.Forms.RadioButton();
            this.RdoCpf = new System.Windows.Forms.RadioButton();
            this.MkdTxtPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RdoIdVeiculo = new System.Windows.Forms.RadioButton();
            this.RdoPlaca = new System.Windows.Forms.RadioButton();
            this.BtnAction = new System.Windows.Forms.Button();
            this.DataGridViewVeiculosCliente = new System.Windows.Forms.DataGridView();
            this.LblOcultoIdVeiculo = new System.Windows.Forms.Label();
            this.LblOcultoIdCliente = new System.Windows.Forms.Label();
            this.TableLayoutOculta = new System.Windows.Forms.TableLayoutPanel();
            this.PicCliente = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVeiculosCliente)).BeginInit();
            this.TableLayoutOculta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIniciarTicket
            // 
            this.BtnIniciarTicket.Enabled = false;
            this.BtnIniciarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarTicket.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnIniciarTicket.Location = new System.Drawing.Point(626, 523);
            this.BtnIniciarTicket.Name = "BtnIniciarTicket";
            this.BtnIniciarTicket.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnIniciarTicket.Size = new System.Drawing.Size(92, 23);
            this.BtnIniciarTicket.TabIndex = 1;
            this.BtnIniciarTicket.Text = "Registrar Ticket";
            this.BtnIniciarTicket.UseVisualStyleBackColor = true;
            this.BtnIniciarTicket.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCancelar.Location = new System.Drawing.Point(739, 523);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 23);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Sair";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LblId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxDataCadastro, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.LblStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblCliente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblDecricao, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblEntrada, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblSaida, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblTempoEstacionado, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LblValorTicket, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxDescricao, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxAtivo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxNomeCliente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxEntrada, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CmbBoxCor, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxModelo, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(278, 253);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 224);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // LblId
            // 
            this.LblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblId.Location = new System.Drawing.Point(6, 3);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(171, 24);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID Ticket:";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxId.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxId.Location = new System.Drawing.Point(186, 6);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.ReadOnly = true;
            this.TxtBoxId.Size = new System.Drawing.Size(261, 15);
            this.TxtBoxId.TabIndex = 1;
            this.TxtBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxDataCadastro
            // 
            this.TxtBoxDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxDataCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxDataCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxDataCadastro.Location = new System.Drawing.Point(186, 195);
            this.TxtBoxDataCadastro.Name = "TxtBoxDataCadastro";
            this.TxtBoxDataCadastro.ReadOnly = true;
            this.TxtBoxDataCadastro.Size = new System.Drawing.Size(261, 15);
            this.TxtBoxDataCadastro.TabIndex = 8;
            this.TxtBoxDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblStatus
            // 
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblStatus.Location = new System.Drawing.Point(6, 30);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(171, 24);
            this.LblStatus.TabIndex = 0;
            this.LblStatus.Text = "Status Ticket:";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCliente
            // 
            this.LblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCliente.Location = new System.Drawing.Point(6, 57);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(171, 24);
            this.LblCliente.TabIndex = 0;
            this.LblCliente.Text = "Cliente";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDecricao
            // 
            this.LblDecricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDecricao.Location = new System.Drawing.Point(6, 84);
            this.LblDecricao.Name = "LblDecricao";
            this.LblDecricao.Size = new System.Drawing.Size(171, 24);
            this.LblDecricao.TabIndex = 0;
            this.LblDecricao.Text = "Veículo:";
            this.LblDecricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblEntrada
            // 
            this.LblEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEntrada.Location = new System.Drawing.Point(6, 111);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(171, 24);
            this.LblEntrada.TabIndex = 0;
            this.LblEntrada.Text = "Entrada:";
            this.LblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblSaida
            // 
            this.LblSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSaida.Location = new System.Drawing.Point(6, 138);
            this.LblSaida.Name = "LblSaida";
            this.LblSaida.Size = new System.Drawing.Size(171, 24);
            this.LblSaida.TabIndex = 0;
            this.LblSaida.Text = "Saída:";
            this.LblSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTempoEstacionado
            // 
            this.LblTempoEstacionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTempoEstacionado.Location = new System.Drawing.Point(6, 165);
            this.LblTempoEstacionado.Name = "LblTempoEstacionado";
            this.LblTempoEstacionado.Size = new System.Drawing.Size(171, 24);
            this.LblTempoEstacionado.TabIndex = 0;
            this.LblTempoEstacionado.Text = "Tempo Estacionado:";
            this.LblTempoEstacionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblValorTicket
            // 
            this.LblValorTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblValorTicket.Location = new System.Drawing.Point(6, 192);
            this.LblValorTicket.Name = "LblValorTicket";
            this.LblValorTicket.Size = new System.Drawing.Size(171, 29);
            this.LblValorTicket.TabIndex = 0;
            this.LblValorTicket.Text = "Valor Ticket:";
            this.LblValorTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBoxDescricao
            // 
            this.TxtBoxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxDescricao.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxDescricao.Location = new System.Drawing.Point(186, 87);
            this.TxtBoxDescricao.Name = "TxtBoxDescricao";
            this.TxtBoxDescricao.ReadOnly = true;
            this.TxtBoxDescricao.Size = new System.Drawing.Size(261, 15);
            this.TxtBoxDescricao.TabIndex = 4;
            this.TxtBoxDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxAtivo
            // 
            this.TxtBoxAtivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxAtivo.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxAtivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxAtivo.Location = new System.Drawing.Point(186, 33);
            this.TxtBoxAtivo.Name = "TxtBoxAtivo";
            this.TxtBoxAtivo.ReadOnly = true;
            this.TxtBoxAtivo.Size = new System.Drawing.Size(261, 15);
            this.TxtBoxAtivo.TabIndex = 2;
            this.TxtBoxAtivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxNomeCliente
            // 
            this.TxtBoxNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxNomeCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxNomeCliente.Location = new System.Drawing.Point(186, 60);
            this.TxtBoxNomeCliente.Name = "TxtBoxNomeCliente";
            this.TxtBoxNomeCliente.ReadOnly = true;
            this.TxtBoxNomeCliente.Size = new System.Drawing.Size(261, 15);
            this.TxtBoxNomeCliente.TabIndex = 3;
            this.TxtBoxNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxEntrada
            // 
            this.TxtBoxEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxEntrada.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TxtBoxEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxEntrada.Location = new System.Drawing.Point(186, 114);
            this.TxtBoxEntrada.Name = "TxtBoxEntrada";
            this.TxtBoxEntrada.ReadOnly = true;
            this.TxtBoxEntrada.Size = new System.Drawing.Size(261, 15);
            this.TxtBoxEntrada.TabIndex = 5;
            this.TxtBoxEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxEntrada.UseWaitCursor = true;
            // 
            // CmbBoxCor
            // 
            this.CmbBoxCor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CmbBoxCor.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CmbBoxCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbBoxCor.Location = new System.Drawing.Point(186, 168);
            this.CmbBoxCor.Name = "CmbBoxCor";
            this.CmbBoxCor.ReadOnly = true;
            this.CmbBoxCor.Size = new System.Drawing.Size(261, 15);
            this.CmbBoxCor.TabIndex = 7;
            this.CmbBoxCor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CmbBoxCor.UseWaitCursor = true;
            // 
            // TxtBoxModelo
            // 
            this.TxtBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxModelo.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxModelo.Location = new System.Drawing.Point(186, 141);
            this.TxtBoxModelo.Name = "TxtBoxModelo";
            this.TxtBoxModelo.ReadOnly = true;
            this.TxtBoxModelo.Size = new System.Drawing.Size(261, 15);
            this.TxtBoxModelo.TabIndex = 6;
            this.TxtBoxModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RdoIdCliente
            // 
            this.RdoIdCliente.AutoSize = true;
            this.RdoIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoIdCliente.Location = new System.Drawing.Point(3, 3);
            this.RdoIdCliente.Name = "RdoIdCliente";
            this.RdoIdCliente.Size = new System.Drawing.Size(85, 28);
            this.RdoIdCliente.TabIndex = 5;
            this.RdoIdCliente.TabStop = true;
            this.RdoIdCliente.Text = "ID Cliente";
            this.RdoIdCliente.UseVisualStyleBackColor = true;
            this.RdoIdCliente.Click += new System.EventHandler(this.RdoIdCliente_Click);
            // 
            // RdoCpf
            // 
            this.RdoCpf.AutoSize = true;
            this.RdoCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoCpf.Location = new System.Drawing.Point(94, 3);
            this.RdoCpf.Name = "RdoCpf";
            this.RdoCpf.Size = new System.Drawing.Size(54, 28);
            this.RdoCpf.TabIndex = 6;
            this.RdoCpf.TabStop = true;
            this.RdoCpf.Text = "CPF";
            this.RdoCpf.UseVisualStyleBackColor = true;
            this.RdoCpf.Click += new System.EventHandler(this.RdoCpf_Click);
            // 
            // MkdTxtPesquisa
            // 
            this.MkdTxtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MkdTxtPesquisa.Location = new System.Drawing.Point(318, 6);
            this.MkdTxtPesquisa.Name = "MkdTxtPesquisa";
            this.MkdTxtPesquisa.Size = new System.Drawing.Size(222, 22);
            this.MkdTxtPesquisa.TabIndex = 7;
            this.MkdTxtPesquisa.Click += new System.EventHandler(this.MkdTxtPesquisa_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.RdoIdCliente);
            this.flowLayoutPanel1.Controls.Add(this.RdoCpf);
            this.flowLayoutPanel1.Controls.Add(this.RdoIdVeiculo);
            this.flowLayoutPanel1.Controls.Add(this.RdoPlaca);
            this.flowLayoutPanel1.Controls.Add(this.MkdTxtPesquisa);
            this.flowLayoutPanel1.Controls.Add(this.BtnAction);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 37);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // RdoIdVeiculo
            // 
            this.RdoIdVeiculo.AutoSize = true;
            this.RdoIdVeiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoIdVeiculo.Location = new System.Drawing.Point(154, 3);
            this.RdoIdVeiculo.Name = "RdoIdVeiculo";
            this.RdoIdVeiculo.Size = new System.Drawing.Size(89, 28);
            this.RdoIdVeiculo.TabIndex = 8;
            this.RdoIdVeiculo.TabStop = true;
            this.RdoIdVeiculo.Text = "ID Veículo";
            this.RdoIdVeiculo.UseVisualStyleBackColor = true;
            // 
            // RdoPlaca
            // 
            this.RdoPlaca.AutoSize = true;
            this.RdoPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoPlaca.Location = new System.Drawing.Point(249, 3);
            this.RdoPlaca.Name = "RdoPlaca";
            this.RdoPlaca.Size = new System.Drawing.Size(63, 28);
            this.RdoPlaca.TabIndex = 9;
            this.RdoPlaca.TabStop = true;
            this.RdoPlaca.Text = "Placa";
            this.RdoPlaca.UseVisualStyleBackColor = true;
            // 
            // BtnAction
            // 
            this.BtnAction.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAction.ForeColor = System.Drawing.Color.Blue;
            this.BtnAction.Location = new System.Drawing.Point(546, 3);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(105, 28);
            this.BtnAction.TabIndex = 8;
            this.BtnAction.Text = "Pesquisar";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // DataGridViewVeiculosCliente
            // 
            this.DataGridViewVeiculosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVeiculosCliente.Location = new System.Drawing.Point(71, 78);
            this.DataGridViewVeiculosCliente.Name = "DataGridViewVeiculosCliente";
            this.DataGridViewVeiculosCliente.RowHeadersWidth = 51;
            this.DataGridViewVeiculosCliente.Size = new System.Drawing.Size(658, 111);
            this.DataGridViewVeiculosCliente.TabIndex = 9;
            this.DataGridViewVeiculosCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVeiculosCliente_CellClick);
            // 
            // LblOcultoIdVeiculo
            // 
            this.LblOcultoIdVeiculo.AutoSize = true;
            this.LblOcultoIdVeiculo.Location = new System.Drawing.Point(3, 20);
            this.LblOcultoIdVeiculo.Name = "LblOcultoIdVeiculo";
            this.LblOcultoIdVeiculo.Size = new System.Drawing.Size(0, 16);
            this.LblOcultoIdVeiculo.TabIndex = 1;
            // 
            // LblOcultoIdCliente
            // 
            this.LblOcultoIdCliente.AutoSize = true;
            this.LblOcultoIdCliente.Location = new System.Drawing.Point(3, 0);
            this.LblOcultoIdCliente.Name = "LblOcultoIdCliente";
            this.LblOcultoIdCliente.Size = new System.Drawing.Size(0, 16);
            this.LblOcultoIdCliente.TabIndex = 0;
            // 
            // TableLayoutOculta
            // 
            this.TableLayoutOculta.ColumnCount = 1;
            this.TableLayoutOculta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutOculta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutOculta.Controls.Add(this.LblOcultoIdCliente, 0, 0);
            this.TableLayoutOculta.Controls.Add(this.LblOcultoIdVeiculo, 0, 1);
            this.TableLayoutOculta.Location = new System.Drawing.Point(278, 483);
            this.TableLayoutOculta.Name = "TableLayoutOculta";
            this.TableLayoutOculta.RowCount = 2;
            this.TableLayoutOculta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutOculta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutOculta.Size = new System.Drawing.Size(177, 40);
            this.TableLayoutOculta.TabIndex = 10;
            // 
            // PicCliente
            // 
            this.PicCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicCliente.Image = global::EstacionamentoForms.Properties.Resources.de7834s_6515bd40_8b2c_4dc6_a843_5ac1a95a8b55;
            this.PicCliente.Location = new System.Drawing.Point(71, 279);
            this.PicCliente.Name = "PicCliente";
            this.PicCliente.Size = new System.Drawing.Size(149, 180);
            this.PicCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCliente.TabIndex = 3;
            this.PicCliente.TabStop = false;
            // 
            // CadastroTicketForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.TableLayoutOculta);
            this.Controls.Add(this.DataGridViewVeiculosCliente);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PicCliente);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIniciarTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroTicketForm";
            this.Text = "Cadastrar Ticket";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVeiculosCliente)).EndInit();
            this.TableLayoutOculta.ResumeLayout(false);
            this.TableLayoutOculta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Propriedades
        private Button BtnIniciarTicket;
        private Button BtnCancelar;
        private PictureBox PicCliente;
        private TableLayoutPanel tableLayoutPanel1;

        private Label LblId;
        private Label LblStatus;
        private Label LblCliente;
        private Label LblDecricao;
        private Label LblEntrada;
        private Label LblSaida;
        private Label LblTempoEstacionado;

        private TextBox TxtBoxDescricao;

        private TextBox TxtBoxEntrada;
        private TextBox CmbBoxCor;

        private TextBox TxtBoxId;
        private TextBox TxtBoxDataCadastro;

        private TextBox TxtBoxAtivo;
        private TextBox TxtBoxNomeCliente;
        private TextBox TxtBoxModelo;
        private RadioButton RdoIdCliente;
        private RadioButton RdoCpf;
        private MaskedTextBox MkdTxtPesquisa;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnAction;
        #endregion

        private DataGridView DataGridViewVeiculosCliente;
        private RadioButton RdoIdVeiculo;
        private RadioButton RdoPlaca;
        private Label LblValorTicket;
        private Label LblOcultoIdVeiculo;
        private Label LblOcultoIdCliente;
        private TableLayoutPanel TableLayoutOculta;
    }
}