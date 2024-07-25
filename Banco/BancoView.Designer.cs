namespace Vanilla
{
    partial class BancoView
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
            button1 = new Button();
            gravar = new Button();
            label5 = new Label();
            labelsid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelport = new TextBox();
            labelsenha = new TextBox();
            labeluser = new TextBox();
            labelstatus = new Label();
            labelconnect = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 202);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 17;
            button1.Text = "Testar";
            button1.UseVisualStyleBackColor = true;
            // 
            // gravar
            // 
            gravar.Location = new Point(176, 202);
            gravar.Name = "gravar";
            gravar.Size = new Size(91, 23);
            gravar.TabIndex = 19;
            gravar.Text = "Gravar";
            gravar.UseVisualStyleBackColor = true;
            gravar.Click += Gravar;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 152);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 22;
            label5.Text = "SID/Nome do serviço:";
            // 
            // labelsid
            // 
            labelsid.Location = new Point(160, 149);
            labelsid.MaxLength = 10;
            labelsid.Name = "labelsid";
            labelsid.Size = new Size(105, 23);
            labelsid.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 123);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 21;
            label4.Text = "Porta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 94);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 20;
            label3.Text = "Endereço de IP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 55);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 18;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 16;
            label1.Text = "Usuário:";
            // 
            // labelport
            // 
            labelport.Location = new Point(118, 120);
            labelport.MaxLength = 4;
            labelport.Name = "labelport";
            labelport.Size = new Size(147, 23);
            labelport.TabIndex = 14;
            // 
            // labelsenha
            // 
            labelsenha.Location = new Point(77, 52);
            labelsenha.MaxLength = 20;
            labelsenha.Name = "labelsenha";
            labelsenha.Size = new Size(188, 23);
            labelsenha.TabIndex = 12;
            labelsenha.UseSystemPasswordChar = true;
            // 
            // labeluser
            // 
            labeluser.Location = new Point(77, 23);
            labeluser.MaxLength = 20;
            labeluser.Name = "labeluser";
            labeluser.Size = new Size(188, 23);
            labeluser.TabIndex = 11;
            // 
            // labelstatus
            // 
            labelstatus.AutoSize = true;
            labelstatus.Location = new Point(21, 184);
            labelstatus.Name = "labelstatus";
            labelstatus.Size = new Size(38, 15);
            labelstatus.TabIndex = 23;
            labelstatus.Text = "label6";
            // 
            // labelconnect
            // 
            labelconnect.Location = new Point(118, 91);
            labelconnect.MaxLength = 20;
            labelconnect.Name = "labelconnect";
            labelconnect.Size = new Size(147, 23);
            labelconnect.TabIndex = 24;
            // 
            // BancoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 244);
            Controls.Add(labelconnect);
            Controls.Add(labelstatus);
            Controls.Add(button1);
            Controls.Add(gravar);
            Controls.Add(label5);
            Controls.Add(labelsid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelport);
            Controls.Add(labelsenha);
            Controls.Add(labeluser);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BancoView";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração do Banco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button gravar;
        private Label label5;
        private TextBox labelsid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox labelport;
        private TextBox labelsenha;
        private TextBox labeluser;
        private Label labelstatus;
        private TextBox labelconnect;
    }
}