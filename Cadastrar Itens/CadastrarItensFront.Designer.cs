using System.Windows.Forms;

namespace Vanilla
{
    partial class CadastrarItensFront
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            nomeItem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            codigoBarras = new TextBox();
            comboStatus = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            descItem = new TextBox();
            dataGridFornecedores = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCNPJ = new DataGridViewTextBoxColumn();
            label5 = new Label();
            selectFornecedor = new Label();
            comboUMed = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            quantItem = new TextBox();
            label8 = new Label();
            precoCusto = new TextBox();
            Lucro = new Label();
            porcentLucro = new TextBox();
            label9 = new Label();
            precoFinal = new Label();
            newFornec = new Button();
            buttonGravar = new Button();
            buttonAtualizarTable = new Button();
            codMaual = new CheckBox();
            calcular = new Button();
            menuStrip1 = new MenuStrip();
            itemToolStripMenuItem = new ToolStripMenuItem();
            newItem = new ToolStripMenuItem();
            editarItem = new ToolStripMenuItem();
            cancelar = new Button();
            pictureCodBar = new PictureBox();
            pictureBox1 = new PictureBox();
            btnImp = new Button();
            btnSalvararquivo = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dataGridFornecedores).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCodBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nomeItem
            // 
            nomeItem.Enabled = false;
            nomeItem.Location = new Point(36, 56);
            nomeItem.MaxLength = 100;
            nomeItem.Name = "nomeItem";
            nomeItem.Size = new Size(202, 23);
            nomeItem.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(36, 40);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome do Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(497, 167);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 5;
            label2.Text = "Código de Barras:";
            // 
            // codigoBarras
            // 
            codigoBarras.Enabled = false;
            codigoBarras.Location = new Point(497, 183);
            codigoBarras.MaxLength = 13;
            codigoBarras.Name = "codigoBarras";
            codigoBarras.Size = new Size(142, 23);
            codigoBarras.TabIndex = 6;
            codigoBarras.KeyDown += Cod_KeyDown;
            codigoBarras.KeyPress += Cod_KeyPress;
            codigoBarras.Leave += VerificarCod;
            // 
            // comboStatus
            // 
            comboStatus.Cursor = Cursors.Hand;
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.Enabled = false;
            comboStatus.FormattingEnabled = true;
            comboStatus.ItemHeight = 15;
            comboStatus.Items.AddRange(new object[] { "Ativo", "Inativo", "Bloqueado" });
            comboStatus.Location = new Point(322, 56);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(72, 23);
            comboStatus.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(322, 40);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 9;
            label3.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(36, 95);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 10;
            label4.Text = "Descrição do Item:";
            // 
            // descItem
            // 
            descItem.Enabled = false;
            descItem.Location = new Point(36, 113);
            descItem.Multiline = true;
            descItem.Name = "descItem";
            descItem.Size = new Size(445, 93);
            descItem.TabIndex = 4;
            // 
            // dataGridFornecedores
            // 
            dataGridFornecedores.AllowUserToAddRows = false;
            dataGridFornecedores.AllowUserToDeleteRows = false;
            dataGridFornecedores.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridFornecedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridFornecedores.BackgroundColor = SystemColors.Control;
            dataGridFornecedores.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFornecedores.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNome, ColumnCNPJ });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridFornecedores.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridFornecedores.Enabled = false;
            dataGridFornecedores.Location = new Point(37, 235);
            dataGridFornecedores.Name = "dataGridFornecedores";
            dataGridFornecedores.ReadOnly = true;
            dataGridFornecedores.RowHeadersVisible = false;
            dataGridFornecedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridFornecedores.RowTemplate.Height = 25;
            dataGridFornecedores.Size = new Size(444, 136);
            dataGridFornecedores.TabIndex = 5;
            dataGridFornecedores.CellClick += SelectFornec;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Width = 50;
            // 
            // ColumnNome
            // 
            ColumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnNome.FillWeight = 150F;
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            ColumnNome.Resizable = DataGridViewTriState.True;
            // 
            // ColumnCNPJ
            // 
            ColumnCNPJ.HeaderText = "CNPJ";
            ColumnCNPJ.Name = "ColumnCNPJ";
            ColumnCNPJ.ReadOnly = true;
            ColumnCNPJ.Width = 120;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 216);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 13;
            label5.Text = "Fornecedor:";
            // 
            // selectFornecedor
            // 
            selectFornecedor.AutoSize = true;
            selectFornecedor.Enabled = false;
            selectFornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            selectFornecedor.Location = new Point(110, 216);
            selectFornecedor.Name = "selectFornecedor";
            selectFornecedor.Size = new Size(70, 15);
            selectFornecedor.TabIndex = 14;
            selectFornecedor.Text = "fornecedor";
            // 
            // comboUMed
            // 
            comboUMed.Cursor = Cursors.Hand;
            comboUMed.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUMed.Enabled = false;
            comboUMed.FormattingEnabled = true;
            comboUMed.ItemHeight = 15;
            comboUMed.Items.AddRange(new object[] { "UN", "Fardo", "Palete" });
            comboUMed.Location = new Point(400, 56);
            comboUMed.Name = "comboUMed";
            comboUMed.Size = new Size(69, 23);
            comboUMed.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(400, 38);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 16;
            label6.Text = "U. Med:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new Point(244, 38);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 18;
            label7.Text = "Quantidade:";
            // 
            // quantItem
            // 
            quantItem.Enabled = false;
            quantItem.Location = new Point(244, 56);
            quantItem.MaxLength = 5;
            quantItem.Name = "quantItem";
            quantItem.Size = new Size(72, 23);
            quantItem.TabIndex = 1;
            quantItem.KeyDown += Qnt_KeyDown;
            quantItem.KeyPress += Qnt_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(497, 253);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 20;
            label8.Text = "Preço de Custo:";
            // 
            // precoCusto
            // 
            precoCusto.Enabled = false;
            precoCusto.Location = new Point(497, 270);
            precoCusto.MaxLength = 10;
            precoCusto.Name = "precoCusto";
            precoCusto.PlaceholderText = "R$00,00";
            precoCusto.Size = new Size(105, 23);
            precoCusto.TabIndex = 10;
            precoCusto.KeyDown += PrecoCusto_KeyDown;
            precoCusto.KeyPress += PrecoCusto_KeyPress;
            precoCusto.Leave += PadronizaPCusto;
            // 
            // Lucro
            // 
            Lucro.AutoSize = true;
            Lucro.Enabled = false;
            Lucro.Location = new Point(608, 253);
            Lucro.Name = "Lucro";
            Lucro.Size = new Size(40, 15);
            Lucro.TabIndex = 22;
            Lucro.Text = "Lucro:";
            // 
            // porcentLucro
            // 
            porcentLucro.Enabled = false;
            porcentLucro.Location = new Point(608, 270);
            porcentLucro.MaxLength = 5;
            porcentLucro.Name = "porcentLucro";
            porcentLucro.PlaceholderText = "0,0%";
            porcentLucro.Size = new Size(51, 23);
            porcentLucro.TabIndex = 10;
            porcentLucro.KeyDown += PercentLucro_KeyDown;
            porcentLucro.KeyPress += PercentLucro_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Enabled = false;
            label9.Location = new Point(500, 296);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 23;
            label9.Text = "Preço Final:";
            // 
            // precoFinal
            // 
            precoFinal.AutoSize = true;
            precoFinal.Enabled = false;
            precoFinal.Location = new Point(574, 296);
            precoFinal.Name = "precoFinal";
            precoFinal.Size = new Size(20, 15);
            precoFinal.TabIndex = 24;
            precoFinal.Text = "R$";
            // 
            // newFornec
            // 
            newFornec.Enabled = false;
            newFornec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newFornec.Location = new Point(369, 375);
            newFornec.Name = "newFornec";
            newFornec.Size = new Size(112, 23);
            newFornec.TabIndex = 28;
            newFornec.Text = "Novo Fornecedor";
            newFornec.UseVisualStyleBackColor = true;
            newFornec.Click += AddFornecedor;
            // 
            // buttonGravar
            // 
            buttonGravar.Location = new Point(1017, 374);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(75, 24);
            buttonGravar.TabIndex = 13;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = true;
            buttonGravar.Visible = false;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // buttonAtualizarTable
            // 
            buttonAtualizarTable.Enabled = false;
            buttonAtualizarTable.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtualizarTable.Location = new Point(298, 375);
            buttonAtualizarTable.Name = "buttonAtualizarTable";
            buttonAtualizarTable.Size = new Size(65, 23);
            buttonAtualizarTable.TabIndex = 27;
            buttonAtualizarTable.Text = "Atualizar";
            buttonAtualizarTable.UseVisualStyleBackColor = true;
            buttonAtualizarTable.Click += buttonAtualizarTable_Click;
            // 
            // codMaual
            // 
            codMaual.AutoSize = true;
            codMaual.Enabled = false;
            codMaual.Location = new Point(645, 183);
            codMaual.Name = "codMaual";
            codMaual.Size = new Size(124, 19);
            codMaual.TabIndex = 7;
            codMaual.Text = "Inserir cod Manual";
            codMaual.UseVisualStyleBackColor = true;
            codMaual.CheckedChanged += codMaual_Click;
            // 
            // calcular
            // 
            calcular.Enabled = false;
            calcular.Location = new Point(497, 314);
            calcular.Name = "calcular";
            calcular.Size = new Size(162, 23);
            calcular.TabIndex = 11;
            calcular.Text = "calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1108, 24);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemToolStripMenuItem
            // 
            itemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newItem, editarItem });
            itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            itemToolStripMenuItem.Size = new Size(50, 20);
            itemToolStripMenuItem.Text = "Menu";
            // 
            // newItem
            // 
            newItem.Name = "newItem";
            newItem.Size = new Size(151, 22);
            newItem.Text = "Cadastrar Item";
            newItem.Click += NewItem;
            // 
            // editarItem
            // 
            editarItem.Name = "editarItem";
            editarItem.Size = new Size(151, 22);
            editarItem.Text = "Editar Item";
            editarItem.Click += EditItem;
            // 
            // cancelar
            // 
            cancelar.Enabled = false;
            cancelar.Location = new Point(924, 374);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(75, 24);
            cancelar.TabIndex = 12;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += Cancelar;
            // 
            // pictureCodBar
            // 
            pictureCodBar.BackColor = SystemColors.ButtonHighlight;
            pictureCodBar.Location = new Point(501, 55);
            pictureCodBar.Name = "pictureCodBar";
            pictureCodBar.Size = new Size(595, 109);
            pictureCodBar.TabIndex = 32;
            pictureCodBar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(500, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(596, 135);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // btnImp
            // 
            btnImp.Enabled = false;
            btnImp.Location = new Point(1017, 183);
            btnImp.Name = "btnImp";
            btnImp.Size = new Size(75, 23);
            btnImp.TabIndex = 9;
            btnImp.Text = "Imprimir";
            btnImp.UseVisualStyleBackColor = true;
            btnImp.Click += btnImp_Click;
            // 
            // btnSalvararquivo
            // 
            btnSalvararquivo.Enabled = false;
            btnSalvararquivo.Location = new Point(936, 183);
            btnSalvararquivo.Name = "btnSalvararquivo";
            btnSalvararquivo.Size = new Size(75, 23);
            btnSalvararquivo.TabIndex = 8;
            btnSalvararquivo.Text = "Salvar";
            btnSalvararquivo.UseVisualStyleBackColor = true;
            btnSalvararquivo.Click += btnSalvararquivo_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // CadastrarItensFront
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1108, 412);
            Controls.Add(btnSalvararquivo);
            Controls.Add(btnImp);
            Controls.Add(pictureCodBar);
            Controls.Add(cancelar);
            Controls.Add(calcular);
            Controls.Add(codMaual);
            Controls.Add(buttonAtualizarTable);
            Controls.Add(buttonGravar);
            Controls.Add(newFornec);
            Controls.Add(precoFinal);
            Controls.Add(label9);
            Controls.Add(Lucro);
            Controls.Add(porcentLucro);
            Controls.Add(label8);
            Controls.Add(precoCusto);
            Controls.Add(label7);
            Controls.Add(quantItem);
            Controls.Add(label6);
            Controls.Add(comboUMed);
            Controls.Add(selectFornecedor);
            Controls.Add(label5);
            Controls.Add(dataGridFornecedores);
            Controls.Add(descItem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboStatus);
            Controls.Add(label2);
            Controls.Add(codigoBarras);
            Controls.Add(label1);
            Controls.Add(nomeItem);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CadastrarItensFront";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridFornecedores).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCodBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nomeItem;
        private Label label1;
        private Label label2;
        private TextBox codigoBarras;
        private ComboBox comboStatus;
        private Label label3;
        private Label label4;
        private TextBox descItem;
        private DataGridView dataGridFornecedores;
        private Label label5;
        private Label selectFornecedor;
        private ComboBox comboUMed;
        private Label label6;
        private Label label7;
        private TextBox quantItem;
        private Label label8;
        private TextBox precoCusto;
        private Label Lucro;
        private TextBox porcentLucro;
        private Label label9;
        private Label precoFinal;
        private Button newFornec;
        private Button buttonGravar;
        private Button buttonAtualizarTable;
        private CheckBox codMaual;
        private Button calcular;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCNPJ;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem newItem;
        private ToolStripMenuItem editarItem;
        private Button cancelar;
        private PictureBox pictureCodBar;
        private PictureBox pictureBox1;
        private Button btnImp;
        private Button btnSalvararquivo;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}