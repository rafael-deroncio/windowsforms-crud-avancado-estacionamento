using System.Windows.Forms;

namespace EstacionamentoForms
{
    partial class ListagemClienteForm
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblId = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblTelCelular = new System.Windows.Forms.Label();
            this.LblDataCadastro = new System.Windows.Forms.Label();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.TxtBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.TxtBoxDataCadastro = new System.Windows.Forms.TextBox();
            this.MaskTxtBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.MaskTxtBoxTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.PicCliente = new System.Windows.Forms.PictureBox();
            this.DataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCancelar.Location = new System.Drawing.Point(375, 526);
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
            this.tableLayoutPanel1.Controls.Add(this.LblNome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblCpf, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblTelCelular, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblDataCadastro, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxNomeCompleto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxDataCadastro, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.MaskTxtBoxCpf, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MaskTxtBoxTelefoneCelular, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(248, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 180);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // LblId
            // 
            this.LblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblId.Location = new System.Drawing.Point(6, 3);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(191, 32);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID Cliente:";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblNome
            // 
            this.LblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNome.Location = new System.Drawing.Point(6, 38);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(191, 32);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Cliente:";
            this.LblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCpf
            // 
            this.LblCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCpf.Location = new System.Drawing.Point(6, 73);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(191, 32);
            this.LblCpf.TabIndex = 2;
            this.LblCpf.Text = "CPF:";
            this.LblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTelCelular
            // 
            this.LblTelCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTelCelular.Location = new System.Drawing.Point(6, 108);
            this.LblTelCelular.Name = "LblTelCelular";
            this.LblTelCelular.Size = new System.Drawing.Size(191, 32);
            this.LblTelCelular.TabIndex = 3;
            this.LblTelCelular.Text = "Núm. Telefone Celular:";
            this.LblTelCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDataCadastro
            // 
            this.LblDataCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDataCadastro.Location = new System.Drawing.Point(6, 143);
            this.LblDataCadastro.Name = "LblDataCadastro";
            this.LblDataCadastro.Size = new System.Drawing.Size(191, 34);
            this.LblDataCadastro.TabIndex = 4;
            this.LblDataCadastro.Text = "Data Cadastro:";
            this.LblDataCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.TxtBoxId.TabIndex = 5;
            this.TxtBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxNomeCompleto
            // 
            this.TxtBoxNomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxNomeCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxNomeCompleto.Location = new System.Drawing.Point(206, 41);
            this.TxtBoxNomeCompleto.Name = "TxtBoxNomeCompleto";
            this.TxtBoxNomeCompleto.ReadOnly = true;
            this.TxtBoxNomeCompleto.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxNomeCompleto.TabIndex = 6;
            this.TxtBoxNomeCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxDataCadastro
            // 
            this.TxtBoxDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxDataCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxDataCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxDataCadastro.Location = new System.Drawing.Point(206, 146);
            this.TxtBoxDataCadastro.Name = "TxtBoxDataCadastro";
            this.TxtBoxDataCadastro.ReadOnly = true;
            this.TxtBoxDataCadastro.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxDataCadastro.TabIndex = 7;
            this.TxtBoxDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaskTxtBoxCpf
            // 
            this.MaskTxtBoxCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaskTxtBoxCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaskTxtBoxCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaskTxtBoxCpf.Location = new System.Drawing.Point(206, 76);
            this.MaskTxtBoxCpf.Name = "MaskTxtBoxCpf";
            this.MaskTxtBoxCpf.ReadOnly = true;
            this.MaskTxtBoxCpf.Size = new System.Drawing.Size(291, 15);
            this.MaskTxtBoxCpf.TabIndex = 8;
            this.MaskTxtBoxCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaskTxtBoxTelefoneCelular
            // 
            this.MaskTxtBoxTelefoneCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaskTxtBoxTelefoneCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaskTxtBoxTelefoneCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaskTxtBoxTelefoneCelular.Location = new System.Drawing.Point(206, 111);
            this.MaskTxtBoxTelefoneCelular.Name = "MaskTxtBoxTelefoneCelular";
            this.MaskTxtBoxTelefoneCelular.ReadOnly = true;
            this.MaskTxtBoxTelefoneCelular.Size = new System.Drawing.Size(291, 15);
            this.MaskTxtBoxTelefoneCelular.TabIndex = 9;
            this.MaskTxtBoxTelefoneCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PicCliente
            // 
            this.PicCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicCliente.Image = global::EstacionamentoForms.Properties.Resources.de7834s_6515bd40_8b2c_4dc6_a843_5ac1a95a8b55;
            this.PicCliente.Location = new System.Drawing.Point(93, 17);
            this.PicCliente.Name = "PicCliente";
            this.PicCliente.Size = new System.Drawing.Size(149, 180);
            this.PicCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCliente.TabIndex = 3;
            this.PicCliente.TabStop = false;
            // 
            // DataGridViewClientes
            // 
            this.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewClientes.Location = new System.Drawing.Point(93, 204);
            this.DataGridViewClientes.Name = "DataGridViewClientes";
            this.DataGridViewClientes.RowHeadersWidth = 51;
            this.DataGridViewClientes.RowTemplate.Height = 24;
            this.DataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewClientes.Size = new System.Drawing.Size(658, 313);
            this.DataGridViewClientes.TabIndex = 5;
            this.DataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClientes_CellClick);
            this.DataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClientes_CellClick);
            // 
            // ListagemClienteForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.DataGridViewClientes);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PicCliente);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListagemClienteForm";
            this.Text = "Cadastrar Cliente";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnCancelar;
        private PictureBox PicCliente;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LblId;
        private Label LblNome;
        private Label LblCpf;
        private Label LblTelCelular;
        private Label LblDataCadastro;
        private TextBox TxtBoxId;
        private TextBox TxtBoxNomeCompleto;
        private TextBox TxtBoxDataCadastro;
        private MaskedTextBox MaskTxtBoxCpf;
        private MaskedTextBox MaskTxtBoxTelefoneCelular;
        private DataGridView DataGridViewClientes;
    }
}