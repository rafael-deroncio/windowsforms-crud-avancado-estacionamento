using System.Reflection;
using System.Windows.Forms;

namespace EstacionamentoForms
{
    partial class ListagemTicketForm
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
            this.PicCliente = new System.Windows.Forms.PictureBox();
            this.DataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblIdTicket = new System.Windows.Forms.Label();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.TxtBoxValorTicket = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.LblSaida = new System.Windows.Forms.Label();
            this.LblTempoEstacionado = new System.Windows.Forms.Label();
            this.LblValorTicket = new System.Windows.Forms.Label();
            this.TxtBoxDescricao = new System.Windows.Forms.TextBox();
            this.TxtBoxAtivo = new System.Windows.Forms.TextBox();
            this.TxtBoxCliente = new System.Windows.Forms.TextBox();
            this.TxtBoxEntrada = new System.Windows.Forms.TextBox();
            this.CmbBoxTempoEstacionado = new System.Windows.Forms.TextBox();
            this.TxtBoxSaida = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTickets)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // PicCliente
            // 
            this.PicCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicCliente.Image = global::EstacionamentoForms.Properties.Resources.de7834s_6515bd40_8b2c_4dc6_a843_5ac1a95a8b55;
            this.PicCliente.Location = new System.Drawing.Point(93, 36);
            this.PicCliente.Name = "PicCliente";
            this.PicCliente.Size = new System.Drawing.Size(149, 180);
            this.PicCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCliente.TabIndex = 18;
            this.PicCliente.TabStop = false;
            // 
            // DataGridViewTickets
            // 
            this.DataGridViewTickets.ColumnHeadersHeight = 29;
            this.DataGridViewTickets.Location = new System.Drawing.Point(93, 222);
            this.DataGridViewTickets.Name = "DataGridViewTickets";
            this.DataGridViewTickets.RowHeadersWidth = 51;
            this.DataGridViewTickets.RowTemplate.Height = 24;
            this.DataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTickets.Size = new System.Drawing.Size(658, 295);
            this.DataGridViewTickets.TabIndex = 19;
            this.DataGridViewTickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVeiculos_CellClick);
            this.DataGridViewTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVeiculos_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LblIdTicket, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxValorTicket, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.LblStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblCliente, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblDescricao, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblEntrada, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblSaida, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblTempoEstacionado, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LblValorTicket, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxDescricao, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxAtivo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxCliente, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxEntrada, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CmbBoxTempoEstacionado, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxSaida, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(248, 36);
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
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // LblIdTicket
            // 
            this.LblIdTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblIdTicket.Location = new System.Drawing.Point(6, 3);
            this.LblIdTicket.Name = "LblIdTicket";
            this.LblIdTicket.Size = new System.Drawing.Size(191, 19);
            this.LblIdTicket.TabIndex = 0;
            this.LblIdTicket.Text = "ID Ticket:";
            this.LblIdTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // TxtBoxValorTicket
            // 
            this.TxtBoxValorTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxValorTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxValorTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxValorTicket.Location = new System.Drawing.Point(206, 160);
            this.TxtBoxValorTicket.Name = "TxtBoxValorTicket";
            this.TxtBoxValorTicket.ReadOnly = true;
            this.TxtBoxValorTicket.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxValorTicket.TabIndex = 8;
            this.TxtBoxValorTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblStatus
            // 
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblStatus.Location = new System.Drawing.Point(6, 25);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(191, 19);
            this.LblStatus.TabIndex = 0;
            this.LblStatus.Text = "Status Ticket:";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCliente
            // 
            this.LblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCliente.Location = new System.Drawing.Point(6, 47);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(191, 19);
            this.LblCliente.TabIndex = 0;
            this.LblCliente.Text = "Cliente";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDescricao
            // 
            this.LblDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDescricao.Location = new System.Drawing.Point(6, 69);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(191, 19);
            this.LblDescricao.TabIndex = 0;
            this.LblDescricao.Text = "Veículo:";
            this.LblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblEntrada
            // 
            this.LblEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEntrada.Location = new System.Drawing.Point(6, 91);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(191, 19);
            this.LblEntrada.TabIndex = 0;
            this.LblEntrada.Text = "Entrada:";
            this.LblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblSaida
            // 
            this.LblSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSaida.Location = new System.Drawing.Point(6, 113);
            this.LblSaida.Name = "LblSaida";
            this.LblSaida.Size = new System.Drawing.Size(191, 19);
            this.LblSaida.TabIndex = 0;
            this.LblSaida.Text = "Saída:";
            this.LblSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTempoEstacionado
            // 
            this.LblTempoEstacionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTempoEstacionado.Location = new System.Drawing.Point(6, 135);
            this.LblTempoEstacionado.Name = "LblTempoEstacionado";
            this.LblTempoEstacionado.Size = new System.Drawing.Size(191, 19);
            this.LblTempoEstacionado.TabIndex = 0;
            this.LblTempoEstacionado.Text = "Tempo Estacionado:";
            this.LblTempoEstacionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblValorTicket
            // 
            this.LblValorTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblValorTicket.Location = new System.Drawing.Point(6, 157);
            this.LblValorTicket.Name = "LblValorTicket";
            this.LblValorTicket.Size = new System.Drawing.Size(191, 20);
            this.LblValorTicket.TabIndex = 0;
            this.LblValorTicket.Text = "Valor Ticket:";
            this.LblValorTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBoxDescricao
            // 
            this.TxtBoxDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxDescricao.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxDescricao.Location = new System.Drawing.Point(206, 72);
            this.TxtBoxDescricao.Name = "TxtBoxDescricao";
            this.TxtBoxDescricao.ReadOnly = true;
            this.TxtBoxDescricao.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxDescricao.TabIndex = 4;
            this.TxtBoxDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxAtivo
            // 
            this.TxtBoxAtivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxAtivo.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxAtivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxAtivo.Location = new System.Drawing.Point(206, 28);
            this.TxtBoxAtivo.Name = "TxtBoxAtivo";
            this.TxtBoxAtivo.ReadOnly = true;
            this.TxtBoxAtivo.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxAtivo.TabIndex = 2;
            this.TxtBoxAtivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxCliente
            // 
            this.TxtBoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxCliente.Location = new System.Drawing.Point(206, 50);
            this.TxtBoxCliente.Name = "TxtBoxCliente";
            this.TxtBoxCliente.ReadOnly = true;
            this.TxtBoxCliente.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxCliente.TabIndex = 3;
            this.TxtBoxCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBoxEntrada
            // 
            this.TxtBoxEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxEntrada.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TxtBoxEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxEntrada.Location = new System.Drawing.Point(206, 94);
            this.TxtBoxEntrada.Name = "TxtBoxEntrada";
            this.TxtBoxEntrada.ReadOnly = true;
            this.TxtBoxEntrada.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxEntrada.TabIndex = 5;
            this.TxtBoxEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxEntrada.UseWaitCursor = true;
            // 
            // CmbBoxTempoEstacionado
            // 
            this.CmbBoxTempoEstacionado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CmbBoxTempoEstacionado.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CmbBoxTempoEstacionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbBoxTempoEstacionado.Location = new System.Drawing.Point(206, 138);
            this.CmbBoxTempoEstacionado.Name = "CmbBoxTempoEstacionado";
            this.CmbBoxTempoEstacionado.ReadOnly = true;
            this.CmbBoxTempoEstacionado.Size = new System.Drawing.Size(291, 15);
            this.CmbBoxTempoEstacionado.TabIndex = 7;
            this.CmbBoxTempoEstacionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CmbBoxTempoEstacionado.UseWaitCursor = true;
            // 
            // TxtBoxSaida
            // 
            this.TxtBoxSaida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxSaida.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBoxSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBoxSaida.Location = new System.Drawing.Point(206, 116);
            this.TxtBoxSaida.Name = "TxtBoxSaida";
            this.TxtBoxSaida.ReadOnly = true;
            this.TxtBoxSaida.Size = new System.Drawing.Size(291, 15);
            this.TxtBoxSaida.TabIndex = 6;
            this.TxtBoxSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ListagemTicketForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DataGridViewTickets);
            this.Controls.Add(this.PicCliente);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListagemTicketForm";
            this.Text = "Listagem de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.PicCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTickets)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnCancelar;
        private PictureBox PicCliente;

        private DataGridView DataGridViewTickets;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LblIdTicket;

        private Label LblStatus;
        private Label LblCliente;
        private Label LblDescricao;
        private Label LblEntrada;
        private Label LblSaida;
        private Label LblTempoEstacionado;
        private Label LblValorTicket;
        private TextBox TxtBoxId;
        private TextBox TxtBoxValorTicket;
        private TextBox TxtBoxDescricao;
        private TextBox TxtBoxAtivo;
        private TextBox TxtBoxCliente;
        private TextBox TxtBoxEntrada;
        private TextBox CmbBoxTempoEstacionado;
        private TextBox TxtBoxSaida;
    }
}