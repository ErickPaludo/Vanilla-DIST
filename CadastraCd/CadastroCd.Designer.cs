namespace Vanilla
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCd));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            prediobox = new TextBox();
            laandares = new TextBox();
            button1 = new Button();
            atualizar = new Button();
            dataGridpar = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColumnReg = new DataGridViewTextBoxColumn();
            dataGridimpar = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ColumnRegImp = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            minemp = new TextBox();
            dataGridruas = new DataGridView();
            Ruas = new DataGridViewTextBoxColumn();
            ColumnBtnSalva = new DataGridViewButtonColumn();
            pictureCodBar = new PictureBox();
            button3 = new Button();
            checkBoxPar = new CheckBox();
            checkBoxImpar = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBoxNameRegiao = new TextBox();
            button5 = new Button();
            textBoxCodReg = new TextBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            dataGridViewReg = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            button4 = new Button();
            buttonCadRegion = new Button();
            textBoxNameReg = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridpar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridimpar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridruas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCodBar).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReg).BeginInit();
            SuspendLayout();
            // 
            // prediobox
            // 
            prediobox.Location = new Point(161, 15);
            prediobox.Name = "prediobox";
            prediobox.Size = new Size(120, 23);
            prediobox.TabIndex = 0;
            // 
            // laandares
            // 
            laandares.Location = new Point(161, 44);
            laandares.Name = "laandares";
            laandares.Size = new Size(120, 23);
            laandares.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(562, 65);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GerarCd;
            // 
            // atualizar
            // 
            atualizar.Location = new Point(663, 577);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridpar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridpar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridpar.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ColumnReg });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridpar.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridpar.Location = new Point(389, 312);
            dataGridpar.Name = "dataGridpar";
            dataGridpar.ReadOnly = true;
            dataGridpar.RowHeadersVisible = false;
            dataGridpar.RowTemplate.Height = 25;
            dataGridpar.Size = new Size(360, 138);
            dataGridpar.TabIndex = 15;
            dataGridpar.CellClick += SelecionaEnderecoPar;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Lado Par";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ColumnReg
            // 
            ColumnReg.HeaderText = "Reg";
            ColumnReg.Name = "ColumnReg";
            ColumnReg.ReadOnly = true;
            // 
            // dataGridimpar
            // 
            dataGridimpar.AllowUserToAddRows = false;
            dataGridimpar.AllowUserToDeleteRows = false;
            dataGridimpar.Anchor = AnchorStyles.None;
            dataGridimpar.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridimpar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridimpar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridimpar.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, ColumnRegImp });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridimpar.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridimpar.Location = new Point(7, 312);
            dataGridimpar.Name = "dataGridimpar";
            dataGridimpar.ReadOnly = true;
            dataGridimpar.RowHeadersVisible = false;
            dataGridimpar.RowTemplate.Height = 25;
            dataGridimpar.Size = new Size(360, 138);
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
            minemp.Name = "minemp";
            minemp.Size = new Size(120, 23);
            minemp.TabIndex = 19;
            // 
            // dataGridruas
            // 
            dataGridruas.AllowUserToAddRows = false;
            dataGridruas.AllowUserToDeleteRows = false;
            dataGridruas.Anchor = AnchorStyles.None;
            dataGridruas.BackgroundColor = SystemColors.Control;
            dataGridruas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridruas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridruas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridruas.Columns.AddRange(new DataGridViewColumn[] { Ruas, ColumnBtnSalva });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridruas.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridruas.Location = new Point(7, 105);
            dataGridruas.Name = "dataGridruas";
            dataGridruas.ReadOnly = true;
            dataGridruas.RowHeadersVisible = false;
            dataGridruas.RowTemplate.Height = 25;
            dataGridruas.Size = new Size(741, 170);
            dataGridruas.TabIndex = 21;
            dataGridruas.CellClick += SelecionaRua;
            dataGridruas.CellContentClick += dataGridRuas_CellContentClick;
            dataGridruas.CellFormatting += dataGridRuas_CellFormatting;
            // 
            // Ruas
            // 
            Ruas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ruas.HeaderText = "Ruas";
            Ruas.Name = "Ruas";
            Ruas.ReadOnly = true;
            // 
            // ColumnBtnSalva
            // 
            ColumnBtnSalva.HeaderText = "";
            ColumnBtnSalva.Name = "ColumnBtnSalva";
            ColumnBtnSalva.ReadOnly = true;
            ColumnBtnSalva.Text = "Imp";
            // 
            // pictureCodBar
            // 
            pictureCodBar.Anchor = AnchorStyles.None;
            pictureCodBar.BackColor = SystemColors.ButtonHighlight;
            pictureCodBar.Location = new Point(109, 463);
            pictureCodBar.Name = "pictureCodBar";
            pictureCodBar.Size = new Size(528, 108);
            pictureCodBar.TabIndex = 34;
            pictureCodBar.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(7, 577);
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
            checkBoxPar.Location = new Point(295, 48);
            checkBoxPar.Name = "checkBoxPar";
            checkBoxPar.Size = new Size(100, 19);
            checkBoxPar.TabIndex = 37;
            checkBoxPar.Text = "Gerar lado par";
            checkBoxPar.UseVisualStyleBackColor = true;
            // 
            // checkBoxImpar
            // 
            checkBoxImpar.AutoSize = true;
            checkBoxImpar.Checked = true;
            checkBoxImpar.CheckState = CheckState.Checked;
            checkBoxImpar.Location = new Point(401, 48);
            checkBoxImpar.Name = "checkBoxImpar";
            checkBoxImpar.Size = new Size(114, 19);
            checkBoxImpar.TabIndex = 38;
            checkBoxImpar.Text = "Gerar lado impar";
            checkBoxImpar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 5);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(763, 645);
            tabControl1.TabIndex = 39;
            tabControl1.Click += AtualizaTable;
            // 
            // tabPage1
            // 
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
            tabPage1.Size = new Size(755, 617);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Layout do CD";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxNameRegiao
            // 
            textBoxNameRegiao.Enabled = false;
            textBoxNameRegiao.Location = new Point(464, 15);
            textBoxNameRegiao.Name = "textBoxNameRegiao";
            textBoxNameRegiao.Size = new Size(224, 23);
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
            button5.TabIndex = 41;
            button5.UseVisualStyleBackColor = false;
            button5.Click += BtnPesquisarRegioes;
            // 
            // textBoxCodReg
            // 
            textBoxCodReg.Location = new Point(353, 15);
            textBoxCodReg.Name = "textBoxCodReg";
            textBoxCodReg.Size = new Size(71, 23);
            textBoxCodReg.TabIndex = 39;
            textBoxCodReg.KeyPress += textBoxCodReg_KeyPress;
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
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(buttonCadRegion);
            tabPage2.Controls.Add(textBoxNameReg);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(755, 617);
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewReg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReg.Columns.AddRange(new DataGridViewColumn[] { ColumnId, dataGridViewTextBoxColumn3, ColumnStatus });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewReg.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewReg.Location = new Point(16, 124);
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
            // button4
            // 
            button4.Location = new Point(659, 578);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 23;
            button4.Text = "Atualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AtualizaTable;
            // 
            // buttonCadRegion
            // 
            buttonCadRegion.Location = new Point(218, 82);
            buttonCadRegion.Name = "buttonCadRegion";
            buttonCadRegion.Size = new Size(75, 23);
            buttonCadRegion.TabIndex = 22;
            buttonCadRegion.Text = "Cadastrar";
            buttonCadRegion.UseVisualStyleBackColor = true;
            buttonCadRegion.Click += RegistraArmz;
            // 
            // textBoxNameReg
            // 
            textBoxNameReg.Location = new Point(120, 33);
            textBoxNameReg.MaxLength = 25;
            textBoxNameReg.Name = "textBoxNameReg";
            textBoxNameReg.Size = new Size(284, 23);
            textBoxNameReg.TabIndex = 18;
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
            ClientSize = new Size(761, 659);
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
        private TextBox textBoxNameReg;
        private Label label4;
        private DataGridView dataGridViewReg;
        private Button button4;
        private Button buttonCadRegion;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn ColumnStatus;
        private TextBox textBoxCodReg;
        private Label label5;
        private TextBox textBoxNameRegiao;
        private Button button5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColumnReg;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ColumnRegImp;
        private DataGridViewTextBoxColumn Ruas;
        private DataGridViewButtonColumn ColumnBtnSalva;
    }
}