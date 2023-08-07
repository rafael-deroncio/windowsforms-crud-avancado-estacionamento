using System.Windows.Forms;

namespace EstacionamentoForms
{
    partial class CadastroClienteForm
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).BeginInit();
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
            this.BtnSalvar.TabIndex = 4;
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
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Sair";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.869757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.75938F));
            this.tableLayoutPanel1.Controls.Add(this.LblId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblNome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblCpf, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblTelCelular, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblDataCadastro, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxId, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxNomeCompleto, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxDataCadastro, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.MaskTxtBoxCpf, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.MaskTxtBoxTelefoneCelular, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(276, 173);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 180);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // LblId
            // 
            this.LblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblId.Location = new System.Drawing.Point(3, 0);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(195, 36);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID:";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblNome
            // 
            this.LblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNome.Location = new System.Drawing.Point(3, 36);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(195, 36);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome Completo:";
            this.LblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCpf
            // 
            this.LblCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCpf.Location = new System.Drawing.Point(3, 72);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(195, 36);
            this.LblCpf.TabIndex = 2;
            this.LblCpf.Text = "CPF:";
            this.LblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTelCelular
            // 
            this.LblTelCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTelCelular.Location = new System.Drawing.Point(3, 108);
            this.LblTelCelular.Name = "LblTelCelular";
            this.LblTelCelular.Size = new System.Drawing.Size(195, 36);
            this.LblTelCelular.TabIndex = 3;
            this.LblTelCelular.Text = "Número tel. Celular:";
            this.LblTelCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDataCadastro
            // 
            this.LblDataCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDataCadastro.Location = new System.Drawing.Point(3, 144);
            this.LblDataCadastro.Name = "LblDataCadastro";
            this.LblDataCadastro.Size = new System.Drawing.Size(195, 36);
            this.LblDataCadastro.TabIndex = 4;
            this.LblDataCadastro.Text = "Data Cadastro:";
            this.LblDataCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxId.Location = new System.Drawing.Point(216, 3);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.ReadOnly = true;
            this.TxtBoxId.Size = new System.Drawing.Size(234, 22);
            this.TxtBoxId.TabIndex = 5;
            this.TxtBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxNomeCompleto
            // 
            this.TxtBoxNomeCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxNomeCompleto.Location = new System.Drawing.Point(216, 39);
            this.TxtBoxNomeCompleto.Name = "TxtBoxNomeCompleto";
            this.TxtBoxNomeCompleto.Size = new System.Drawing.Size(234, 22);
            this.TxtBoxNomeCompleto.TabIndex = 1;
            this.TxtBoxNomeCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxDataCadastro
            // 
            this.TxtBoxDataCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxDataCadastro.Location = new System.Drawing.Point(216, 147);
            this.TxtBoxDataCadastro.Name = "TxtBoxDataCadastro";
            this.TxtBoxDataCadastro.ReadOnly = true;
            this.TxtBoxDataCadastro.Size = new System.Drawing.Size(234, 22);
            this.TxtBoxDataCadastro.TabIndex = 7;
            this.TxtBoxDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaskTxtBoxCpf
            // 
            this.MaskTxtBoxCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaskTxtBoxCpf.Location = new System.Drawing.Point(216, 75);
            this.MaskTxtBoxCpf.Mask = "000.000.000-00";
            this.MaskTxtBoxCpf.Name = "MaskTxtBoxCpf";
            this.MaskTxtBoxCpf.Size = new System.Drawing.Size(234, 22);
            this.MaskTxtBoxCpf.TabIndex = 2;
            this.MaskTxtBoxCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaskTxtBoxTelefoneCelular
            // 
            this.MaskTxtBoxTelefoneCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaskTxtBoxTelefoneCelular.Location = new System.Drawing.Point(216, 111);
            this.MaskTxtBoxTelefoneCelular.Mask = "(00) 9 0000-0000";
            this.MaskTxtBoxTelefoneCelular.Name = "MaskTxtBoxTelefoneCelular";
            this.MaskTxtBoxTelefoneCelular.Size = new System.Drawing.Size(234, 22);
            this.MaskTxtBoxTelefoneCelular.TabIndex = 3;
            this.MaskTxtBoxTelefoneCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // CadastroClienteForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PicCliente);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroClienteForm";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.CadastroClienteForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnSalvar;
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
    }
}