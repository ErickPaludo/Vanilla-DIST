namespace Vanilla
{
    partial class ConfigBank
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
            userbank = new TextBox();
            passbank = new TextBox();
            portabank = new TextBox();
            ipbank = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            sidbank = new TextBox();
            gravar = new Button();
            checkpass = new CheckBox();
            label6 = new Label();
            status = new Label();
            button1 = new Button();
            label7 = new Label();
            enderecoatual = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // userbank
            // 
            userbank.Location = new Point(81, 57);
            userbank.MaxLength = 20;
            userbank.Name = "userbank";
            userbank.Size = new Size(161, 23);
            userbank.TabIndex = 0;
            // 
            // passbank
            // 
            passbank.Location = new Point(81, 86);
            passbank.MaxLength = 20;
            passbank.Name = "passbank";
            passbank.Size = new Size(161, 23);
            passbank.TabIndex = 1;
            passbank.UseSystemPasswordChar = true;
            // 
            // portabank
            // 
            portabank.Location = new Point(450, 83);
            portabank.MaxLength = 4;
            portabank.Name = "portabank";
            portabank.Size = new Size(117, 23);
            portabank.TabIndex = 4;
            portabank.KeyPress += SoNumeros;
            // 
            // ipbank
            // 
            ipbank.Location = new Point(450, 54);
            ipbank.Name = "ipbank";
            ipbank.Size = new Size(117, 23);
            ipbank.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 60);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 90);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 57);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 7;
            label3.Text = "Endereço de IP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 86);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "Porta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(367, 115);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 10;
            label5.Text = "SID/Nome do serviço:";
            // 
            // sidbank
            // 
            sidbank.Location = new Point(492, 112);
            sidbank.MaxLength = 10;
            sidbank.Name = "sidbank";
            sidbank.Size = new Size(75, 23);
            sidbank.TabIndex = 5;
            // 
            // gravar
            // 
            gravar.Location = new Point(255, 40);
            gravar.Name = "gravar";
            gravar.Size = new Size(91, 23);
            gravar.TabIndex = 7;
            gravar.Text = "Gravar";
            gravar.UseVisualStyleBackColor = true;
            gravar.Click += GravarEndereço;
            // 
            // checkpass
            // 
            checkpass.AutoSize = true;
            checkpass.Location = new Point(81, 115);
            checkpass.Name = "checkpass";
            checkpass.Size = new Size(89, 19);
            checkpass.TabIndex = 9;
            checkpass.Text = "Exibir senha";
            checkpass.UseVisualStyleBackColor = true;
            checkpass.Click += VerSenha;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 145);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 13;
            label6.Text = "Status:";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(60, 145);
            status.Name = "status";
            status.Size = new Size(0, 15);
            status.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(255, 82);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 6;
            button1.Text = "Testar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += TestarConexao;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 9);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 16;
            label7.Text = "Endereço Atual:";
            // 
            // enderecoatual
            // 
            enderecoatual.AutoSize = true;
            enderecoatual.Location = new Point(91, 9);
            enderecoatual.Name = "enderecoatual";
            enderecoatual.Size = new Size(200, 15);
            enderecoatual.TabIndex = 17;
            enderecoatual.Text = "Data Source=:/;User Id =;Password=;";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 102);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(352, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 102);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(255, 120);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cancelar;
            // 
            // ConfigBank
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(603, 162);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(enderecoatual);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(status);
            Controls.Add(label6);
            Controls.Add(checkpass);
            Controls.Add(gravar);
            Controls.Add(label5);
            Controls.Add(sidbank);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ipbank);
            Controls.Add(portabank);
            Controls.Add(passbank);
            Controls.Add(userbank);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ConfigBank";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userbank;
        private TextBox passbank;
        private TextBox portabank;
        private MaskedTextBox ipbank;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox sidbank;
        private Button gravar;
        private CheckBox checkpass;
        private Label label6;
        private Label status;
        private Button button1;
        private Label label7;
        private Label enderecoatual;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
    }
}