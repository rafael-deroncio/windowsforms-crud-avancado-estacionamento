using EstacionamentoForms.Models;

namespace EstacionamentoForms
{
    partial class RelatorioReceitaForm
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
            this.BtnSair = new System.Windows.Forms.Button();
            this.DataGridViewReceita = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblReceita = new System.Windows.Forms.Label();
            this.LblValorReceitaTotal = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LinkLblExportar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReceita)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSair.Location = new System.Drawing.Point(464, 621);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DataGridViewReceita
            // 
            this.DataGridViewReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewReceita.Location = new System.Drawing.Point(12, 144);
            this.DataGridViewReceita.Name = "DataGridViewReceita";
            this.DataGridViewReceita.Size = new System.Drawing.Size(979, 471);
            this.DataGridViewReceita.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.47059F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.52941F));
            this.tableLayoutPanel1.Controls.Add(this.LblReceita, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblValorReceitaTotal, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(416, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 21);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // LblReceita
            // 
            this.LblReceita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblReceita.AutoSize = true;
            this.LblReceita.Location = new System.Drawing.Point(4, 0);
            this.LblReceita.Name = "LblReceita";
            this.LblReceita.Size = new System.Drawing.Size(71, 21);
            this.LblReceita.TabIndex = 0;
            this.LblReceita.Text = "Receita Total";
            this.LblReceita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblValorReceitaTotal
            // 
            this.LblValorReceitaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblValorReceitaTotal.AutoSize = true;
            this.LblValorReceitaTotal.Location = new System.Drawing.Point(102, 0);
            this.LblValorReceitaTotal.Name = "LblValorReceitaTotal";
            this.LblValorReceitaTotal.Size = new System.Drawing.Size(45, 21);
            this.LblValorReceitaTotal.TabIndex = 1;
            this.LblValorReceitaTotal.Text = "R$ 0,00";
            this.LblValorReceitaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicLogo
            // 
            this.PicLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicLogo.Image = global::EstacionamentoForms.Properties.Resources.logo_gamaacademy2_PhotoRoom_png_PhotoRoom;
            this.PicLogo.Location = new System.Drawing.Point(0, 0);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(1003, 108);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 6;
            this.PicLogo.TabStop = false;
            // 
            // LinkLblExportar
            // 
            this.LinkLblExportar.AutoSize = true;
            this.LinkLblExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLblExportar.Location = new System.Drawing.Point(592, 121);
            this.LinkLblExportar.Name = "LinkLblExportar";
            this.LinkLblExportar.Size = new System.Drawing.Size(46, 13);
            this.LinkLblExportar.TabIndex = 12;
            this.LinkLblExportar.TabStop = true;
            this.LinkLblExportar.Text = "Exportar";
            this.LinkLblExportar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblExportar_LinkClicked);
            // 
            // RelatorioReceitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 656);
            this.Controls.Add(this.LinkLblExportar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DataGridViewReceita);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.PicLogo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "RelatorioReceitaForm";
            this.Text = "Relatório de Receita";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReceita)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView DataGridViewReceita;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblValorReceitaTotal;
        private System.Windows.Forms.Label LblReceita;
        private System.Windows.Forms.LinkLabel LinkLblExportar;
    }
}



