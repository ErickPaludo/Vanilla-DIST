﻿namespace Vanilla
{
    partial class CadastroCd
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCd));
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            prediobox = new TextBox();
            laandares = new TextBox();
            button1 = new Button();
            atualizar = new Button();
            dataGridpar = new DataGridView();
            ColumnReg = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridimpar = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ColumnRegImp = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            minemp = new TextBox();
            dataGridruas = new DataGridView();
            Ruas = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnStatus_ = new DataGridViewTextBoxColumn();
            ColumnBtnSalva = new DataGridViewImageColumn();
            pictureCodBar = new PictureBox();
            button3 = new Button();
            checkBoxPar = new CheckBox();
            checkBoxImpar = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBoxSubLa = new TextBox();
            labelsubla = new Label();
            dataGridPicking = new DataGridView();
            ColumnPicking = new DataGridViewTextBoxColumn();
            ColumnItem = new DataGridViewTextBoxColumn();
            checkBoxSubla = new CheckBox();
            textBoxNomeR = new TextBox();
            label6 = new Label();
            textBoxNameRegiao = new TextBox();
            button5 = new Button();
            textBoxCodReg = new TextBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            dataGridViewReg = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            Batualizar = new Button();
            Bcadastrar = new Button();
            Tnamereg = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridpar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridimpar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridruas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCodBar).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPicking).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReg).BeginInit();
            SuspendLayout();
            // 
            // prediobox
            // 
            prediobox.Location = new Point(161, 15);
            prediobox.MaxLength = 3;
            prediobox.Name = "prediobox";
            prediobox.Size = new Size(120, 23);
            prediobox.TabIndex = 0;
            prediobox.KeyPress += SomenteNumeros;
            // 
            // laandares
            // 
            laandares.Location = new Point(161, 44);
            laandares.MaxLength = 3;
            laandares.Name = "laandares";
            laandares.Size = new Size(120, 23);
            laandares.TabIndex = 1;
            laandares.KeyPress += SomenteNumeros;
            // 
            // button1
            // 
            button1.Location = new Point(653, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GerarCd;
            // 
            // atualizar
            // 
            atualizar.Location = new Point(653, 864);
            atualizar.Name = "atualizar";
            atualizar.Size = new Size(75, 23);
            atualizar.TabIndex = 14;
            atualizar.Text = "Atualizar";
            atualizar.UseVisualStyleBackColor = true;
            atualizar.Click += Atualizar;
            // 
            // dataGridpar
            // 
            dataGridpar.AllowUserToAddRows = false;
            dataGridpar.AllowUserToDeleteRows = false;
            dataGridpar.Anchor = AnchorStyles.None;
            dataGridpar.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridpar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridpar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridpar.Columns.AddRange(new DataGridViewColumn[] { ColumnReg, dataGridViewTextBoxColumn1 });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridpar.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridpar.Location = new Point(404, 289);
            dataGridpar.Name = "dataGridpar";
            dataGridpar.ReadOnly = true;
            dataGridpar.RowHeadersVisible = false;
            dataGridpar.RowTemplate.Height = 25;
            dataGridpar.Size = new Size(324, 119);
            dataGridpar.TabIndex = 15;
            dataGridpar.CellClick += SelecionaEnderecoPar;
            // 
            // ColumnReg
            // 
            ColumnReg.HeaderText = "Reg";
            ColumnReg.Name = "ColumnReg";
            ColumnReg.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Lado Par";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridimpar
            // 
            dataGridimpar.AllowUserToAddRows = false;
            dataGridimpar.AllowUserToDeleteRows = false;
            dataGridimpar.Anchor = AnchorStyles.None;
            dataGridimpar.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridimpar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridimpar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridimpar.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, ColumnRegImp });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridimpar.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridimpar.Location = new Point(17, 289);
            dataGridimpar.Name = "dataGridimpar";
            dataGridimpar.ReadOnly = true;
            dataGridimpar.RowHeadersVisible = false;
            dataGridimpar.RowTemplate.Height = 25;
            dataGridimpar.Size = new Size(341, 119);
            dataGridimpar.TabIndex = 16;
            dataGridimpar.CellClick += SelecionaEnderecoImpar;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Lado Impar";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ColumnRegImp
            // 
            ColumnRegImp.HeaderText = "Reg";
            ColumnRegImp.Name = "ColumnRegImp";
            ColumnRegImp.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 17;
            label1.Text = "Quantidade de Predios:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 47);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 18;
            label2.Text = "Andares de Predios:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 73);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 20;
            label3.Text = "Andar mín empilhadeira:";
            // 
            // minemp
            // 
            minemp.Location = new Point(161, 70);
            minemp.MaxLength = 3;
            minemp.Name = "minemp";
            minemp.Size = new Size(120, 23);
            minemp.TabIndex = 3;
            minemp.KeyPress += SomenteNumeros;
            // 
            // dataGridruas
            // 
            dataGridruas.AllowUserToAddRows = false;
            dataGridruas.AllowUserToDeleteRows = false;
            dataGridruas.Anchor = AnchorStyles.None;
            dataGridruas.BackgroundColor = SystemColors.Control;
            dataGridruas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridruas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridruas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridruas.Columns.AddRange(new DataGridViewColumn[] { Ruas, ColumnNome, ColumnStatus_, ColumnBtnSalva });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dataGridruas.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridruas.Location = new Point(17, 158);
            dataGridruas.Name = "dataGridruas";
            dataGridruas.ReadOnly = true;
            dataGridruas.RowHeadersVisible = false;
            dataGridruas.RowTemplate.Height = 25;
            dataGridruas.Size = new Size(711, 125);
            dataGridruas.TabIndex = 21;
            dataGridruas.CellClick += SelecionaRua;
            dataGridruas.CellContentClick += dataGridRuas_CellContentClick;
            dataGridruas.CellFormatting += dataGridRuas_CellFormatting;
            // 
            // Ruas
            // 
            Ruas.HeaderText = "Ruas";
            Ruas.Name = "Ruas";
            Ruas.ReadOnly = true;
            // 
            // ColumnNome
            // 
            ColumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnNome.HeaderText = "Nome";
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnStatus_
            // 
            ColumnStatus_.HeaderText = "Status";
            ColumnStatus_.Name = "ColumnStatus_";
            ColumnStatus_.ReadOnly = true;
            // 
            // ColumnBtnSalva
            // 
            ColumnBtnSalva.HeaderText = "";
            ColumnBtnSalva.Image = (Image)resources.GetObject("ColumnBtnSalva.Image");
            ColumnBtnSalva.Name = "ColumnBtnSalva";
            ColumnBtnSalva.ReadOnly = true;
            ColumnBtnSalva.Resizable = DataGridViewTriState.True;
            ColumnBtnSalva.Width = 50;
            // 
            // pictureCodBar
            // 
            pictureCodBar.Anchor = AnchorStyles.None;
            pictureCodBar.BackColor = SystemColors.ButtonHighlight;
            pictureCodBar.Location = new Point(121, 554);
            pictureCodBar.Name = "pictureCodBar";
            pictureCodBar.Size = new Size(528, 108);
            pictureCodBar.TabIndex = 34;
            pictureCodBar.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(6, 668);
            button3.Name = "button3";
            button3.Size = new Size(158, 23);
            button3.TabIndex = 36;
            button3.Text = "Salvar Endereço Prédio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += SalvarCodUnitario;
            // 
            // checkBoxPar
            // 
            checkBoxPar.AutoSize = true;
            checkBoxPar.Checked = true;
            checkBoxPar.CheckState = CheckState.Checked;
            checkBoxPar.Location = new Point(137, 106);
            checkBoxPar.Name = "checkBoxPar";
            checkBoxPar.Size = new Size(100, 19);
            checkBoxPar.TabIndex = 11;
            checkBoxPar.Text = "Gerar lado par";
            checkBoxPar.UseVisualStyleBackColor = true;
            // 
            // checkBoxImpar
            // 
            checkBoxImpar.AutoSize = true;
            checkBoxImpar.Checked = true;
            checkBoxImpar.CheckState = CheckState.Checked;
            checkBoxImpar.Location = new Point(17, 105);
            checkBoxImpar.Name = "checkBoxImpar";
            checkBoxImpar.Size = new Size(114, 19);
            checkBoxImpar.TabIndex = 10;
            checkBoxImpar.Text = "Gerar lado impar";
            checkBoxImpar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(5, 9);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(749, 723);
            tabControl1.TabIndex = 39;
            tabControl1.Click += AtualizaTable;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBoxSubLa);
            tabPage1.Controls.Add(labelsubla);
            tabPage1.Controls.Add(dataGridPicking);
            tabPage1.Controls.Add(checkBoxSubla);
            tabPage1.Controls.Add(textBoxNomeR);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBoxNameRegiao);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(textBoxCodReg);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dataGridruas);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(atualizar);
            tabPage1.Controls.Add(dataGridimpar);
            tabPage1.Controls.Add(checkBoxImpar);
            tabPage1.Controls.Add(pictureCodBar);
            tabPage1.Controls.Add(laandares);
            tabPage1.Controls.Add(checkBoxPar);
            tabPage1.Controls.Add(prediobox);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridpar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(minemp);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(741, 695);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Layout do CD";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxSubLa
            // 
            textBoxSubLa.Enabled = false;
            textBoxSubLa.Location = new Point(655, 73);
            textBoxSubLa.MaxLength = 3;
            textBoxSubLa.Name = "textBoxSubLa";
            textBoxSubLa.Size = new Size(73, 23);
            textBoxSubLa.TabIndex = 8;
            textBoxSubLa.KeyPress += SomenteNumeros;
            // 
            // labelsubla
            // 
            labelsubla.AutoSize = true;
            labelsubla.Enabled = false;
            labelsubla.Location = new Point(544, 78);
            labelsubla.Name = "labelsubla";
            labelsubla.Size = new Size(105, 15);
            labelsubla.TabIndex = 47;
            labelsubla.Text = "Andares do SubLa:";
            // 
            // dataGridPicking
            // 
            dataGridPicking.AllowUserToAddRows = false;
            dataGridPicking.AllowUserToDeleteRows = false;
            dataGridPicking.Anchor = AnchorStyles.None;
            dataGridPicking.BackgroundColor = SystemColors.Control;
            dataGridPicking.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = SystemColors.Control;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dataGridPicking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridPicking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPicking.Columns.AddRange(new DataGridViewColumn[] { ColumnPicking, ColumnItem });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dataGridPicking.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridPicking.Location = new Point(17, 414);
            dataGridPicking.Name = "dataGridPicking";
            dataGridPicking.ReadOnly = true;
            dataGridPicking.RowHeadersVisible = false;
            dataGridPicking.RowTemplate.Height = 25;
            dataGridPicking.Size = new Size(711, 134);
            dataGridPicking.TabIndex = 46;
            dataGridPicking.CellClick += SelecionaPicking;
            // 
            // ColumnPicking
            // 
            ColumnPicking.HeaderText = "Picking";
            ColumnPicking.Name = "ColumnPicking";
            ColumnPicking.ReadOnly = true;
            ColumnPicking.Width = 200;
            // 
            // ColumnItem
            // 
            ColumnItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnItem.HeaderText = "Item";
            ColumnItem.Name = "ColumnItem";
            ColumnItem.ReadOnly = true;
            // 
            // checkBoxSubla
            // 
            checkBoxSubla.AutoSize = true;
            checkBoxSubla.Location = new Point(295, 75);
            checkBoxSubla.Name = "checkBoxSubla";
            checkBoxSubla.Size = new Size(139, 19);
            checkBoxSubla.TabIndex = 7;
            checkBoxSubla.Text = "Gerar SubLa (Picking)";
            checkBoxSubla.UseVisualStyleBackColor = true;
            checkBoxSubla.CheckedChanged += CheckSubLa;
            // 
            // textBoxNomeR
            // 
            textBoxNomeR.Location = new Point(364, 44);
            textBoxNomeR.MaxLength = 15;
            textBoxNomeR.Name = "textBoxNomeR";
            textBoxNomeR.Size = new Size(364, 23);
            textBoxNomeR.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 47);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 43;
            label6.Text = "Nome rua:";
            // 
            // textBoxNameRegiao
            // 
            textBoxNameRegiao.Enabled = false;
            textBoxNameRegiao.Location = new Point(464, 15);
            textBoxNameRegiao.Name = "textBoxNameRegiao";
            textBoxNameRegiao.Size = new Size(264, 23);
            textBoxNameRegiao.TabIndex = 42;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGray;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(430, 13);
            button5.Name = "button5";
            button5.Size = new Size(28, 25);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += BtnPesquisarRegioes;
            // 
            // textBoxCodReg
            // 
            textBoxCodReg.Location = new Point(353, 15);
            textBoxCodReg.MaxLength = 4;
            textBoxCodReg.Name = "textBoxCodReg";
            textBoxCodReg.Size = new Size(71, 23);
            textBoxCodReg.TabIndex = 5;
            textBoxCodReg.KeyPress += SomenteNumeros;
            textBoxCodReg.Leave += Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 18);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 40;
            label5.Text = "Reg.Sep:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewReg);
            tabPage2.Controls.Add(Batualizar);
            tabPage2.Controls.Add(Bcadastrar);
            tabPage2.Controls.Add(Tnamereg);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(741, 695);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Região de Armazenamento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReg
            // 
            dataGridViewReg.AllowUserToAddRows = false;
            dataGridViewReg.AllowUserToDeleteRows = false;
            dataGridViewReg.Anchor = AnchorStyles.None;
            dataGridViewReg.BackgroundColor = SystemColors.Control;
            dataGridViewReg.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dataGridViewReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewReg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReg.Columns.AddRange(new DataGridViewColumn[] { ColumnId, dataGridViewTextBoxColumn3, ColumnStatus });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dataGridViewReg.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewReg.Location = new Point(12, 85);
            dataGridViewReg.Name = "dataGridViewReg";
            dataGridViewReg.ReadOnly = true;
            dataGridViewReg.RowHeadersVisible = false;
            dataGridViewReg.RowTemplate.Height = 25;
            dataGridViewReg.Size = new Size(718, 448);
            dataGridViewReg.TabIndex = 24;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "ID";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Nome da Região";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            // 
            // Batualizar
            // 
            Batualizar.Location = new Point(655, 584);
            Batualizar.Name = "Batualizar";
            Batualizar.Size = new Size(75, 23);
            Batualizar.TabIndex = 23;
            Batualizar.Text = "Atualizar";
            Batualizar.UseVisualStyleBackColor = true;
            Batualizar.Click += AtualizaTable;
            // 
            // Bcadastrar
            // 
            Bcadastrar.Location = new Point(421, 33);
            Bcadastrar.Name = "Bcadastrar";
            Bcadastrar.Size = new Size(75, 23);
            Bcadastrar.TabIndex = 22;
            Bcadastrar.Text = "Cadastrar";
            Bcadastrar.UseVisualStyleBackColor = true;
            Bcadastrar.Click += RegistraArmz;
            // 
            // Tnamereg
            // 
            Tnamereg.Location = new Point(120, 33);
            Tnamereg.MaxLength = 30;
            Tnamereg.Name = "Tnamereg";
            Tnamereg.Size = new Size(284, 23);
            Tnamereg.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 36);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 19;
            label4.Text = "Nome da Região:";
            // 
            // CadastroCd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(757, 731);
            Controls.Add(tabControl1);
            Name = "CadastroCd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroCd";
            ((System.ComponentModel.ISupportInitialize)dataGridpar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridimpar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridruas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCodBar).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPicking).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox prediobox;
        private TextBox laandares;
        private Button button1;
        private DataGridView dataGridruas;
        private DataGridViewTextBoxColumn ColumnRua;
        private Button atualizar;
        private DataGridView dataGridpar;
        private DataGridView dataGridimpar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox minemp;
        private PictureBox pictureCodBar;
        private Button button3;
        private CheckBox checkBoxPar;
        private CheckBox checkBoxImpar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox Tnamereg;
        private Label label4;
        private DataGridView dataGridViewReg;
        private Button Batualizar;
        private Button Bcadastrar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn ColumnStatus;
        private TextBox textBoxCodReg;
        private Label label5;
        private TextBox textBoxNameRegiao;
        private Button button5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ColumnRegImp;
        private Label label6;
        private TextBox textBoxNomeR;
        private DataGridViewTextBoxColumn Ruas;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnStatus_;
        private DataGridViewImageColumn ColumnBtnSalva;
        private CheckBox checkBoxSubla;
        private DataGridView dataGridPicking;
        private DataGridViewTextBoxColumn ColumnPicking;
        private DataGridViewTextBoxColumn ColumnItem;
        private TextBox textBoxSubLa;
        private Label labelsubla;
        private DataGridViewTextBoxColumn ColumnReg;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}