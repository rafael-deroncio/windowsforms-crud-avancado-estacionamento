using System.Windows.Forms;

namespace EstacionamentoForms
{
    partial class FecharTicketForm
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
            this.BtnFecharTicket = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.TxtBoxValorTicket = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblDecricao = new System.Windows.Forms.Label();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.LblSaida = new System.Windows.Forms.Label();
            this.LblTempoEstacionado = new System.Windows.Forms.Label();
            this.LblValorTicket = new System.Windows.Forms.Label();
            this.TxtBoxDescricao = new System.Windows.Forms.TextBox();
            this.TxtBoxAtivo = new System.Windows.Forms.TextBox();
            this.TxtBoxCliente = new System.Windows.Forms.TextBox();
            this.TxtBoxEntrada = new System.Windows.Forms.TextBox();
            this.TxtBoxTempoEstacionado = new System.Windows.Forms.TextBox();
            this.TxtBoxSaida = new System.Windows.Forms.TextBox();
            this.PicCliente = new System.Windows.Forms.PictureBox();
            this.RdoIdCliente = new System.Windows.Forms.RadioButton();
            this.RdoCpf = new System.Windows.Forms.RadioButton();
            this.MkdTxtPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RdoIdVeiculo = new System.Windows.Forms.RadioButton();
            this.RdoPlaca = new System.Windows.Forms.RadioButton();
            this.RdoIdTicket = new System.Windows.Forms.RadioButton();
            this.BtnAction = new System.Windows.Forms.Button();
            this.DataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.TableLayoutOculta = new System.Windows.Forms.TableLayoutPanel();
            this.LblOcultoIdTickt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTickets)).BeginInit();
            this.TableLayoutOculta.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFecharTicket
            // 
            this.BtnFecharTicket.Enabled = false;
            this.BtnFecharTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFecharTicket.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnFecharTicket.Location = new System.Drawing.Point(626, 523);
            this.BtnFecharTicket.Name = "BtnFecharTicket";
            this.BtnFecharTicket.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnFecharTicket.Size = new System.Drawing.Size(92, 23);
            this.BtnFecharTicket.TabIndex = 1;
            this.BtnFecharTicket.Text = "Fechar Ticket";
            this.BtnFecharTicket.UseVisualStyleBackColor = true;
            this.BtnFecharTicket.Click += new System.EventHandler(this.BtnFecharTicket_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxValorTicket, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.LblStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblCliente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblDecricao, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblEntrada, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblSaida, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblTempoEstacionado, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LblValorTicket, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxDescricao, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxAtivo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxCliente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxEntrada, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxTempoEstacionado, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxSaida, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(226, 253);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 224);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // LblId
            // 
            this.LblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblId.Location = new System.Drawing.Point(6, 3);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(191, 24);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID Ticket:";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxId.Location = new System.Drawing.Point(206, 6);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.ReadOnly = true;
            this.TxtBoxId.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxId.TabIndex = 1;
            // 
            // TxtBoxValorTicket
            // 
            this.TxtBoxValorTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxValorTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxValorTicket.Location = new System.Drawing.Point(206, 195);
            this.TxtBoxValorTicket.Name = "TxtBoxValorTicket";
            this.TxtBoxValorTicket.ReadOnly = true;
            this.TxtBoxValorTicket.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxValorTicket.TabIndex = 8;
            // 
            // LblStatus
            // 
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblStatus.Location = new System.Drawing.Point(6, 30);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(191, 24);
            this.LblStatus.TabIndex = 0;
            this.LblStatus.Text = "Status Ticket:";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCliente
            // 
            this.LblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCliente.Location = new System.Drawing.Point(6, 57);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(191, 24);
            this.LblCliente.TabIndex = 0;
            this.LblCliente.Text = "Cliente";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDecricao
            // 
            this.LblDecricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDecricao.Location = new System.Drawing.Point(6, 84);
            this.LblDecricao.Name = "LblDecricao";
            this.LblDecricao.Size = new System.Drawing.Size(191, 24);
            this.LblDecricao.TabIndex = 0;
            this.LblDecricao.Text = "Veículo:";
            this.LblDecricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblEntrada
            // 
            this.LblEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEntrada.Location = new System.Drawing.Point(6, 111);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(191, 24);
            this.LblEntrada.TabIndex = 0;
            this.LblEntrada.Text = "Entrada:";
            this.LblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblSaida
            // 
            this.LblSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSaida.Location = new System.Drawing.Point(6, 138);
            this.LblSaida.Name = "LblSaida";
            this.LblSaida.Size = new System.Drawing.Size(191, 24);
            this.LblSaida.TabIndex = 0;
            this.LblSaida.Text = "Saída:";
            this.LblSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTempoEstacionado
            // 
            this.LblTempoEstacionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTempoEstacionado.Location = new System.Drawing.Point(6, 165);
            this.LblTempoEstacionado.Name = "LblTempoEstacionado";
            this.LblTempoEstacionado.Size = new System.Drawing.Size(191, 24);
            this.LblTempoEstacionado.TabIndex = 0;
            this.LblTempoEstacionado.Text = "Tempo Estacionado:";
            this.LblTempoEstacionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblValorTicket
            // 
            this.LblValorTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblValorTicket.Location = new System.Drawing.Point(6, 192);
            this.LblValorTicket.Name = "LblValorTicket";
            this.LblValorTicket.Size = new System.Drawing.Size(191, 29);
            this.LblValorTicket.TabIndex = 0;
            this.LblValorTicket.Text = "Valor Ticket:";
            this.LblValorTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBoxDescricao
            // 
            this.TxtBoxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxDescricao.Location = new System.Drawing.Point(206, 87);
            this.TxtBoxDescricao.Name = "TxtBoxDescricao";
            this.TxtBoxDescricao.ReadOnly = true;
            this.TxtBoxDescricao.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxDescricao.TabIndex = 4;
            // 
            // TxtBoxAtivo
            // 
            this.TxtBoxAtivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxAtivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxAtivo.Location = new System.Drawing.Point(206, 33);
            this.TxtBoxAtivo.Name = "TxtBoxAtivo";
            this.TxtBoxAtivo.ReadOnly = true;
            this.TxtBoxAtivo.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxAtivo.TabIndex = 2;
            // 
            // TxtBoxCliente
            // 
            this.TxtBoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxCliente.Location = new System.Drawing.Point(206, 60);
            this.TxtBoxCliente.Name = "TxtBoxCliente";
            this.TxtBoxCliente.ReadOnly = true;
            this.TxtBoxCliente.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxCliente.TabIndex = 3;
            // 
            // TxtBoxEntrada
            // 
            this.TxtBoxEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxEntrada.Location = new System.Drawing.Point(206, 114);
            this.TxtBoxEntrada.Name = "TxtBoxEntrada";
            this.TxtBoxEntrada.ReadOnly = true;
            this.TxtBoxEntrada.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxEntrada.TabIndex = 5;
            this.TxtBoxEntrada.UseWaitCursor = true;
            // 
            // TxtBoxTempoEstacionado
            // 
            this.TxtBoxTempoEstacionado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxTempoEstacionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxTempoEstacionado.Location = new System.Drawing.Point(206, 168);
            this.TxtBoxTempoEstacionado.Name = "TxtBoxTempoEstacionado";
            this.TxtBoxTempoEstacionado.ReadOnly = true;
            this.TxtBoxTempoEstacionado.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxTempoEstacionado.TabIndex = 7;
            this.TxtBoxTempoEstacionado.UseWaitCursor = true;
            // 
            // TxtBoxSaida
            // 
            this.TxtBoxSaida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxSaida.Location = new System.Drawing.Point(206, 141);
            this.TxtBoxSaida.Name = "TxtBoxSaida";
            this.TxtBoxSaida.ReadOnly = true;
            this.TxtBoxSaida.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxSaida.TabIndex = 6;
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
            this.RdoIdCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.RdoCpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdoCpf.UseVisualStyleBackColor = true;
            this.RdoCpf.Click += new System.EventHandler(this.RdoCpf_Click);
            // 
            // MkdTxtPesquisa
            // 
            this.MkdTxtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MkdTxtPesquisa.Location = new System.Drawing.Point(389, 6);
            this.MkdTxtPesquisa.Name = "MkdTxtPesquisa";
            this.MkdTxtPesquisa.Size = new System.Drawing.Size(153, 22);
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
            this.flowLayoutPanel1.Controls.Add(this.RdoIdTicket);
            this.flowLayoutPanel1.Controls.Add(this.MkdTxtPesquisa);
            this.flowLayoutPanel1.Controls.Add(this.BtnAction);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(658, 37);
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
            this.RdoIdVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.RdoPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdoPlaca.UseVisualStyleBackColor = true;
            // 
            // RdoIdTicket
            // 
            this.RdoIdTicket.AutoSize = true;
            this.RdoIdTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoIdTicket.Location = new System.Drawing.Point(318, 3);
            this.RdoIdTicket.Name = "RdoIdTicket";
            this.RdoIdTicket.Size = new System.Drawing.Size(65, 28);
            this.RdoIdTicket.TabIndex = 10;
            this.RdoIdTicket.TabStop = true;
            this.RdoIdTicket.Text = "Ticket";
            this.RdoIdTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RdoIdTicket.UseVisualStyleBackColor = true;
            // 
            // BtnAction
            // 
            this.BtnAction.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAction.ForeColor = System.Drawing.Color.Blue;
            this.BtnAction.Location = new System.Drawing.Point(548, 3);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(105, 28);
            this.BtnAction.TabIndex = 8;
            this.BtnAction.Text = "Pesquisar";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // DataGridViewTickets
            // 
            this.DataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTickets.Location = new System.Drawing.Point(71, 92);
            this.DataGridViewTickets.Name = "DataGridViewTickets";
            this.DataGridViewTickets.RowHeadersWidth = 51;
            this.DataGridViewTickets.Size = new System.Drawing.Size(658, 111);
            this.DataGridViewTickets.TabIndex = 9;
            this.DataGridViewTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTickets_CellClick);
            // 
            // TableLayoutOculta
            // 
            this.TableLayoutOculta.ColumnCount = 1;
            this.TableLayoutOculta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutOculta.Controls.Add(this.LblOcultoIdTickt, 0, 0);
            this.TableLayoutOculta.Location = new System.Drawing.Point(278, 483);
            this.TableLayoutOculta.Name = "TableLayoutOculta";
            this.TableLayoutOculta.RowCount = 1;
            this.TableLayoutOculta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutOculta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutOculta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutOculta.Size = new System.Drawing.Size(177, 34);
            this.TableLayoutOculta.TabIndex = 10;
            this.TableLayoutOculta.Visible = false;
            // 
            // LblOcultoIdTickt
            // 
            this.LblOcultoIdTickt.AutoSize = true;
            this.LblOcultoIdTickt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblOcultoIdTickt.Location = new System.Drawing.Point(3, 0);
            this.LblOcultoIdTickt.Name = "LblOcultoIdTickt";
            this.LblOcultoIdTickt.Size = new System.Drawing.Size(171, 34);
            this.LblOcultoIdTickt.TabIndex = 0;
            this.LblOcultoIdTickt.Text = "LblOcultoIdTickt";
            this.LblOcultoIdTickt.Visible = false;
            // 
            // FecharTicketForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.TableLayoutOculta);
            this.Controls.Add(this.DataGridViewTickets);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PicCliente);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnFecharTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FecharTicketForm";
            this.Text = "Fechar Ticket";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTickets)).EndInit();
            this.TableLayoutOculta.ResumeLayout(false);
            this.TableLayoutOculta.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Propriedades
        private Button BtnFecharTicket;
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
        private TextBox TxtBoxTempoEstacionado;

        private TextBox TxtBoxId;
        private TextBox TxtBoxValorTicket;

        private TextBox TxtBoxAtivo;
        private TextBox TxtBoxCliente;
        private TextBox TxtBoxSaida;
        private RadioButton RdoIdCliente;
        private RadioButton RdoCpf;
        private MaskedTextBox MkdTxtPesquisa;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnAction;
        

        private DataGridView DataGridViewTickets;
        private RadioButton RdoIdVeiculo;
        private RadioButton RdoPlaca;
        private Label LblValorTicket;
        private TableLayoutPanel TableLayoutOculta;
        private RadioButton RdoIdTicket;
        #endregion

        private Label LblOcultoIdTickt;
    }
}