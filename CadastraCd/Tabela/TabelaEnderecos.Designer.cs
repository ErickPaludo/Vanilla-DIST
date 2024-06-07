namespace Vanilla
{
    partial class TabelaEnderecos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaEnderecos));
            dataGridCd = new DataGridView();
            ColumnEndereco = new DataGridViewTextBoxColumn();
            ColumnCod = new DataGridViewTextBoxColumn();
            ColumnRegiao = new DataGridViewTextBoxColumn();
            ColumnItem = new DataGridViewTextBoxColumn();
            radioButtonEnd = new RadioButton();
            radioButtonPick = new RadioButton();
            groupBox1 = new GroupBox();
            radioButtonTodos = new RadioButton();
            radioButtonOcupados = new RadioButton();
            radioButtonLivres = new RadioButton();
            camppesq = new TextBox();
            search = new Button();
            menuStrip1 = new MenuStrip();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            planilhaToolStripMenuItem = new ToolStripMenuItem();
            pDFToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridCd).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCd
            // 
            dataGridCd.AllowUserToAddRows = false;
            dataGridCd.AllowUserToDeleteRows = false;
            dataGridCd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCd.BackgroundColor = SystemColors.Control;
            dataGridCd.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCd.Columns.AddRange(new DataGridViewColumn[] { ColumnEndereco, ColumnCod, ColumnRegiao, ColumnItem });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridCd.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridCd.Location = new Point(12, 146);
            dataGridCd.Name = "dataGridCd";
            dataGridCd.ReadOnly = true;
            dataGridCd.RowHeadersVisible = false;
            dataGridCd.RowTemplate.Height = 25;
            dataGridCd.Size = new Size(900, 398);
            dataGridCd.TabIndex = 14;
            dataGridCd.CellContentClick += dataGridCd_CellContentClick;
            // 
            // ColumnEndereco
            // 
            ColumnEndereco.HeaderText = "Endereço";
            ColumnEndereco.Name = "ColumnEndereco";
            ColumnEndereco.ReadOnly = true;
            ColumnEndereco.Width = 150;
            // 
            // ColumnCod
            // 
            ColumnCod.HeaderText = "Código de Barras";
            ColumnCod.Name = "ColumnCod";
            ColumnCod.ReadOnly = true;
            ColumnCod.Width = 180;
            // 
            // ColumnRegiao
            // 
            ColumnRegiao.HeaderText = "Região de Separação";
            ColumnRegiao.Name = "ColumnRegiao";
            ColumnRegiao.ReadOnly = true;
            ColumnRegiao.Width = 150;
            // 
            // ColumnItem
            // 
            ColumnItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnItem.HeaderText = "Item";
            ColumnItem.Name = "ColumnItem";
            ColumnItem.ReadOnly = true;
            // 
            // radioButtonEnd
            // 
            radioButtonEnd.AutoSize = true;
            radioButtonEnd.Location = new Point(6, 22);
            radioButtonEnd.Name = "radioButtonEnd";
            radioButtonEnd.Size = new Size(131, 19);
            radioButtonEnd.TabIndex = 15;
            radioButtonEnd.Text = "Endereços (Pulmão)";
            radioButtonEnd.UseVisualStyleBackColor = true;
            radioButtonEnd.Click += AtualizarEnd;
            // 
            // radioButtonPick
            // 
            radioButtonPick.AutoSize = true;
            radioButtonPick.Checked = true;
            radioButtonPick.Location = new Point(6, 47);
            radioButtonPick.Name = "radioButtonPick";
            radioButtonPick.Size = new Size(107, 19);
            radioButtonPick.TabIndex = 16;
            radioButtonPick.TabStop = true;
            radioButtonPick.Text = "Picking (Sub la)";
            radioButtonPick.UseVisualStyleBackColor = true;
            radioButtonPick.Click += AtualizaPick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonEnd);
            groupBox1.Controls.Add(radioButtonPick);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 79);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipos de Endereço";
            // 
            // radioButtonTodos
            // 
            radioButtonTodos.AutoSize = true;
            radioButtonTodos.Checked = true;
            radioButtonTodos.Location = new Point(227, 71);
            radioButtonTodos.Name = "radioButtonTodos";
            radioButtonTodos.Size = new Size(56, 19);
            radioButtonTodos.TabIndex = 18;
            radioButtonTodos.TabStop = true;
            radioButtonTodos.Text = "Todos";
            radioButtonTodos.UseVisualStyleBackColor = true;
            radioButtonTodos.Click += RadionClick;
            // 
            // radioButtonOcupados
            // 
            radioButtonOcupados.AutoSize = true;
            radioButtonOcupados.Location = new Point(227, 96);
            radioButtonOcupados.Name = "radioButtonOcupados";
            radioButtonOcupados.Size = new Size(136, 19);
            radioButtonOcupados.TabIndex = 19;
            radioButtonOcupados.Text = "Endereços Ocupados";
            radioButtonOcupados.UseVisualStyleBackColor = true;
            radioButtonOcupados.Click += RadionClick;
            // 
            // radioButtonLivres
            // 
            radioButtonLivres.AutoSize = true;
            radioButtonLivres.Location = new Point(227, 121);
            radioButtonLivres.Name = "radioButtonLivres";
            radioButtonLivres.Size = new Size(112, 19);
            radioButtonLivres.TabIndex = 20;
            radioButtonLivres.Text = "Endereços Livres";
            radioButtonLivres.UseVisualStyleBackColor = true;
            radioButtonLivres.Click += RadionClick;
            // 
            // camppesq
            // 
            camppesq.Location = new Point(12, 32);
            camppesq.Name = "camppesq";
            camppesq.Size = new Size(190, 23);
            camppesq.TabIndex = 22;
            // 
            // search
            // 
            search.Cursor = Cursors.Hand;
            search.Location = new Point(208, 32);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 21;
            search.Text = "Pesquisar";
            search.UseVisualStyleBackColor = true;
            search.Click += Pesquisar;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(924, 24);
            menuStrip1.TabIndex = 23;
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
            // TabelaEnderecos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 575);
            Controls.Add(menuStrip1);
            Controls.Add(camppesq);
            Controls.Add(search);
            Controls.Add(radioButtonLivres);
            Controls.Add(radioButtonOcupados);
            Controls.Add(radioButtonTodos);
            Controls.Add(groupBox1);
            Controls.Add(dataGridCd);
            Name = "TabelaEnderecos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabelaEnderecos";
            ((System.ComponentModel.ISupportInitialize)dataGridCd).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCd;
        private DataGridViewTextBoxColumn ColumnEndereco;
        private DataGridViewTextBoxColumn ColumnCod;
        private DataGridViewTextBoxColumn ColumnRegiao;
        private DataGridViewTextBoxColumn ColumnItem;
        public RadioButton radioButtonEnd;
        public RadioButton radioButtonPick;
        private GroupBox groupBox1;
        private RadioButton radioButtonTodos;
        private RadioButton radioButtonOcupados;
        private RadioButton radioButtonLivres;
        private TextBox camppesq;
        private Button search;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem planilhaToolStripMenuItem;
        private ToolStripMenuItem pDFToolStripMenuItem;
    }
}