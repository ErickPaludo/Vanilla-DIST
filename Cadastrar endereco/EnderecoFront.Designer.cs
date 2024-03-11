namespace Vanilla
{
    partial class EnderecoFront
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ruaTransp = new TextBox();
            numeroEndereco = new TextBox();
            complementoTransp = new TextBox();
            bairroTransp = new TextBox();
            cidadeTranp = new TextBox();
            ufTransp = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            cancelarBtn = new Button();
            cepTransp = new MaskedTextBox();
            SuspendLayout();
            // 
            // ruaTransp
            // 
            ruaTransp.Cursor = Cursors.Hand;
            ruaTransp.Location = new Point(17, 79);
            ruaTransp.MaxLength = 35;
            ruaTransp.Name = "ruaTransp";
            ruaTransp.PlaceholderText = "Rua";
            ruaTransp.Size = new Size(311, 23);
            ruaTransp.TabIndex = 3;
            // 
            // numeroEndereco
            // 
            numeroEndereco.Cursor = Cursors.Hand;
            numeroEndereco.Location = new Point(257, 108);
            numeroEndereco.MaxLength = 5;
            numeroEndereco.Name = "numeroEndereco";
            numeroEndereco.PlaceholderText = "N°";
            numeroEndereco.Size = new Size(71, 23);
            numeroEndereco.TabIndex = 5;
            numeroEndereco.KeyDown += numeroEndereco_KeyDown;
            numeroEndereco.KeyPress += numeroEndereco_KeyPress;
            // 
            // complementoTransp
            // 
            complementoTransp.Cursor = Cursors.Hand;
            complementoTransp.Location = new Point(17, 137);
            complementoTransp.MaxLength = 255;
            complementoTransp.Multiline = true;
            complementoTransp.Name = "complementoTransp";
            complementoTransp.PlaceholderText = "Complemento";
            complementoTransp.Size = new Size(311, 91);
            complementoTransp.TabIndex = 6;
            // 
            // bairroTransp
            // 
            bairroTransp.Cursor = Cursors.Hand;
            bairroTransp.Location = new Point(17, 108);
            bairroTransp.MaxLength = 25;
            bairroTransp.Name = "bairroTransp";
            bairroTransp.PlaceholderText = "Bairro";
            bairroTransp.Size = new Size(234, 23);
            bairroTransp.TabIndex = 4;
            // 
            // cidadeTranp
            // 
            cidadeTranp.Cursor = Cursors.Hand;
            cidadeTranp.Location = new Point(17, 50);
            cidadeTranp.MaxLength = 30;
            cidadeTranp.Name = "cidadeTranp";
            cidadeTranp.PlaceholderText = "Cidade";
            cidadeTranp.Size = new Size(311, 23);
            cidadeTranp.TabIndex = 2;
            // 
            // ufTransp
            // 
            ufTransp.Cursor = Cursors.Hand;
            ufTransp.DropDownStyle = ComboBoxStyle.DropDownList;
            ufTransp.FormattingEnabled = true;
            ufTransp.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            ufTransp.Location = new Point(207, 21);
            ufTransp.Name = "ufTransp";
            ufTransp.Size = new Size(121, 23);
            ufTransp.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(98, 249);
            button1.Name = "button1";
            button1.Size = new Size(134, 61);
            button1.TabIndex = 8;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Location = new Point(177, 24);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 10;
            label1.Text = "UF:";
            // 
            // cancelarBtn
            // 
            cancelarBtn.Location = new Point(126, 316);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(75, 23);
            cancelarBtn.TabIndex = 11;
            cancelarBtn.Text = "Cancelar";
            // 
            // cepTransp
            // 
            cepTransp.Location = new Point(17, 21);
            cepTransp.Mask = "00,000-000";
            cepTransp.Name = "cepTransp";
            cepTransp.Size = new Size(136, 23);
            cepTransp.TabIndex = 0;
            cepTransp.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            cepTransp.Leave += PuxarInfo;
            // 
            // EnderecoFront
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(336, 368);
            ControlBox = false;
            Controls.Add(cepTransp);
            Controls.Add(cancelarBtn);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ufTransp);
            Controls.Add(cidadeTranp);
            Controls.Add(bairroTransp);
            Controls.Add(complementoTransp);
            Controls.Add(numeroEndereco);
            Controls.Add(ruaTransp);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "EnderecoFront";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Endereço";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ruaTransp;
        private TextBox numeroEndereco;
        private TextBox complementoTransp;
        private TextBox bairroTransp;
        private TextBox cidadeTranp;
        private ComboBox ufTransp;
        private Button button1;
        private Label label1;
        private Button cancelarBtn;
        private MaskedTextBox cepTransp;
    }
}
