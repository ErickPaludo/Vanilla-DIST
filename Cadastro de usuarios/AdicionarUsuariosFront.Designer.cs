namespace Vanilla
{
    partial class AdicionarUsuariosFront
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
            nomeCompleto = new TextBox();
            userBox = new TextBox();
            passBox = new TextBox();
            confPassBox = new TextBox();
            comboStatus = new ComboBox();
            comboPerm = new ComboBox();
            gravarBox = new Button();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            emailBox = new TextBox();
            label12 = new Label();
            buttonCancelar = new Button();
            cpfText = new MaskedTextBox();
            telfBox = new MaskedTextBox();
            telfBox2 = new MaskedTextBox();
            encaminhar = new CheckBox();
            SuspendLayout();
            // 
            // nomeCompleto
            // 
            nomeCompleto.Cursor = Cursors.Hand;
            nomeCompleto.Location = new Point(27, 32);
            nomeCompleto.MaxLength = 50;
            nomeCompleto.Name = "nomeCompleto";
            nomeCompleto.Size = new Size(415, 23);
            nomeCompleto.TabIndex = 0;
            // 
            // userBox
            // 
            userBox.Cursor = Cursors.Hand;
            userBox.Location = new Point(247, 204);
            userBox.MaxLength = 15;
            userBox.Name = "userBox";
            userBox.Size = new Size(176, 23);
            userBox.TabIndex = 8;
            // 
            // passBox
            // 
            passBox.Cursor = Cursors.Hand;
            passBox.Location = new Point(247, 250);
            passBox.MaxLength = 15;
            passBox.Name = "passBox";
            passBox.Size = new Size(176, 23);
            passBox.TabIndex = 9;
            // 
            // confPassBox
            // 
            confPassBox.Cursor = Cursors.Hand;
            confPassBox.Location = new Point(247, 294);
            confPassBox.MaxLength = 15;
            confPassBox.Name = "confPassBox";
            confPassBox.Size = new Size(176, 23);
            confPassBox.TabIndex = 10;
            // 
            // comboStatus
            // 
            comboStatus.Cursor = Cursors.Hand;
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Ativo", "Inativo", "Bloqueado" });
            comboStatus.Location = new Point(202, 83);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(89, 23);
            comboStatus.TabIndex = 2;
            // 
            // comboPerm
            // 
            comboPerm.Cursor = Cursors.Hand;
            comboPerm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPerm.FormattingEnabled = true;
            comboPerm.Items.AddRange(new object[] { "Administrador", "Padrão" });
            comboPerm.Location = new Point(331, 83);
            comboPerm.Name = "comboPerm";
            comboPerm.Size = new Size(111, 23);
            comboPerm.TabIndex = 3;
            // 
            // gravarBox
            // 
            gravarBox.Cursor = Cursors.Hand;
            gravarBox.Location = new Point(27, 293);
            gravarBox.Name = "gravarBox";
            gravarBox.Size = new Size(159, 23);
            gravarBox.TabIndex = 11;
            gravarBox.Text = "Gravar";
            gravarBox.UseVisualStyleBackColor = true;
            gravarBox.Click += GravarUser;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 13;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 65);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 14;
            label2.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 186);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 17;
            label5.Text = "Celular ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 232);
            label6.Name = "label6";
            label6.Size = new Size(146, 15);
            label6.TabIndex = 18;
            label6.Text = "Telefone (Não obrigatório)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 65);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 19;
            label7.Text = "Permissão:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 65);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 20;
            label8.Text = "Status:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(247, 186);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 21;
            label9.Text = "Nome de usuário:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(249, 232);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 22;
            label10.Text = "Senha:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(247, 276);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 23;
            label11.Text = "Confirmar senha:";
            // 
            // emailBox
            // 
            emailBox.Cursor = Cursors.Hand;
            emailBox.Location = new Point(27, 127);
            emailBox.MaxLength = 50;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(415, 23);
            emailBox.TabIndex = 4;
            emailBox.Leave += ValidaEmail;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 109);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 25;
            label12.Text = "Email:";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Location = new Point(56, 322);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(103, 23);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // cpfText
            // 
            cpfText.Location = new Point(27, 83);
            cpfText.Mask = "###,###,###-##";
            cpfText.Name = "cpfText";
            cpfText.Size = new Size(148, 23);
            cpfText.TabIndex = 1;
            cpfText.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cpfText.Leave += ValidarCPF;
            // 
            // telfBox
            // 
            telfBox.Location = new Point(27, 204);
            telfBox.Mask = "(00) 00000-0000";
            telfBox.Name = "telfBox";
            telfBox.Size = new Size(159, 23);
            telfBox.TabIndex = 6;
            telfBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // telfBox2
            // 
            telfBox2.Location = new Point(27, 250);
            telfBox2.Mask = "(00) 0000-0000";
            telfBox2.Name = "telfBox2";
            telfBox2.Size = new Size(159, 23);
            telfBox2.TabIndex = 7;
            telfBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // encaminhar
            // 
            encaminhar.AutoSize = true;
            encaminhar.Checked = true;
            encaminhar.CheckState = CheckState.Checked;
            encaminhar.Location = new Point(27, 156);
            encaminhar.Name = "encaminhar";
            encaminhar.Size = new Size(174, 19);
            encaminhar.TabIndex = 5;
            encaminhar.Text = "Encaminhar dados via email";
            encaminhar.UseVisualStyleBackColor = true;
            // 
            // AdicionarUsuariosFront
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(457, 357);
            ControlBox = false;
            Controls.Add(encaminhar);
            Controls.Add(telfBox2);
            Controls.Add(telfBox);
            Controls.Add(cpfText);
            Controls.Add(buttonCancelar);
            Controls.Add(label12);
            Controls.Add(emailBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gravarBox);
            Controls.Add(comboPerm);
            Controls.Add(comboStatus);
            Controls.Add(confPassBox);
            Controls.Add(passBox);
            Controls.Add(userBox);
            Controls.Add(nomeCompleto);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AdicionarUsuariosFront";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nomeCompleto;
        private TextBox userBox;
        private TextBox passBox;
        private TextBox confPassBox;
        private ComboBox comboStatus;
        private ComboBox comboPerm;
        private Button gravarBox;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox emailBox;
        private Label label12;
        private Button buttonCancelar;
        private MaskedTextBox cpfText;
        private MaskedTextBox telfBox;
        private MaskedTextBox telfBox2;
        private CheckBox encaminhar;
    }
}