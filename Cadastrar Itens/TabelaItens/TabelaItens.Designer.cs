namespace Vanilla
{
    partial class TabelaItens
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaItens));
            dataGridItens = new DataGridView();
            ColumnFornec = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnCodBar = new DataGridViewTextBoxColumn();
            ColumnUnmed = new DataGridViewTextBoxColumn();
            ColumnStatusitem = new DataGridViewTextBoxColumn();
            ColumnDescItem = new DataGridViewTextBoxColumn();
            ColumnPrecoC = new DataGridViewTextBoxColumn();
            ColumnPorcent = new DataGridViewTextBoxColumn();
            ColumnPrecoF = new DataGridViewTextBoxColumn();
            search = new Button();
            Tcamppesq = new TextBox();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            planilhaToolStripMenuItem = new ToolStripMenuItem();
            pDFToolStripMenuItem = new ToolStripMenuItem();
            Rcodbar = new RadioButton();
            Rnome = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridItens).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridItens
            // 
            dataGridItens.AllowUserToAddRows = false;
            dataGridItens.AllowUserToDeleteRows = false;
            dataGridItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridItens.BackgroundColor = SystemColors.Control;
            dataGridItens.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItens.Columns.AddRange(new DataGridViewColumn[] { ColumnFornec, ColumnName, ColumnCodBar, ColumnUnmed, ColumnStatusitem, ColumnDescItem, ColumnPrecoC, ColumnPorcent, ColumnPrecoF });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridItens.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridItens.Location = new Point(12, 93);
            dataGridItens.Name = "dataGridItens";
            dataGridItens.ReadOnly = true;
            dataGridItens.RowHeadersVisible = false;
            dataGridItens.RowTemplate.Height = 25;
            dataGridItens.Size = new Size(1136, 534);
            dataGridItens.TabIndex = 12;
            dataGridItens.CellMouseDoubleClick += Env;
            // 
            // ColumnFornec
            // 
            ColumnFornec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnFornec.HeaderText = "Fornecedor";
            ColumnFornec.MinimumWidth = 100;
            ColumnFornec.Name = "ColumnFornec";
            ColumnFornec.ReadOnly = true;
            // 
            // ColumnName
            // 
            ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnName.HeaderText = "Nome";
            ColumnName.MinimumWidth = 100;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            // 
            // ColumnCodBar
            // 
            ColumnCodBar.HeaderText = "Cod_Barras";
            ColumnCodBar.Name = "ColumnCodBar";
            ColumnCodBar.ReadOnly = true;
            // 
            // ColumnUnmed
            // 
            ColumnUnmed.HeaderText = "UN.Med";
            ColumnUnmed.Name = "ColumnUnmed";
            ColumnUnmed.ReadOnly = true;
            // 
            // ColumnStatusitem
            // 
            ColumnStatusitem.HeaderText = "Status";
            ColumnStatusitem.Name = "ColumnStatusitem";
            ColumnStatusitem.ReadOnly = true;
            // 
            // ColumnDescItem
            // 
            ColumnDescItem.HeaderText = "Desc_Item";
            ColumnDescItem.Name = "ColumnDescItem";
            ColumnDescItem.ReadOnly = true;
            // 
            // ColumnPrecoC
            // 
            ColumnPrecoC.HeaderText = "Preço de Custo";
            ColumnPrecoC.Name = "ColumnPrecoC";
            ColumnPrecoC.ReadOnly = true;
            // 
            // ColumnPorcent
            // 
            ColumnPorcent.HeaderText = "Lucro";
            ColumnPorcent.Name = "ColumnPorcent";
            ColumnPorcent.ReadOnly = true;
            // 
            // ColumnPrecoF
            // 
            ColumnPrecoF.HeaderText = "Preço Final";
            ColumnPrecoF.Name = "ColumnPrecoF";
            ColumnPrecoF.ReadOnly = true;
            // 
            // search
            // 
            search.Cursor = Cursors.Hand;
            search.Location = new Point(273, 39);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 14;
            search.Text = "Pesquisar";
            search.UseVisualStyleBackColor = true;
            search.Click += Pesquisar;
            // 
            // Tcamppesq
            // 
            Tcamppesq.Location = new Point(12, 39);
            Tcamppesq.Name = "Tcamppesq";
            Tcamppesq.Size = new Size(255, 23);
            Tcamppesq.TabIndex = 15;
            Tcamppesq.Leave += Pesquisar;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(1117, 645);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1165, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            salvarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { planilhaToolStripMenuItem, pDFToolStripMenuItem });
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(50, 20);
            salvarToolStripMenuItem.Text = "Salvar";
            // 
            // planilhaToolStripMenuItem
            // 
            planilhaToolStripMenuItem.BackColor = SystemColors.Control;
            planilhaToolStripMenuItem.Image = (Image)resources.GetObject("planilhaToolStripMenuItem.Image");
            planilhaToolStripMenuItem.Name = "planilhaToolStripMenuItem";
            planilhaToolStripMenuItem.Size = new Size(116, 22);
            planilhaToolStripMenuItem.Text = "Planilha";
            planilhaToolStripMenuItem.Click += ExportarXls;
            // 
            // pDFToolStripMenuItem
            // 
            pDFToolStripMenuItem.Image = (Image)resources.GetObject("pDFToolStripMenuItem.Image");
            pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            pDFToolStripMenuItem.Size = new Size(116, 22);
            pDFToolStripMenuItem.Text = "PDF";
            pDFToolStripMenuItem.Click += ExportarPdf;
            // 
            // Rcodbar
            // 
            Rcodbar.AutoSize = true;
            Rcodbar.Location = new Point(81, 68);
            Rcodbar.Name = "Rcodbar";
            Rcodbar.Size = new Size(115, 19);
            Rcodbar.TabIndex = 1;
            Rcodbar.Text = "Código de Barras";
            Rcodbar.UseVisualStyleBackColor = true;
            // 
            // Rnome
            // 
            Rnome.Checked = true;
            Rnome.Location = new Point(12, 68);
            Rnome.Name = "Rnome";
            Rnome.Size = new Size(63, 19);
            Rnome.TabIndex = 0;
            Rnome.TabStop = true;
            Rnome.Text = "Item";
            Rnome.UseVisualStyleBackColor = true;
            // 
            // TabelaItens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 687);
            Controls.Add(Rnome);
            Controls.Add(Rcodbar);
            Controls.Add(button2);
            Controls.Add(Tcamppesq);
            Controls.Add(search);
            Controls.Add(dataGridItens);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            MinimumSize = new Size(1041, 665);
            Name = "TabelaItens";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridItens).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridItens;
        private Button search;
        private TextBox Tcamppesq;
        private Button button2;
        private DataGridViewTextBoxColumn ColumnQuant;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem planilhaToolStripMenuItem;
        private ToolStripMenuItem pDFToolStripMenuItem;
        private RadioButton Rcodbar;
        private RadioButton Rnome;
        private DataGridViewTextBoxColumn ColumnFornec;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnCodBar;
        private DataGridViewTextBoxColumn ColumnUnmed;
        private DataGridViewTextBoxColumn ColumnStatusitem;
        private DataGridViewTextBoxColumn ColumnDescItem;
        private DataGridViewTextBoxColumn ColumnPrecoC;
        private DataGridViewTextBoxColumn ColumnPorcent;
        private DataGridViewTextBoxColumn ColumnPrecoF;
    }
}