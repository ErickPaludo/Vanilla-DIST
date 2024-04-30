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
            TnomeItem = new TextBox();
            Snomeitem = new Label();
            Lcodbar = new Label();
            TcodigoBarras = new TextBox();
            comboStatus = new ComboBox();
            Lstatus = new Label();
            Ldesc = new Label();
            TdescItem = new TextBox();
            dataGridFornecedores = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCNPJ = new DataGridViewTextBoxColumn();
            Lfornecedor = new Label();
            Lselectfornecedor = new Label();
            comboUMed = new ComboBox();
            Lun = new Label();
            Lprecocusto = new Label();
            TprecoCusto = new TextBox();
            Llucro = new Label();
            TporcentLucro = new TextBox();
            Lpreco = new Label();
            LprecoFinal = new Label();
            newFornec = new Button();
            BGravar = new Button();
            buttonAtualizarTable = new Button();
            CcodMaual = new CheckBox();
            menuStrip = new MenuStrip();
            Smenu = new ToolStripMenuItem();
            Snovoitem = new ToolStripMenuItem();
            SeditarItem = new ToolStripMenuItem();
            Bcancelar = new Button();
            pictureCodBar = new PictureBox();
            Bimprimir = new Button();
            Bsalvararquivo = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pictureBox1 = new PictureBox();
            Taltura = new TextBox();
            Tcomprimento = new TextBox();
            TLargura = new TextBox();
            Lcubagen = new Label();
            Laltura = new Label();
            Lcomprimento = new Label();
            Llargura = new Label();
            Bselectend = new Button();
            Lenderecoselecionado = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridFornecedores).BeginInit();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCodBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TnomeItem
            // 
            TnomeItem.Enabled = false;
            TnomeItem.Location = new Point(30, 57);
            TnomeItem.MaxLength = 100;
            TnomeItem.Name = "TnomeItem";
            TnomeItem.Size = new Size(382, 23);
            TnomeItem.TabIndex = 0;
            // 
            // Snomeitem
            // 
            Snomeitem.AutoSize = true;
            Snomeitem.Enabled = false;
            Snomeitem.Location = new Point(30, 41);
            Snomeitem.Name = "Snomeitem";
            Snomeitem.Size = new Size(87, 15);
            Snomeitem.TabIndex = 3;
            Snomeitem.Text = "Nome do Item:";
            // 
            // Lcodbar
            // 
            Lcodbar.AutoSize = true;
            Lcodbar.Enabled = false;
            Lcodbar.Location = new Point(31, 449);
            Lcodbar.Name = "Lcodbar";
            Lcodbar.Size = new Size(100, 15);
            Lcodbar.TabIndex = 5;
            Lcodbar.Text = "Código de Barras:";
            // 
            // TcodigoBarras
            // 
            TcodigoBarras.Enabled = false;
            TcodigoBarras.Location = new Point(31, 467);
            TcodigoBarras.MaxLength = 13;
            TcodigoBarras.Name = "TcodigoBarras";
            TcodigoBarras.Size = new Size(142, 23);
            TcodigoBarras.TabIndex = 6;
            TcodigoBarras.KeyDown += Cod_KeyDown;
            TcodigoBarras.KeyPress += Cod_KeyPress;
            TcodigoBarras.Leave += VerificarCod;
            // 
            // comboStatus
            // 
            comboStatus.Cursor = Cursors.Hand;
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.Enabled = false;
            comboStatus.FormattingEnabled = true;
            comboStatus.ItemHeight = 15;
            comboStatus.Items.AddRange(new object[] { "Ativo", "Inativo", "Bloqueado" });
            comboStatus.Location = new Point(430, 57);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(89, 23);
            comboStatus.TabIndex = 2;
            // 
            // Lstatus
            // 
            Lstatus.AutoSize = true;
            Lstatus.Enabled = false;
            Lstatus.Location = new Point(430, 41);
            Lstatus.Name = "Lstatus";
            Lstatus.Size = new Size(42, 15);
            Lstatus.TabIndex = 9;
            Lstatus.Text = "Status:";
            // 
            // Ldesc
            // 
            Ldesc.AutoSize = true;
            Ldesc.Enabled = false;
            Ldesc.Location = new Point(32, 159);
            Ldesc.Name = "Ldesc";
            Ldesc.Size = new Size(105, 15);
            Ldesc.TabIndex = 10;
            Ldesc.Text = "Descrição do Item:";
            // 
            // TdescItem
            // 
            TdescItem.Enabled = false;
            TdescItem.Location = new Point(31, 177);
            TdescItem.Multiline = true;
            TdescItem.Name = "TdescItem";
            TdescItem.Size = new Size(443, 93);
            TdescItem.TabIndex = 4;
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
            dataGridFornecedores.Location = new Point(32, 304);
            dataGridFornecedores.Name = "dataGridFornecedores";
            dataGridFornecedores.ReadOnly = true;
            dataGridFornecedores.RowHeadersVisible = false;
            dataGridFornecedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridFornecedores.RowTemplate.Height = 25;
            dataGridFornecedores.Size = new Size(442, 136);
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
            // Lfornecedor
            // 
            Lfornecedor.AutoSize = true;
            Lfornecedor.Enabled = false;
            Lfornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lfornecedor.Location = new Point(31, 286);
            Lfornecedor.Name = "Lfornecedor";
            Lfornecedor.Size = new Size(74, 15);
            Lfornecedor.TabIndex = 13;
            Lfornecedor.Text = "Fornecedor:";
            // 
            // Lselectfornecedor
            // 
            Lselectfornecedor.AutoSize = true;
            Lselectfornecedor.Enabled = false;
            Lselectfornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Lselectfornecedor.Location = new Point(103, 286);
            Lselectfornecedor.Name = "Lselectfornecedor";
            Lselectfornecedor.Size = new Size(70, 15);
            Lselectfornecedor.TabIndex = 14;
            Lselectfornecedor.Text = "fornecedor";
            // 
            // comboUMed
            // 
            comboUMed.Cursor = Cursors.Hand;
            comboUMed.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUMed.Enabled = false;
            comboUMed.FormattingEnabled = true;
            comboUMed.ItemHeight = 15;
            comboUMed.Items.AddRange(new object[] { "UN", "Fardo", "Palete" });
            comboUMed.Location = new Point(540, 57);
            comboUMed.Name = "comboUMed";
            comboUMed.Size = new Size(83, 23);
            comboUMed.TabIndex = 3;
            // 
            // Lun
            // 
            Lun.AutoSize = true;
            Lun.Enabled = false;
            Lun.Location = new Point(540, 39);
            Lun.Name = "Lun";
            Lun.Size = new Size(48, 15);
            Lun.TabIndex = 16;
            Lun.Text = "U. Med:";
            // 
            // Lprecocusto
            // 
            Lprecocusto.AutoSize = true;
            Lprecocusto.Enabled = false;
            Lprecocusto.Location = new Point(29, 92);
            Lprecocusto.Name = "Lprecocusto";
            Lprecocusto.Size = new Size(90, 15);
            Lprecocusto.TabIndex = 20;
            Lprecocusto.Text = "Preço de Custo:";
            // 
            // TprecoCusto
            // 
            TprecoCusto.Enabled = false;
            TprecoCusto.Location = new Point(31, 110);
            TprecoCusto.MaxLength = 10;
            TprecoCusto.Name = "TprecoCusto";
            TprecoCusto.PlaceholderText = "R$00,00";
            TprecoCusto.Size = new Size(105, 23);
            TprecoCusto.TabIndex = 10;
            TprecoCusto.KeyDown += PrecoCusto_KeyDown;
            TprecoCusto.KeyPress += PrecoCusto_KeyPress;
            TprecoCusto.Leave += PadronizaPCusto;
            // 
            // Llucro
            // 
            Llucro.AutoSize = true;
            Llucro.Enabled = false;
            Llucro.Location = new Point(140, 92);
            Llucro.Name = "Llucro";
            Llucro.Size = new Size(40, 15);
            Llucro.TabIndex = 22;
            Llucro.Text = "Lucro:";
            // 
            // TporcentLucro
            // 
            TporcentLucro.Enabled = false;
            TporcentLucro.Location = new Point(142, 110);
            TporcentLucro.MaxLength = 5;
            TporcentLucro.Name = "TporcentLucro";
            TporcentLucro.PlaceholderText = "0,0%";
            TporcentLucro.Size = new Size(51, 23);
            TporcentLucro.TabIndex = 11;
            TporcentLucro.KeyDown += PercentLucro_KeyDown;
            TporcentLucro.KeyPress += PercentLucro_KeyPress;
            TporcentLucro.Leave += PadronizaPCusto;
            // 
            // Lpreco
            // 
            Lpreco.AutoSize = true;
            Lpreco.Enabled = false;
            Lpreco.Location = new Point(199, 114);
            Lpreco.Name = "Lpreco";
            Lpreco.Size = new Size(68, 15);
            Lpreco.TabIndex = 23;
            Lpreco.Text = "Preço Final:";
            // 
            // LprecoFinal
            // 
            LprecoFinal.AutoSize = true;
            LprecoFinal.Enabled = false;
            LprecoFinal.Location = new Point(273, 114);
            LprecoFinal.Name = "LprecoFinal";
            LprecoFinal.Size = new Size(20, 15);
            LprecoFinal.TabIndex = 24;
            LprecoFinal.Text = "R$";
            // 
            // newFornec
            // 
            newFornec.Enabled = false;
            newFornec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newFornec.Location = new Point(362, 275);
            newFornec.Name = "newFornec";
            newFornec.Size = new Size(112, 23);
            newFornec.TabIndex = 28;
            newFornec.Text = "Novo Fornecedor";
            newFornec.UseVisualStyleBackColor = true;
            newFornec.Click += AddFornecedor;
            // 
            // BGravar
            // 
            BGravar.Location = new Point(544, 354);
            BGravar.Name = "BGravar";
            BGravar.Size = new Size(60, 24);
            BGravar.TabIndex = 14;
            BGravar.Text = "Gravar";
            BGravar.UseVisualStyleBackColor = true;
            BGravar.Visible = false;
            BGravar.Click += buttonGravar_Click;
            // 
            // buttonAtualizarTable
            // 
            buttonAtualizarTable.Enabled = false;
            buttonAtualizarTable.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtualizarTable.Location = new Point(291, 275);
            buttonAtualizarTable.Name = "buttonAtualizarTable";
            buttonAtualizarTable.Size = new Size(65, 23);
            buttonAtualizarTable.TabIndex = 27;
            buttonAtualizarTable.Text = "Atualizar";
            buttonAtualizarTable.UseVisualStyleBackColor = true;
            buttonAtualizarTable.Click += buttonAtualizarTable_Click;
            // 
            // CcodMaual
            // 
            CcodMaual.AutoSize = true;
            CcodMaual.Enabled = false;
            CcodMaual.Location = new Point(179, 469);
            CcodMaual.Name = "CcodMaual";
            CcodMaual.Size = new Size(124, 19);
            CcodMaual.TabIndex = 7;
            CcodMaual.Text = "Inserir cod Manual";
            CcodMaual.UseVisualStyleBackColor = true;
            CcodMaual.CheckedChanged += codMaual_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { Smenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(662, 24);
            menuStrip.TabIndex = 30;
            menuStrip.Text = "menuStrip1";
            // 
            // Smenu
            // 
            Smenu.DropDownItems.AddRange(new ToolStripItem[] { Snovoitem, SeditarItem });
            Smenu.Name = "Smenu";
            Smenu.Size = new Size(50, 20);
            Smenu.Text = "Menu";
            // 
            // Snovoitem
            // 
            Snovoitem.Name = "Snovoitem";
            Snovoitem.Size = new Size(151, 22);
            Snovoitem.Text = "Cadastrar Item";
            Snovoitem.Click += NewItem;
            // 
            // SeditarItem
            // 
            SeditarItem.Name = "SeditarItem";
            SeditarItem.Size = new Size(151, 22);
            SeditarItem.Text = "Editar Item";
            SeditarItem.Click += EditItem;
            // 
            // Bcancelar
            // 
            Bcancelar.Enabled = false;
            Bcancelar.Location = new Point(540, 384);
            Bcancelar.Name = "Bcancelar";
            Bcancelar.Size = new Size(68, 24);
            Bcancelar.TabIndex = 13;
            Bcancelar.Text = "Cancelar";
            Bcancelar.UseVisualStyleBackColor = true;
            Bcancelar.Click += Cancelar;
            // 
            // pictureCodBar
            // 
            pictureCodBar.BackColor = SystemColors.ButtonHighlight;
            pictureCodBar.Location = new Point(32, 512);
            pictureCodBar.Name = "pictureCodBar";
            pictureCodBar.Size = new Size(609, 108);
            pictureCodBar.TabIndex = 32;
            pictureCodBar.TabStop = false;
            // 
            // Bimprimir
            // 
            Bimprimir.Enabled = false;
            Bimprimir.Location = new Point(490, 622);
            Bimprimir.Name = "Bimprimir";
            Bimprimir.Size = new Size(75, 23);
            Bimprimir.TabIndex = 9;
            Bimprimir.Text = "Imprimir";
            Bimprimir.UseVisualStyleBackColor = true;
            Bimprimir.Click += btnImp_Click;
            // 
            // Bsalvararquivo
            // 
            Bsalvararquivo.Enabled = false;
            Bsalvararquivo.Location = new Point(566, 622);
            Bsalvararquivo.Name = "Bsalvararquivo";
            Bsalvararquivo.Size = new Size(75, 23);
            Bsalvararquivo.TabIndex = 8;
            Bsalvararquivo.Text = "Salvar";
            Bsalvararquivo.UseVisualStyleBackColor = true;
            Bsalvararquivo.Click += btnSalvararquivo_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(31, 496);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(610, 124);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // Taltura
            // 
            Taltura.Enabled = false;
            Taltura.Location = new Point(523, 195);
            Taltura.Name = "Taltura";
            Taltura.Size = new Size(100, 23);
            Taltura.TabIndex = 34;
            Taltura.Leave += CalculaMetrosCubicos;
            // 
            // Tcomprimento
            // 
            Tcomprimento.Enabled = false;
            Tcomprimento.Location = new Point(523, 239);
            Tcomprimento.Name = "Tcomprimento";
            Tcomprimento.Size = new Size(100, 23);
            Tcomprimento.TabIndex = 35;
            Tcomprimento.Leave += CalculaMetrosCubicos;
            // 
            // TLargura
            // 
            TLargura.Enabled = false;
            TLargura.Location = new Point(523, 286);
            TLargura.Name = "TLargura";
            TLargura.Size = new Size(100, 23);
            TLargura.TabIndex = 36;
            TLargura.Leave += CalculaMetrosCubicos;
            // 
            // Lcubagen
            // 
            Lcubagen.AutoSize = true;
            Lcubagen.Enabled = false;
            Lcubagen.Location = new Point(566, 312);
            Lcubagen.Name = "Lcubagen";
            Lcubagen.Size = new Size(22, 15);
            Lcubagen.TabIndex = 37;
            Lcubagen.Text = "m³";
            // 
            // Laltura
            // 
            Laltura.AutoSize = true;
            Laltura.Enabled = false;
            Laltura.Location = new Point(523, 177);
            Laltura.Name = "Laltura";
            Laltura.Size = new Size(42, 15);
            Laltura.TabIndex = 38;
            Laltura.Text = "Altura:";
            // 
            // Lcomprimento
            // 
            Lcomprimento.AutoSize = true;
            Lcomprimento.Enabled = false;
            Lcomprimento.Location = new Point(523, 221);
            Lcomprimento.Name = "Lcomprimento";
            Lcomprimento.Size = new Size(85, 15);
            Lcomprimento.TabIndex = 39;
            Lcomprimento.Text = "Comprimento:";
            // 
            // Llargura
            // 
            Llargura.AutoSize = true;
            Llargura.Enabled = false;
            Llargura.Location = new Point(523, 268);
            Llargura.Name = "Llargura";
            Llargura.Size = new Size(50, 15);
            Llargura.TabIndex = 40;
            Llargura.Text = "Largura:";
            // 
            // Bselectend
            // 
            Bselectend.Enabled = false;
            Bselectend.Location = new Point(325, 110);
            Bselectend.Name = "Bselectend";
            Bselectend.Size = new Size(194, 24);
            Bselectend.TabIndex = 41;
            Bselectend.Text = "Seleciona Picking";
            Bselectend.UseVisualStyleBackColor = true;
            Bselectend.Click += SelectEnd;
            // 
            // Lenderecoselecionado
            // 
            Lenderecoselecionado.AutoSize = true;
            Lenderecoselecionado.Location = new Point(536, 115);
            Lenderecoselecionado.Name = "Lenderecoselecionado";
            Lenderecoselecionado.Size = new Size(90, 15);
            Lenderecoselecionado.TabIndex = 42;
            Lenderecoselecionado.Text = "(Sem Endereço)";
            // 
            // CadastrarItensFront
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(662, 657);
            Controls.Add(Lenderecoselecionado);
            Controls.Add(Bselectend);
            Controls.Add(Llargura);
            Controls.Add(Lcomprimento);
            Controls.Add(Laltura);
            Controls.Add(Lcubagen);
            Controls.Add(TLargura);
            Controls.Add(Tcomprimento);
            Controls.Add(Taltura);
            Controls.Add(Lcodbar);
            Controls.Add(Bsalvararquivo);
            Controls.Add(Bimprimir);
            Controls.Add(pictureCodBar);
            Controls.Add(Bcancelar);
            Controls.Add(CcodMaual);
            Controls.Add(buttonAtualizarTable);
            Controls.Add(BGravar);
            Controls.Add(newFornec);
            Controls.Add(LprecoFinal);
            Controls.Add(Lpreco);
            Controls.Add(Llucro);
            Controls.Add(TporcentLucro);
            Controls.Add(Lprecocusto);
            Controls.Add(TprecoCusto);
            Controls.Add(Lun);
            Controls.Add(comboUMed);
            Controls.Add(Lselectfornecedor);
            Controls.Add(Lfornecedor);
            Controls.Add(dataGridFornecedores);
            Controls.Add(TdescItem);
            Controls.Add(Ldesc);
            Controls.Add(Lstatus);
            Controls.Add(comboStatus);
            Controls.Add(TcodigoBarras);
            Controls.Add(Snomeitem);
            Controls.Add(TnomeItem);
            Controls.Add(menuStrip);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CadastrarItensFront";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridFornecedores).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCodBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TnomeItem;
        private Label Snomeitem;
        private Label Lcodbar;
        private TextBox TcodigoBarras;
        private ComboBox comboStatus;
        private Label Lstatus;
        private Label Ldesc;
        private TextBox TdescItem;
        private DataGridView dataGridFornecedores;
        private Label Lfornecedor;
        private Label Lselectfornecedor;
        private ComboBox comboUMed;
        private Label Lun;
        private Label Lprecocusto;
        private TextBox TprecoCusto;
        private Label Llucro;
        private TextBox TporcentLucro;
        private Label Lpreco;
        private Label LprecoFinal;
        private Button newFornec;
        private Button BGravar;
        private Button buttonAtualizarTable;
        private CheckBox CcodMaual;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCNPJ;
        private MenuStrip menuStrip;
        private ToolStripMenuItem Smenu;
        private ToolStripMenuItem Snovoitem;
        private ToolStripMenuItem SeditarItem;
        private Button Bcancelar;
        private PictureBox pictureCodBar;
        private Button Bimprimir;
        private Button Bsalvararquivo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pictureBox1;
        private TextBox Taltura;
        private TextBox Tcomprimento;
        private TextBox TLargura;
        private Label Lcubagen;
        private Label Laltura;
        private Label Lcomprimento;
        private Label Llargura;
        private Button Bselectend;
        private Label Lenderecoselecionado;
    }
}