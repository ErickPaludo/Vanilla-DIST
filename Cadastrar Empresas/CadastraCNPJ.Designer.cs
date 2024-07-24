namespace Vanilla
{
    partial class CadastraCNPJ
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
            button1 = new Button();
            label2 = new Label();
            textname = new TextBox();
            textlogradouro = new TextBox();
            textbairro = new TextBox();
            textmuni = new TextBox();
            textcompl = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textemail = new TextBox();
            label6 = new Label();
            label4 = new Label();
            textie = new TextBox();
            combouf = new ComboBox();
            combotypeemp = new ComboBox();
            label16 = new Label();
            buttonenv = new Button();
            textcnpj = new MaskedTextBox();
            textabertura = new MaskedTextBox();
            textdataatual = new MaskedTextBox();
            textel = new MaskedTextBox();
            label1 = new Label();
            combostatus = new ComboBox();
            textnumber = new TextBox();
            menuStrip1 = new MenuStrip();
            editarCnpjToolStripMenuItem = new ToolStripMenuItem();
            nomefantasia = new TextBox();
            label17 = new Label();
            textcep = new MaskedTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(293, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonBuscarCnpj;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 26);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "CNPJ";
            // 
            // textname
            // 
            textname.Enabled = false;
            textname.Location = new Point(68, 93);
            textname.MaxLength = 80;
            textname.Name = "textname";
            textname.Size = new Size(360, 23);
            textname.TabIndex = 3;
            // 
            // textlogradouro
            // 
            textlogradouro.Location = new Point(90, 86);
            textlogradouro.Name = "textlogradouro";
            textlogradouro.Size = new Size(182, 23);
            textlogradouro.TabIndex = 13;
            // 
            // textbairro
            // 
            textbairro.Location = new Point(56, 57);
            textbairro.Name = "textbairro";
            textbairro.Size = new Size(216, 23);
            textbairro.TabIndex = 11;
            // 
            // textmuni
            // 
            textmuni.Location = new Point(76, 25);
            textmuni.Name = "textmuni";
            textmuni.Size = new Size(196, 23);
            textmuni.TabIndex = 9;
            // 
            // textcompl
            // 
            textcompl.Location = new Point(103, 135);
            textcompl.Multiline = true;
            textcompl.Name = "textcompl";
            textcompl.Size = new Size(272, 77);
            textcompl.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 96);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 15;
            label3.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 125);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 17;
            label5.Text = "Abertura:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 90);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 19;
            label7.Text = "Logradouro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(290, 90);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 20;
            label8.Text = "Numero:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 138);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 21;
            label9.Text = "Complemento:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 60);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 22;
            label10.Text = "Bairro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 28);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 23;
            label11.Text = "Município:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(279, 28);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 24;
            label12.Text = "CEP:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(288, 60);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 25;
            label13.Text = "UF:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(128, 34);
            label14.Name = "label14";
            label14.Size = new Size(24, 15);
            label14.TabIndex = 26;
            label14.Text = "Tel:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 63);
            label15.Name = "label15";
            label15.Size = new Size(39, 15);
            label15.TabIndex = 27;
            label15.Text = "Email:";
            // 
            // textemail
            // 
            textemail.Location = new Point(47, 60);
            textemail.Name = "textemail";
            textemail.Size = new Size(357, 23);
            textemail.TabIndex = 8;
            textemail.Leave += Validaemail;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 154);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 31;
            label6.Text = "Data cad.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 125);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 33;
            label4.Text = "I.E:";
            // 
            // textie
            // 
            textie.Location = new Point(294, 122);
            textie.MaxLength = 14;
            textie.Name = "textie";
            textie.Size = new Size(134, 23);
            textie.TabIndex = 4;
            // 
            // combouf
            // 
            combouf.Cursor = Cursors.Hand;
            combouf.DropDownStyle = ComboBoxStyle.DropDownList;
            combouf.FormattingEnabled = true;
            combouf.ItemHeight = 15;
            combouf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            combouf.Location = new Point(316, 57);
            combouf.Name = "combouf";
            combouf.Size = new Size(104, 23);
            combouf.TabIndex = 12;
            // 
            // combotypeemp
            // 
            combotypeemp.Cursor = Cursors.Hand;
            combotypeemp.DropDownStyle = ComboBoxStyle.DropDownList;
            combotypeemp.FormattingEnabled = true;
            combotypeemp.Items.AddRange(new object[] { "Cliente", "Fornecedor", "Transportadora" });
            combotypeemp.Location = new Point(294, 151);
            combotypeemp.Name = "combotypeemp";
            combotypeemp.Size = new Size(134, 23);
            combotypeemp.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(232, 154);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 36;
            label16.Text = "Tipo cad.";
            // 
            // buttonenv
            // 
            buttonenv.Location = new Point(203, 585);
            buttonenv.Name = "buttonenv";
            buttonenv.Size = new Size(75, 31);
            buttonenv.TabIndex = 16;
            buttonenv.Text = "Gravar";
            buttonenv.UseVisualStyleBackColor = true;
            buttonenv.Click += CadastrarCnpj;
            // 
            // textcnpj
            // 
            textcnpj.Location = new Point(179, 22);
            textcnpj.Mask = "##,###,###/####-##";
            textcnpj.Name = "textcnpj";
            textcnpj.Size = new Size(108, 23);
            textcnpj.TabIndex = 0;
            textcnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textcnpj.Leave += Validacao;
            // 
            // textabertura
            // 
            textabertura.Enabled = false;
            textabertura.Location = new Point(81, 122);
            textabertura.Mask = "00/00/0000";
            textabertura.Name = "textabertura";
            textabertura.Size = new Size(100, 23);
            textabertura.TabIndex = 39;
            textabertura.ValidatingType = typeof(DateTime);
            // 
            // textdataatual
            // 
            textdataatual.Location = new Point(81, 146);
            textdataatual.Mask = "00/00/0000";
            textdataatual.Name = "textdataatual";
            textdataatual.Size = new Size(100, 23);
            textdataatual.TabIndex = 40;
            textdataatual.ValidatingType = typeof(DateTime);
            // 
            // textel
            // 
            textel.Location = new Point(158, 31);
            textel.Mask = "(99) 0000-0000";
            textel.Name = "textel";
            textel.Size = new Size(117, 23);
            textel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 183);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 47;
            label1.Text = "Status";
            // 
            // combostatus
            // 
            combostatus.Cursor = Cursors.Hand;
            combostatus.DropDownStyle = ComboBoxStyle.DropDownList;
            combostatus.FormattingEnabled = true;
            combostatus.Items.AddRange(new object[] { "Ativo", "Inativo", "Bloqueado" });
            combostatus.Location = new Point(294, 180);
            combostatus.Name = "combostatus";
            combostatus.Size = new Size(134, 23);
            combostatus.TabIndex = 6;
            combostatus.SelectedIndexChanged += combostatus_SelectedIndexChanged;
            // 
            // textnumber
            // 
            textnumber.Location = new Point(350, 87);
            textnumber.Name = "textnumber";
            textnumber.Size = new Size(70, 23);
            textnumber.TabIndex = 14;
            textnumber.KeyPress += SomenteNumeros;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { editarCnpjToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(486, 24);
            menuStrip1.TabIndex = 50;
            menuStrip1.Text = "menuStrip1";
            // 
            // editarCnpjToolStripMenuItem
            // 
            editarCnpjToolStripMenuItem.Name = "editarCnpjToolStripMenuItem";
            editarCnpjToolStripMenuItem.Size = new Size(77, 20);
            editarCnpjToolStripMenuItem.Text = "Editar Cnpj";
            editarCnpjToolStripMenuItem.Click += Editar;
            // 
            // nomefantasia
            // 
            nomefantasia.Location = new Point(68, 64);
            nomefantasia.MaxLength = 80;
            nomefantasia.Name = "nomefantasia";
            nomefantasia.Size = new Size(360, 23);
            nomefantasia.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 57);
            label17.Name = "label17";
            label17.Size = new Size(53, 30);
            label17.TabIndex = 52;
            label17.Text = "Nome \r\nFantasia:";
            // 
            // textcep
            // 
            textcep.Location = new Point(316, 25);
            textcep.Mask = "00,000-000";
            textcep.Name = "textcep";
            textcep.Size = new Size(104, 23);
            textcep.TabIndex = 53;
            textcep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            textcep.Leave += RetornaCep;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nomefantasia);
            groupBox1.Controls.Add(textname);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(combostatus);
            groupBox1.Controls.Add(textie);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textdataatual);
            groupBox1.Controls.Add(combotypeemp);
            groupBox1.Controls.Add(textabertura);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(textcnpj);
            groupBox1.Location = new Point(9, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 213);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textbairro);
            groupBox2.Controls.Add(textlogradouro);
            groupBox2.Controls.Add(textcep);
            groupBox2.Controls.Add(textmuni);
            groupBox2.Controls.Add(textnumber);
            groupBox2.Controls.Add(textcompl);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(combouf);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(9, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(463, 227);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textemail);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textel);
            groupBox3.Location = new Point(9, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(463, 100);
            groupBox3.TabIndex = 56;
            groupBox3.TabStop = false;
            // 
            // CadastraCNPJ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(486, 630);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonenv);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "CadastraCNPJ";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private TextBox textname;
        private TextBox textlogradouro;
        private TextBox textbairro;
        private TextBox textmuni;
        private TextBox textcompl;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textemail;
        private Label label6;
        private Label label4;
        private TextBox textie;
        private ComboBox combouf;
        private ComboBox combotypeemp;
        private Label label16;
        private Button buttonenv;
        private MaskedTextBox textcnpj;
        private MaskedTextBox textabertura;
        private MaskedTextBox textdataatual;
        private MaskedTextBox textel;
        private Label label1;
        private ComboBox combostatus;
        private TextBox textnumber;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editarCnpjToolStripMenuItem;
        private TextBox nomefantasia;
        private Label label17;
        private MaskedTextBox textcep;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
