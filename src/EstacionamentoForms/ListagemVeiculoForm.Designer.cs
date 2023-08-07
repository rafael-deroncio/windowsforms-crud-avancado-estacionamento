using System.Reflection;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    partial class ListagemVeiculoForm
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
            this.LblIdCliente = new System.Windows.Forms.Label();
            this.LblNomeCliente = new System.Windows.Forms.Label();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.LblFabricante = new System.Windows.Forms.Label();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.TxtBoxIdCliente = new System.Windows.Forms.TextBox();
            this.TxtBoxFabricante = new System.Windows.Forms.TextBox();
            this.TxtBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.TxtBoxPlaca = new System.Windows.Forms.TextBox();
            this.TxtBoxModelo = new System.Windows.Forms.TextBox();
            this.TxtBoxCor = new System.Windows.Forms.TextBox();
            this.TxtBoxDataCadastro = new System.Windows.Forms.TextBox();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblCor = new System.Windows.Forms.Label();
            this.LblDataCadastro = new System.Windows.Forms.Label();
            this.PicCliente = new System.Windows.Forms.PictureBox();
            this.DataGridViewVeiculos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCancelar.Location = new System.Drawing.Point(375, 526);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 23);
            this.BtnCancelar.TabIndex = 16;
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
            this.tableLayoutPanel1.Controls.Add(this.LblIdCliente, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblNomeCliente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblPlaca, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblFabricante, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxIdCliente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxFabricante, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxNomeCliente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxPlaca, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxModelo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxCor, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxDataCadastro, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.LblModelo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblCor, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LblDataCadastro, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(248, 17);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 180);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // LblId
            // 
            this.LblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblId.Location = new System.Drawing.Point(6, 3);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(191, 19);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID Veículo:";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblIdCliente
            // 
            this.LblIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblIdCliente.Location = new System.Drawing.Point(6, 25);
            this.LblIdCliente.Name = "LblIdCliente";
            this.LblIdCliente.Size = new System.Drawing.Size(191, 19);
            this.LblIdCliente.TabIndex = 1;
            this.LblIdCliente.Text = "ID Cliente:";
            this.LblIdCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblNomeCliente
            // 
            this.LblNomeCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNomeCliente.Location = new System.Drawing.Point(6, 47);
            this.LblNomeCliente.Name = "LblNomeCliente";
            this.LblNomeCliente.Size = new System.Drawing.Size(191, 19);
            this.LblNomeCliente.TabIndex = 2;
            this.LblNomeCliente.Text = "Cliente:";
            this.LblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPlaca
            // 
            this.LblPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPlaca.Location = new System.Drawing.Point(6, 69);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(191, 19);
            this.LblPlaca.TabIndex = 3;
            this.LblPlaca.Text = "Placa:";
            this.LblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblFabricante
            // 
            this.LblFabricante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFabricante.Location = new System.Drawing.Point(6, 91);
            this.LblFabricante.Name = "LblFabricante";
            this.LblFabricante.Size = new System.Drawing.Size(191, 19);
            this.LblFabricante.TabIndex = 4;
            this.LblFabricante.Text = "Fabricante:";
            this.LblFabricante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.TxtBoxId.TabIndex = 8;
            this.TxtBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxIdCliente
            // 
            this.TxtBoxIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxIdCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxIdCliente.Location = new System.Drawing.Point(206, 28);
            this.TxtBoxIdCliente.Name = "TxtBoxIdCliente";
            this.TxtBoxIdCliente.ReadOnly = true;
            this.TxtBoxIdCliente.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxIdCliente.TabIndex = 9;
            this.TxtBoxIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxFabricante
            // 
            this.TxtBoxFabricante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxFabricante.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxFabricante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxFabricante.Location = new System.Drawing.Point(206, 94);
            this.TxtBoxFabricante.Name = "TxtBoxFabricante";
            this.TxtBoxFabricante.ReadOnly = true;
            this.TxtBoxFabricante.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxFabricante.TabIndex = 10;
            this.TxtBoxFabricante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxNomeCliente
            // 
            this.TxtBoxNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxNomeCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxNomeCliente.Location = new System.Drawing.Point(206, 50);
            this.TxtBoxNomeCliente.Name = "TxtBoxNomeCliente";
            this.TxtBoxNomeCliente.ReadOnly = true;
            this.TxtBoxNomeCliente.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxNomeCliente.TabIndex = 11;
            this.TxtBoxNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxPlaca
            // 
            this.TxtBoxPlaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxPlaca.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxPlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxPlaca.Location = new System.Drawing.Point(206, 72);
            this.TxtBoxPlaca.Name = "TxtBoxPlaca";
            this.TxtBoxPlaca.ReadOnly = true;
            this.TxtBoxPlaca.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxPlaca.TabIndex = 12;
            this.TxtBoxPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxModelo
            // 
            this.TxtBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxModelo.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxModelo.Location = new System.Drawing.Point(206, 116);
            this.TxtBoxModelo.Name = "TxtBoxModelo";
            this.TxtBoxModelo.ReadOnly = true;
            this.TxtBoxModelo.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxModelo.TabIndex = 13;
            this.TxtBoxModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxCor
            // 
            this.TxtBoxCor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxCor.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxCor.Location = new System.Drawing.Point(206, 138);
            this.TxtBoxCor.Name = "TxtBoxCor";
            this.TxtBoxCor.ReadOnly = true;
            this.TxtBoxCor.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxCor.TabIndex = 14;
            this.TxtBoxCor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxDataCadastro
            // 
            this.TxtBoxDataCadastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxDataCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxDataCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxDataCadastro.Location = new System.Drawing.Point(206, 160);
            this.TxtBoxDataCadastro.Name = "TxtBoxDataCadastro";
            this.TxtBoxDataCadastro.ReadOnly = true;
            this.TxtBoxDataCadastro.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxDataCadastro.TabIndex = 15;
            this.TxtBoxDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblModelo
            // 
            this.LblModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblModelo.Location = new System.Drawing.Point(6, 113);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(191, 19);
            this.LblModelo.TabIndex = 5;
            this.LblModelo.Text = "Modelo:";
            this.LblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCor
            // 
            this.LblCor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCor.Location = new System.Drawing.Point(6, 135);
            this.LblCor.Name = "LblCor";
            this.LblCor.Size = new System.Drawing.Size(191, 19);
            this.LblCor.TabIndex = 6;
            this.LblCor.Text = "Cor:";
            this.LblCor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDataCadastro
            // 
            this.LblDataCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDataCadastro.Location = new System.Drawing.Point(6, 157);
            this.LblDataCadastro.Name = "LblDataCadastro";
            this.LblDataCadastro.Size = new System.Drawing.Size(191, 20);
            this.LblDataCadastro.TabIndex = 7;
            this.LblDataCadastro.Text = "Data Cadastro:";
            this.LblDataCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PicCliente
            // 
            this.PicCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicCliente.Image = global::EstacionamentoForms.Properties.Resources.de7834s_6515bd40_8b2c_4dc6_a843_5ac1a95a8b55;
            this.PicCliente.Location = new System.Drawing.Point(93, 17);
            this.PicCliente.Name = "PicCliente";
            this.PicCliente.Size = new System.Drawing.Size(149, 180);
            this.PicCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCliente.TabIndex = 18;
            this.PicCliente.TabStop = false;
            // 
            // DataGridViewVeiculos
            // 
            this.DataGridViewVeiculos.ColumnHeadersHeight = 29;
            this.DataGridViewVeiculos.Location = new System.Drawing.Point(93, 203);
            this.DataGridViewVeiculos.Name = "DataGridViewVeiculos";
            this.DataGridViewVeiculos.RowHeadersWidth = 51;
            this.DataGridViewVeiculos.RowTemplate.Height = 24;
            this.DataGridViewVeiculos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DataGridViewVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewVeiculos.Size = new System.Drawing.Size(658, 314);
            this.DataGridViewVeiculos.TabIndex = 19;
            this.DataGridViewVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVeiculos_CellClick);
            this.DataGridViewVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVeiculos_CellClick);
            // 
            // ListagemVeiculoForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.DataGridViewVeiculos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PicCliente);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListagemVeiculoForm";
            this.Text = "Listagem de Veículos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnCancelar;
        private PictureBox PicCliente;
        private TableLayoutPanel tableLayoutPanel1;

        private DataGridView DataGridViewVeiculos;

        private TextBox TxtBoxId;
        private TextBox TxtBoxIdCliente;
        private TextBox TxtBoxNomeCliente;
        private TextBox TxtBoxPlaca;
        private TextBox TxtBoxFabricante;
        private TextBox TxtBoxModelo;
        private TextBox TxtBoxCor;
        private TextBox TxtBoxDataCadastro;

        private Label LblId;
        private Label LblIdCliente;
        private Label LblNomeCliente;
        private Label LblPlaca;
        private Label LblFabricante;
        private Label LblModelo;
        private Label LblCor;
        private Label LblDataCadastro;
    }
}