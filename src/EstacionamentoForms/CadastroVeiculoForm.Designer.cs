using System.Windows.Forms;

namespace EstacionamentoForms
{
    partial class CadastroVeiculoForm
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.TxtBoxDataCadastro = new System.Windows.Forms.TextBox();
            this.LblIdCliente = new System.Windows.Forms.Label();
            this.LblNomeCliente = new System.Windows.Forms.Label();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.LblFabricante = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblCor = new System.Windows.Forms.Label();
            this.LblDataCadastro = new System.Windows.Forms.Label();
            this.MkdTxtBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxIdCliente = new System.Windows.Forms.TextBox();
            this.TxtBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.CmbBoxFabricante = new System.Windows.Forms.ComboBox();
            this.CmbBoxCor = new System.Windows.Forms.ComboBox();
            this.TxtBoxModelo = new System.Windows.Forms.TextBox();
            this.PicCliente = new System.Windows.Forms.PictureBox();
            this.RdoIdCliente = new System.Windows.Forms.RadioButton();
            this.RdoCpf = new System.Windows.Forms.RadioButton();
            this.MkdTxtPesquisaCliente = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblPesquisaCLiente = new System.Windows.Forms.Label();
            this.BtnAction = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.ForeColor = System.Drawing.Color.Green;
            this.BtnSalvar.Location = new System.Drawing.Point(626, 523);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnSalvar.Size = new System.Drawing.Size(92, 23);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCancelar.Location = new System.Drawing.Point(739, 523);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 23);
            this.BtnCancelar.TabIndex = 8;
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
            this.tableLayoutPanel1.Controls.Add(this.LblIdCliente, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblNomeCliente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblPlaca, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblFabricante, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblModelo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblCor, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LblDataCadastro, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.MkdTxtBoxPlaca, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxIdCliente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxNomeCliente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CmbBoxFabricante, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CmbBoxCor, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxModelo, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(226, 147);
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
            this.LblId.Text = "ID Veículo:";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxId.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxId.Location = new System.Drawing.Point(206, 6);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.ReadOnly = true;
            this.TxtBoxId.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxId.TabIndex = 1;
            this.TxtBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxDataCadastro
            // 
            this.TxtBoxDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxDataCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxDataCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxDataCadastro.Location = new System.Drawing.Point(206, 195);
            this.TxtBoxDataCadastro.Name = "TxtBoxDataCadastro";
            this.TxtBoxDataCadastro.ReadOnly = true;
            this.TxtBoxDataCadastro.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxDataCadastro.TabIndex = 8;
            this.TxtBoxDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblIdCliente.Location = new System.Drawing.Point(6, 30);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(191, 24);
            this.LblIdCliente.TabIndex = 0;
            this.LblIdCliente.Text = "ID Cliente:";
            this.LblIdCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblNomeCliente
            // 
            this.LblNomeCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNomeCliente.Location = new System.Drawing.Point(6, 57);
            this.LblNomeCliente.Name = "LblNomeCliente";
            this.LblNomeCliente.Size = new System.Drawing.Size(191, 24);
            this.LblNomeCliente.TabIndex = 0;
            this.LblNomeCliente.Text = "Cliente:";
            this.LblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPlaca
            // 
            this.LblPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPlaca.Location = new System.Drawing.Point(6, 84);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(191, 24);
            this.LblPlaca.TabIndex = 0;
            this.LblPlaca.Text = "Placa:";
            this.LblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblFabricante
            // 
            this.LblFabricante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFabricante.Location = new System.Drawing.Point(6, 111);
            this.LblFabricante.Name = "LblFabricante";
            this.LblFabricante.Size = new System.Drawing.Size(191, 24);
            this.LblFabricante.TabIndex = 0;
            this.LblFabricante.Text = "Fabricante:";
            this.LblFabricante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblModelo
            // 
            this.LblModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblModelo.Location = new System.Drawing.Point(6, 138);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(191, 24);
            this.LblModelo.TabIndex = 0;
            this.LblModelo.Text = "Modelo:";
            this.LblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCor
            // 
            this.LblCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCor.Location = new System.Drawing.Point(6, 165);
            this.LblCor.Name = "LblCor";
            this.LblCor.Size = new System.Drawing.Size(191, 24);
            this.LblCor.TabIndex = 0;
            this.LblCor.Text = "Cor:";
            this.LblCor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDataCadastro
            // 
            this.LblDataCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDataCadastro.Location = new System.Drawing.Point(6, 192);
            this.LblDataCadastro.Name = "LblDataCadastro";
            this.LblDataCadastro.Size = new System.Drawing.Size(191, 29);
            this.LblDataCadastro.TabIndex = 0;
            this.LblDataCadastro.Text = "Data Cadastro:";
            this.LblDataCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MkdTxtBoxPlaca
            // 
            this.MkdTxtBoxPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MkdTxtBoxPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MkdTxtBoxPlaca.Location = new System.Drawing.Point(206, 87);
            this.MkdTxtBoxPlaca.Mask = "AAA AAAA";
            this.MkdTxtBoxPlaca.Name = "MkdTxtBoxPlaca";
            this.MkdTxtBoxPlaca.Size = new System.Drawing.Size(291, 22);
            this.MkdTxtBoxPlaca.TabIndex = 3;
            this.MkdTxtBoxPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxIdCliente
            // 
            this.TxtBoxIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxIdCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxIdCliente.Location = new System.Drawing.Point(206, 33);
            this.TxtBoxIdCliente.Name = "TxtBoxIdCliente";
            this.TxtBoxIdCliente.ReadOnly = true;
            this.TxtBoxIdCliente.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxIdCliente.TabIndex = 2;
            this.TxtBoxIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxNomeCliente
            // 
            this.TxtBoxNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxNomeCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxNomeCliente.Location = new System.Drawing.Point(206, 60);
            this.TxtBoxNomeCliente.Name = "TxtBoxNomeCliente";
            this.TxtBoxNomeCliente.ReadOnly = true;
            this.TxtBoxNomeCliente.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxNomeCliente.TabIndex = 3;
            this.TxtBoxNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CmbBoxFabricante
            // 
            this.CmbBoxFabricante.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CmbBoxFabricante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbBoxFabricante.Location = new System.Drawing.Point(206, 114);
            this.CmbBoxFabricante.Name = "CmbBoxFabricante";
            this.CmbBoxFabricante.Size = new System.Drawing.Size(291, 24);
            this.CmbBoxFabricante.TabIndex = 4;
            this.CmbBoxFabricante.Text = "Fabricante";
            this.CmbBoxFabricante.UseWaitCursor = true;
            this.CmbBoxFabricante.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CmbBoxFabricante_DrawItem);
            // 
            // CmbBoxCor
            // 
            this.CmbBoxCor.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CmbBoxCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbBoxCor.Location = new System.Drawing.Point(206, 168);
            this.CmbBoxCor.Name = "CmbBoxCor";
            this.CmbBoxCor.Size = new System.Drawing.Size(291, 24);
            this.CmbBoxCor.TabIndex = 6;
            this.CmbBoxCor.Text = "Cor";
            this.CmbBoxCor.UseWaitCursor = true;
            this.CmbBoxCor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CmbBoxCor_DrawItem);
            // 
            // TxtBoxModelo
            // 
            this.TxtBoxModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxModelo.Location = new System.Drawing.Point(206, 141);
            this.TxtBoxModelo.Name = "TxtBoxModelo";
            this.TxtBoxModelo.Size = new System.Drawing.Size(291, 22);
            this.TxtBoxModelo.TabIndex = 5;
            this.TxtBoxModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PicCliente
            // 
            this.PicCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicCliente.Image = global::EstacionamentoForms.Properties.Resources.de7834s_6515bd40_8b2c_4dc6_a843_5ac1a95a8b55;
            this.PicCliente.Location = new System.Drawing.Point(71, 173);
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
            this.RdoIdCliente.Location = new System.Drawing.Point(121, 3);
            this.RdoIdCliente.Name = "RdoIdCliente";
            this.RdoIdCliente.Size = new System.Drawing.Size(83, 28);
            this.RdoIdCliente.TabIndex = 1;
            this.RdoIdCliente.TabStop = true;
            this.RdoIdCliente.Text = "Id Cliente";
            this.RdoIdCliente.UseVisualStyleBackColor = true;
            this.RdoIdCliente.Click += new System.EventHandler(this.RdoIdCliente_Click);
            // 
            // RdoCpf
            // 
            this.RdoCpf.AutoSize = true;
            this.RdoCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoCpf.Location = new System.Drawing.Point(210, 3);
            this.RdoCpf.Name = "RdoCpf";
            this.RdoCpf.Size = new System.Drawing.Size(54, 28);
            this.RdoCpf.TabIndex = 6;
            this.RdoCpf.TabStop = true;
            this.RdoCpf.Text = "CPF";
            this.RdoCpf.UseVisualStyleBackColor = true;
            this.RdoCpf.Click += new System.EventHandler(this.RdoCpf_Click);
            // 
            // MkdTxtPesquisaCliente
            // 
            this.MkdTxtPesquisaCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MkdTxtPesquisaCliente.Location = new System.Drawing.Point(270, 6);
            this.MkdTxtPesquisaCliente.Name = "MkdTxtPesquisaCliente";
            this.MkdTxtPesquisaCliente.Size = new System.Drawing.Size(250, 22);
            this.MkdTxtPesquisaCliente.TabIndex = 9;
            this.MkdTxtPesquisaCliente.Click += new System.EventHandler(this.MkdTxtPesquisaCliente_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.LblPesquisaCLiente);
            this.flowLayoutPanel1.Controls.Add(this.RdoIdCliente);
            this.flowLayoutPanel1.Controls.Add(this.RdoCpf);
            this.flowLayoutPanel1.Controls.Add(this.MkdTxtPesquisaCliente);
            this.flowLayoutPanel1.Controls.Add(this.BtnAction);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(658, 37);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // LblPesquisaCLiente
            // 
            this.LblPesquisaCLiente.AutoSize = true;
            this.LblPesquisaCLiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPesquisaCLiente.Location = new System.Drawing.Point(3, 0);
            this.LblPesquisaCLiente.Name = "LblPesquisaCLiente";
            this.LblPesquisaCLiente.Size = new System.Drawing.Size(112, 34);
            this.LblPesquisaCLiente.TabIndex = 0;
            this.LblPesquisaCLiente.Text = "Pesquisar Cliente";
            this.LblPesquisaCLiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnAction
            // 
            this.BtnAction.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAction.ForeColor = System.Drawing.Color.Blue;
            this.BtnAction.Location = new System.Drawing.Point(526, 3);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(120, 28);
            this.BtnAction.TabIndex = 1;
            this.BtnAction.Text = "Pesquisar";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // CadastroVeiculoForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PicCliente);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroVeiculoForm";
            this.Text = "Cadastrar Veículo";
            this.Load += new System.EventHandler(this.CadastroVeiculoForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Propriedades
        private Button BtnSalvar;
        private Button BtnCancelar;
        private PictureBox PicCliente;
        private TableLayoutPanel tableLayoutPanel1;

        private Label LblId;
        private Label LblIdCliente;
        private Label LblNomeCliente;
        private Label LblPlaca;
        private Label LblFabricante;
        private Label LblModelo;
        private Label LblCor;
        private Label LblDataCadastro;

        private MaskedTextBox MkdTxtBoxPlaca;

        private ComboBox CmbBoxFabricante;
        private ComboBox CmbBoxCor;

        private TextBox TxtBoxId;
        private TextBox TxtBoxDataCadastro;

        private TextBox TxtBoxIdCliente;
        private TextBox TxtBoxNomeCliente;
        private TextBox TxtBoxModelo;
        private RadioButton RdoIdCliente;
        private RadioButton RdoCpf;
        private MaskedTextBox MkdTxtPesquisaCliente;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LblPesquisaCLiente;
        private Button BtnAction;
        #endregion
    }
}