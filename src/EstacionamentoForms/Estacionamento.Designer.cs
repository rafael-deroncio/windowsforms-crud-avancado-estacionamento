using EstacionamentoForms.Models;

namespace EstacionamentoForms
{
    partial class Estacionamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDriver1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDriver2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDriver3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDriver4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tabelaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemDeTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeReceitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblLogo = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblColHome1 = new System.Windows.Forms.Label();
            this.LblColHome2 = new System.Windows.Forms.Label();
            this.LblColHome3 = new System.Windows.Forms.Label();
            this.LblColHome4 = new System.Windows.Forms.Label();
            this.LblRowHome1 = new System.Windows.Forms.Label();
            this.LblRowHome2 = new System.Windows.Forms.Label();
            this.LblRowHome3 = new System.Windows.Forms.Label();
            this.LblRowHome4 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.ticketsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(61, 20);
            this.fileMenu.Text = "&Arquivo";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preçosToolStripMenuItem,
            this.driverToolStripMenuItem});
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // preçosToolStripMenuItem
            // 
            this.preçosToolStripMenuItem.Name = "preçosToolStripMenuItem";
            this.preçosToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.preçosToolStripMenuItem.Text = "Preços";
            this.preçosToolStripMenuItem.Click += new System.EventHandler(this.AjusteDePrecos_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDriver1,
            this.toolDriver2,
            this.toolDriver3,
            this.toolDriver4});
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.driverToolStripMenuItem.Text = "Driver";
            // 
            // toolDriver1
            // 
            this.toolDriver1.Name = "toolDriver1";
            this.toolDriver1.Size = new System.Drawing.Size(177, 22);
            this.toolDriver1.Text = "driver_persistencia1";
            this.toolDriver1.Click += new System.EventHandler(this.toolDriver1_Click);
            // 
            // toolDriver2
            // 
            this.toolDriver2.Name = "toolDriver2";
            this.toolDriver2.Size = new System.Drawing.Size(177, 22);
            this.toolDriver2.Text = "driver_persistencia2";
            this.toolDriver2.Click += new System.EventHandler(this.toolDriver2_Click);
            // 
            // toolDriver3
            // 
            this.toolDriver3.Name = "toolDriver3";
            this.toolDriver3.Size = new System.Drawing.Size(177, 22);
            this.toolDriver3.Text = "driver_persistencia3";
            this.toolDriver3.Click += new System.EventHandler(this.toolDriver3_Click);
            // 
            // toolDriver4
            // 
            this.toolDriver4.Name = "toolDriver4";
            this.toolDriver4.Size = new System.Drawing.Size(177, 22);
            this.toolDriver4.Text = "driver_persistencia4";
            this.toolDriver4.Click += new System.EventHandler(this.toolDriver4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Sai&r";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Sair_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.tabelaDeClientesToolStripMenuItem,
            this.cadastrarToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(61, 20);
            this.editMenu.Text = "&Clientes";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(180, 6);
            // 
            // tabelaDeClientesToolStripMenuItem
            // 
            this.tabelaDeClientesToolStripMenuItem.Name = "tabelaDeClientesToolStripMenuItem";
            this.tabelaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tabelaDeClientesToolStripMenuItem.Text = "Listagem de Clientes";
            this.tabelaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.LoadListagemClientes_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.CadastrarClientes_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaDeVeículosToolStripMenuItem,
            this.cadastrarToolStripMenuItem1});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(62, 20);
            this.viewMenu.Text = "&Veiculos";
            // 
            // tabelaDeVeículosToolStripMenuItem
            // 
            this.tabelaDeVeículosToolStripMenuItem.Name = "tabelaDeVeículosToolStripMenuItem";
            this.tabelaDeVeículosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tabelaDeVeículosToolStripMenuItem.Text = "Listagem de Veículos";
            this.tabelaDeVeículosToolStripMenuItem.Click += new System.EventHandler(this.LoadListagemVeiculos_Click);
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.CadastrarVeiculos_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemDeTicketsToolStripMenuItem,
            this.cadastrarToolStripMenuItem2,
            this.fecharToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // listagemDeTicketsToolStripMenuItem
            // 
            this.listagemDeTicketsToolStripMenuItem.Name = "listagemDeTicketsToolStripMenuItem";
            this.listagemDeTicketsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listagemDeTicketsToolStripMenuItem.Text = "Listagem de Tickets";
            this.listagemDeTicketsToolStripMenuItem.Click += new System.EventHandler(this.LoadListagemTickets_Click);
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(177, 22);
            this.cadastrarToolStripMenuItem2.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem2.Click += new System.EventHandler(this.CadastrarTicket_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.FecharTicket_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeReceitaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "&Receita";
            // 
            // relatórioDeReceitaToolStripMenuItem
            // 
            this.relatórioDeReceitaToolStripMenuItem.Name = "relatórioDeReceitaToolStripMenuItem";
            this.relatórioDeReceitaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.relatórioDeReceitaToolStripMenuItem.Text = "Relatório de Receita";
            this.relatórioDeReceitaToolStripMenuItem.Click += new System.EventHandler(this.LoadRelatorioReceita_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PicLogo, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.18939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.81061F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 431);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LblLogo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(624, 103);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LblLogo
            // 
            this.LblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblLogo.Location = new System.Drawing.Point(4, 16);
            this.LblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(616, 19);
            this.LblLogo.TabIndex = 0;
            this.LblLogo.Text = "Estacionamento";
            this.LblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.LblColHome1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblColHome2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblColHome3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblColHome4, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblRowHome1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LblRowHome2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.LblRowHome3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.LblRowHome4, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 54);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(616, 45);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // LblColHome1
            // 
            this.LblColHome1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblColHome1.Location = new System.Drawing.Point(2, 0);
            this.LblColHome1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblColHome1.Name = "LblColHome1";
            this.LblColHome1.Size = new System.Drawing.Size(149, 17);
            this.LblColHome1.TabIndex = 0;
            this.LblColHome1.Text = "label1";
            this.LblColHome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblColHome2
            // 
            this.LblColHome2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblColHome2.Location = new System.Drawing.Point(156, 2);
            this.LblColHome2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblColHome2.Name = "LblColHome2";
            this.LblColHome2.Size = new System.Drawing.Size(149, 13);
            this.LblColHome2.TabIndex = 1;
            this.LblColHome2.Text = "label2";
            this.LblColHome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblColHome3
            // 
            this.LblColHome3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblColHome3.Location = new System.Drawing.Point(310, 2);
            this.LblColHome3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblColHome3.Name = "LblColHome3";
            this.LblColHome3.Size = new System.Drawing.Size(149, 13);
            this.LblColHome3.TabIndex = 2;
            this.LblColHome3.Text = "label3";
            this.LblColHome3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblColHome4
            // 
            this.LblColHome4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblColHome4.Location = new System.Drawing.Point(464, 2);
            this.LblColHome4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblColHome4.Name = "LblColHome4";
            this.LblColHome4.Size = new System.Drawing.Size(149, 13);
            this.LblColHome4.TabIndex = 3;
            this.LblColHome4.Text = "label4";
            this.LblColHome4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRowHome1
            // 
            this.LblRowHome1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRowHome1.Location = new System.Drawing.Point(2, 25);
            this.LblRowHome1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRowHome1.Name = "LblRowHome1";
            this.LblRowHome1.Size = new System.Drawing.Size(149, 13);
            this.LblRowHome1.TabIndex = 4;
            this.LblRowHome1.Text = "label1";
            this.LblRowHome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRowHome2
            // 
            this.LblRowHome2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRowHome2.Location = new System.Drawing.Point(156, 25);
            this.LblRowHome2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRowHome2.Name = "LblRowHome2";
            this.LblRowHome2.Size = new System.Drawing.Size(149, 13);
            this.LblRowHome2.TabIndex = 5;
            this.LblRowHome2.Text = "label2";
            this.LblRowHome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRowHome3
            // 
            this.LblRowHome3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRowHome3.Location = new System.Drawing.Point(310, 25);
            this.LblRowHome3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRowHome3.Name = "LblRowHome3";
            this.LblRowHome3.Size = new System.Drawing.Size(149, 13);
            this.LblRowHome3.TabIndex = 6;
            this.LblRowHome3.Text = "label3";
            this.LblRowHome3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRowHome4
            // 
            this.LblRowHome4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRowHome4.Location = new System.Drawing.Point(464, 25);
            this.LblRowHome4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRowHome4.Name = "LblRowHome4";
            this.LblRowHome4.Size = new System.Drawing.Size(149, 13);
            this.LblRowHome4.TabIndex = 7;
            this.LblRowHome4.Text = "label4";
            this.LblRowHome4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicLogo
            // 
            this.PicLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicLogo.Image = global::EstacionamentoForms.Properties.Resources.logo_gamaacademy2_PhotoRoom_png_PhotoRoom;
            this.PicLogo.Location = new System.Drawing.Point(4, 113);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(624, 314);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            // 
            // Estacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Estacionamento";
            this.Text = "Estacionamento";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listagemDeTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeReceitaToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LblLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblColHome1;
        private System.Windows.Forms.Label LblColHome2;
        private System.Windows.Forms.Label LblColHome3;
        private System.Windows.Forms.Label LblColHome4;
        private System.Windows.Forms.Label LblRowHome1;
        private System.Windows.Forms.Label LblRowHome2;
        private System.Windows.Forms.Label LblRowHome3;
        private System.Windows.Forms.Label LblRowHome4;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolDriver1;
        private System.Windows.Forms.ToolStripMenuItem toolDriver2;
        private System.Windows.Forms.ToolStripMenuItem toolDriver3;
        private System.Windows.Forms.ToolStripMenuItem toolDriver4;
    }
}



