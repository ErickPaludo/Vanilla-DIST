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
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            ColumnIdFornc = new DataGridViewTextBoxColumn();
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
            camppesq = new TextBox();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            planilhaToolStripMenuItem = new ToolStripMenuItem();
            pDFToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            Rnome = new RadioButton();
            Rcodbar = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridItens).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            dataGridItens.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn13, ColumnIdFornc, ColumnFornec, ColumnName, ColumnCodBar, ColumnUnmed, ColumnStatusitem, ColumnDescItem, ColumnPrecoC, ColumnPorcent, ColumnPrecoF });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridItens.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridItens.Location = new Point(9, 104);
            dataGridItens.Name = "dataGridItens";
            dataGridItens.ReadOnly = true;
            dataGridItens.RowHeadersVisible = false;
            dataGridItens.RowTemplate.Height = 25;
            dataGridItens.Size = new Size(1136, 523);
            dataGridItens.TabIndex = 12;
            dataGridItens.CellMouseDoubleClick += Env;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Id";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 70;
            // 
            // ColumnIdFornc
            // 
            ColumnIdFornc.HeaderText = "Id_F";
            ColumnIdFornc.Name = "ColumnIdFornc";
            ColumnIdFornc.ReadOnly = true;
            ColumnIdFornc.Width = 70;
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
            search.Location = new Point(290, 12);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 14;
            search.Text = "Pesquisar";
            search.UseVisualStyleBackColor = true;
            search.Click += Pesquisar;
            // 
            // camppesq
            // 
            camppesq.Location = new Point(12, 12);
            camppesq.Name = "camppesq";
            camppesq.Size = new Size(255, 23);
            camppesq.TabIndex = 15;
            camppesq.Leave += Pesquisar;
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
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripMenuItem });
            menuStrip1.Location = new Point(9, 645);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(58, 24);
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
            planilhaToolStripMenuItem.Name = "planilhaToolStripMenuItem";
            planilhaToolStripMenuItem.Size = new Size(116, 22);
            planilhaToolStripMenuItem.Text = "Planilha";
            planilhaToolStripMenuItem.Click += Exportar;
            // 
            // pDFToolStripMenuItem
            // 
            pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            pDFToolStripMenuItem.Size = new Size(116, 22);
            pDFToolStripMenuItem.Text = "PDF";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Rcodbar);
            groupBox1.Controls.Add(Rnome);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 48);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Rnome
            // 
            Rnome.AutoSize = true;
            Rnome.Checked = true;
            Rnome.Location = new Point(6, 22);
            Rnome.Name = "Rnome";
            Rnome.Size = new Size(63, 19);
            Rnome.TabIndex = 0;
            Rnome.TabStop = true;
            Rnome.Text = "Rnome";
            Rnome.UseVisualStyleBackColor = true;
            // 
            // Rcodbar
            // 
            Rcodbar.AutoSize = true;
            Rcodbar.Location = new Point(86, 23);
            Rcodbar.Name = "Rcodbar";
            Rcodbar.Size = new Size(69, 19);
            Rcodbar.TabIndex = 1;
            Rcodbar.Text = "Rcodbar";
            Rcodbar.UseVisualStyleBackColor = true;
            // 
            // TabelaItens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 687);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(camppesq);
            Controls.Add(search);
            Controls.Add(dataGridItens);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            MinimumSize = new Size(1041, 665);
            Name = "TabelaItens";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridItens).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridItens;
        private Button search;
        private TextBox camppesq;
        private Button button2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn ColumnIdFornc;
        private DataGridViewTextBoxColumn ColumnFornec;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnQuant;
        private DataGridViewTextBoxColumn ColumnCodBar;
        private DataGridViewTextBoxColumn ColumnUnmed;
        private DataGridViewTextBoxColumn ColumnStatusitem;
        private DataGridViewTextBoxColumn ColumnDescItem;
        private DataGridViewTextBoxColumn ColumnPrecoC;
        private DataGridViewTextBoxColumn ColumnPorcent;
        private DataGridViewTextBoxColumn ColumnPrecoF;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem planilhaToolStripMenuItem;
        private ToolStripMenuItem pDFToolStripMenuItem;
        private GroupBox groupBox1;
        private RadioButton Rcodbar;
        private RadioButton Rnome;
    }
}