namespace Vanilla
{
    partial class AlterarUserCFront
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
            buttonCancelar = new Button();
            label12 = new Label();
            emailBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label1 = new Label();
            gravarBox = new Button();
            confPassBox = new TextBox();
            passBox = new TextBox();
            nomeCompleto = new TextBox();
            telfBox2 = new MaskedTextBox();
            telfBox = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            encaminhar = new CheckBox();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Location = new Point(134, 326);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += Cancelar;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 76);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 52;
            label12.Text = "Email:";
            // 
            // emailBox
            // 
            emailBox.Cursor = Cursors.Hand;
            emailBox.Location = new Point(12, 94);
            emailBox.MaxLength = 50;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(316, 23);
            emailBox.TabIndex = 1;
            emailBox.Leave += ValidaEmail;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(81, 251);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 51;
            label11.Text = "Confirmar senha:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(81, 198);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 50;
            label10.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 39;
            label1.Text = "Nome Completo:";
            // 
            // gravarBox
            // 
            gravarBox.Cursor = Cursors.Hand;
            gravarBox.Location = new Point(134, 298);
            gravarBox.Name = "gravarBox";
            gravarBox.Size = new Size(75, 23);
            gravarBox.TabIndex = 7;
            gravarBox.Text = "Gravar";
            gravarBox.UseVisualStyleBackColor = true;
            gravarBox.Click += Gravar;
            // 
            // confPassBox
            // 
            confPassBox.Cursor = Cursors.Hand;
            confPassBox.Location = new Point(81, 269);
            confPassBox.MaxLength = 15;
            confPassBox.Name = "confPassBox";
            confPassBox.Size = new Size(176, 23);
            confPassBox.TabIndex = 6;
            // 
            // passBox
            // 
            passBox.Cursor = Cursors.Hand;
            passBox.Location = new Point(81, 216);
            passBox.MaxLength = 15;
            passBox.Name = "passBox";
            passBox.Size = new Size(176, 23);
            passBox.TabIndex = 5;
            // 
            // nomeCompleto
            // 
            nomeCompleto.Cursor = Cursors.Hand;
            nomeCompleto.Location = new Point(12, 44);
            nomeCompleto.MaxLength = 50;
            nomeCompleto.Name = "nomeCompleto";
            nomeCompleto.Size = new Size(316, 23);
            nomeCompleto.TabIndex = 0;
            // 
            // telfBox2
            // 
            telfBox2.Location = new Point(180, 160);
            telfBox2.Mask = "(00) 0000-0000";
            telfBox2.Name = "telfBox2";
            telfBox2.Size = new Size(148, 23);
            telfBox2.TabIndex = 56;
            telfBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // telfBox
            // 
            telfBox.Location = new Point(12, 160);
            telfBox.Mask = "(00) 00000-0000";
            telfBox.Name = "telfBox";
            telfBox.Size = new Size(148, 23);
            telfBox.TabIndex = 55;
            telfBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 142);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 54;
            label2.Text = "Telefone (Não obrigatório)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 53;
            label3.Text = "Celular ";
            // 
            // encaminhar
            // 
            encaminhar.AutoSize = true;
            encaminhar.Checked = true;
            encaminhar.CheckState = CheckState.Checked;
            encaminhar.Location = new Point(12, 120);
            encaminhar.Name = "encaminhar";
            encaminhar.Size = new Size(174, 19);
            encaminhar.TabIndex = 62;
            encaminhar.Text = "Encaminhar dados via email";
            encaminhar.UseVisualStyleBackColor = true;
            // 
            // AlterarUserCFront
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(344, 366);
            ControlBox = false;
            Controls.Add(encaminhar);
            Controls.Add(telfBox2);
            Controls.Add(telfBox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(buttonCancelar);
            Controls.Add(label12);
            Controls.Add(emailBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(gravarBox);
            Controls.Add(confPassBox);
            Controls.Add(passBox);
            Controls.Add(nomeCompleto);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AlterarUserCFront";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Perfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Label label12;
        private TextBox emailBox;
        private Label label11;
        private Label label10;
        private Label label1;
        private Button gravarBox;
        private TextBox confPassBox;
        private TextBox passBox;
        private TextBox nomeCompleto;
        private MaskedTextBox telfBox2;
        private MaskedTextBox telfBox;
        private Label label2;
        private Label label3;
        private CheckBox encaminhar;
    }
}