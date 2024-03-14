namespace Vanilla
{
    partial class AlterarUsersGeral
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarUsersGeral));
            dataGridUser = new DataGridView();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnUser = new DataGridViewTextBoxColumn();
            ColumnCPF = new DataGridViewTextBoxColumn();
            label12 = new Label();
            emailBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            gravarBox = new Button();
            comboPerm = new ComboBox();
            comboStatus = new ComboBox();
            confPassBox = new TextBox();
            passBox = new TextBox();
            userBox = new TextBox();
            nomeCompleto = new TextBox();
            camppesq = new TextBox();
            search = new Button();
            button2 = new Button();
            telfBox2 = new MaskedTextBox();
            telfBox = new MaskedTextBox();
            label13 = new Label();
            label14 = new Label();
            encaminhar = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridUser
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn13, ColumnName, ColumnUser, ColumnCPF });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridUser.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridUser.Location = new Point(12, 55);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridUser.RowHeadersVisible = false;
            dataGridUser.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUser.RowTemplate.Height = 25;
            dataGridUser.Size = new Size(463, 234);
            dataGridUser.TabIndex = 17;
            dataGridUser.CellDoubleClick += SelecionaCell;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Id";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 70;
            // 
            // ColumnName
            // 
            ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnName.HeaderText = "Nome";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            // 
            // ColumnUser
            // 
            ColumnUser.HeaderText = "Usuário";
            ColumnUser.Name = "ColumnUser";
            ColumnUser.ReadOnly = true;
            // 
            // ColumnCPF
            // 
            ColumnCPF.HeaderText = "CPF";
            ColumnCPF.Name = "ColumnCPF";
            ColumnCPF.ReadOnly = true;
            ColumnCPF.Width = 150;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(488, 83);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 52;
            label12.Text = "Email:";
            // 
            // emailBox
            // 
            emailBox.Cursor = Cursors.Hand;
            emailBox.Enabled = false;
            emailBox.Location = new Point(488, 101);
            emailBox.MaxLength = 50;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(468, 23);
            emailBox.TabIndex = 6;
            emailBox.Leave += ValidaEmail;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(653, 248);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 51;
            label11.Text = "Confirmar senha:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(653, 203);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 50;
            label10.Text = "Senha:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(653, 152);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 49;
            label9.Text = "Nome de usuário:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(845, 203);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 48;
            label8.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(845, 152);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 47;
            label7.Text = "Permissão:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 37);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 39;
            label1.Text = "Nome Completo:";
            // 
            // gravarBox
            // 
            gravarBox.Cursor = Cursors.Hand;
            gravarBox.Location = new Point(678, 295);
            gravarBox.Name = "gravarBox";
            gravarBox.Size = new Size(118, 23);
            gravarBox.TabIndex = 15;
            gravarBox.Text = "Gravar";
            gravarBox.UseVisualStyleBackColor = true;
            gravarBox.Click += Gravar;
            // 
            // comboPerm
            // 
            comboPerm.Cursor = Cursors.Hand;
            comboPerm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPerm.Enabled = false;
            comboPerm.FormattingEnabled = true;
            comboPerm.Items.AddRange(new object[] { "Administrador", "Padrão" });
            comboPerm.Location = new Point(845, 170);
            comboPerm.Name = "comboPerm";
            comboPerm.Size = new Size(111, 23);
            comboPerm.TabIndex = 10;
            // 
            // comboStatus
            // 
            comboStatus.Cursor = Cursors.Hand;
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.Enabled = false;
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Ativo", "Inativo", "Bloqueado" });
            comboStatus.Location = new Point(845, 221);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(111, 23);
            comboStatus.TabIndex = 11;
            // 
            // confPassBox
            // 
            confPassBox.Cursor = Cursors.Hand;
            confPassBox.Enabled = false;
            confPassBox.Location = new Point(653, 266);
            confPassBox.MaxLength = 15;
            confPassBox.Name = "confPassBox";
            confPassBox.Size = new Size(176, 23);
            confPassBox.TabIndex = 14;
            // 
            // passBox
            // 
            passBox.Cursor = Cursors.Hand;
            passBox.Enabled = false;
            passBox.Location = new Point(653, 221);
            passBox.MaxLength = 15;
            passBox.Name = "passBox";
            passBox.Size = new Size(176, 23);
            passBox.TabIndex = 13;
            // 
            // userBox
            // 
            userBox.Cursor = Cursors.Hand;
            userBox.Enabled = false;
            userBox.Location = new Point(653, 170);
            userBox.MaxLength = 15;
            userBox.Name = "userBox";
            userBox.Size = new Size(176, 23);
            userBox.TabIndex = 12;
            // 
            // nomeCompleto
            // 
            nomeCompleto.Cursor = Cursors.Hand;
            nomeCompleto.Enabled = false;
            nomeCompleto.Location = new Point(488, 55);
            nomeCompleto.MaxLength = 50;
            nomeCompleto.Name = "nomeCompleto";
            nomeCompleto.Size = new Size(468, 23);
            nomeCompleto.TabIndex = 2;
            // 
            // camppesq
            // 
            camppesq.Location = new Point(12, 26);
            camppesq.Name = "camppesq";
            camppesq.Size = new Size(201, 23);
            camppesq.TabIndex = 0;
            // 
            // search
            // 
            search.Cursor = Cursors.Hand;
            search.Location = new Point(219, 26);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 1;
            search.Text = "Pesquisar";
            search.UseVisualStyleBackColor = true;
            search.Click += Pesquisar;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(12, 495);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Reload;
            // 
            // telfBox2
            // 
            telfBox2.Location = new Point(488, 221);
            telfBox2.Mask = "(00) 0000-0000";
            telfBox2.Name = "telfBox2";
            telfBox2.Size = new Size(148, 23);
            telfBox2.SkipLiterals = false;
            telfBox2.TabIndex = 9;
            telfBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // telfBox
            // 
            telfBox.Location = new Point(488, 170);
            telfBox.Mask = "(00) 00000-0000";
            telfBox.Name = "telfBox";
            telfBox.Size = new Size(148, 23);
            telfBox.TabIndex = 8;
            telfBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(488, 203);
            label13.Name = "label13";
            label13.Size = new Size(146, 15);
            label13.TabIndex = 58;
            label13.Text = "Telefone (Não obrigatório)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(488, 152);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 57;
            label14.Text = "Celular ";
            // 
            // mySqlDataAdapter1
            // 
            // 
            // encaminhar
            // 
            encaminhar.AutoSize = true;
            encaminhar.Checked = true;
            encaminhar.CheckState = CheckState.Checked;
            encaminhar.Location = new Point(488, 130);
            encaminhar.Name = "encaminhar";
            encaminhar.Size = new Size(174, 19);
            encaminhar.TabIndex = 7;
            encaminhar.Text = "Encaminhar dados via email";
            encaminhar.UseVisualStyleBackColor = true;
            // 
            // AlterarUsersGeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(978, 336);
            Controls.Add(encaminhar);
            Controls.Add(telfBox2);
            Controls.Add(telfBox);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(button2);
            Controls.Add(camppesq);
            Controls.Add(search);
            Controls.Add(label12);
            Controls.Add(emailBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(gravarBox);
            Controls.Add(comboPerm);
            Controls.Add(comboStatus);
            Controls.Add(confPassBox);
            Controls.Add(passBox);
            Controls.Add(userBox);
            Controls.Add(nomeCompleto);
            Controls.Add(dataGridUser);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AlterarUsersGeral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor Geral de Usuários";
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridUser;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnUser;
        private DataGridViewTextBoxColumn ColumnCPF;
        private Label label12;
        private TextBox emailBox;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label1;
        private Button gravarBox;
        private ComboBox comboPerm;
        private ComboBox comboStatus;
        private TextBox confPassBox;
        private TextBox passBox;
        private TextBox userBox;
        private TextBox nomeCompleto;
        private TextBox camppesq;
        private Button search;
        private Button button2;
        private MaskedTextBox telfBox2;
        private MaskedTextBox telfBox;
        private Label label13;
        private Label label14;
        private CheckBox encaminhar;
    }
}