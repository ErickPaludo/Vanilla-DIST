namespace Vanilla
{
    partial class LoginFront
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFront));
            userLogin = new TextBox();
            passLogin = new TextBox();
            button1 = new Button();
            checkPass = new CheckBox();
            menuStrip1 = new MenuStrip();
            button2 = new Button();
            SuspendLayout();
            // 
            // userLogin
            // 
            userLogin.Location = new Point(504, 203);
            userLogin.Margin = new Padding(3, 4, 3, 4);
            userLogin.MaxLength = 15;
            userLogin.Name = "userLogin";
            userLogin.PlaceholderText = "Usuário";
            userLogin.Size = new Size(269, 27);
            userLogin.TabIndex = 2;
            // 
            // passLogin
            // 
            passLogin.Location = new Point(504, 284);
            passLogin.Margin = new Padding(3, 4, 3, 4);
            passLogin.MaxLength = 15;
            passLogin.Name = "passLogin";
            passLogin.PlaceholderText = "Senha";
            passLogin.Size = new Size(269, 27);
            passLogin.TabIndex = 3;
            passLogin.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(553, 356);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 43);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += LogarSystem;
            button1.Enter += LogarSystem;
            // 
            // checkPass
            // 
            checkPass.AutoSize = true;
            checkPass.BackColor = Color.Transparent;
            checkPass.Location = new Point(504, 323);
            checkPass.Margin = new Padding(3, 4, 3, 4);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(110, 24);
            checkPass.TabIndex = 5;
            checkPass.Text = "Exibir senha";
            checkPass.UseVisualStyleBackColor = false;
            checkPass.Click += VerificarVisibilidadeSenha;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(642, 12);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(202, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(721, 596);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(122, 31);
            button2.TabIndex = 8;
            button2.Text = "Configurar banco";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ConfigBanco;
            // 
            // LoginFront
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(854, 643);
            Controls.Add(button2);
            Controls.Add(checkPass);
            Controls.Add(button1);
            Controls.Add(passLogin);
            Controls.Add(userLogin);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginFront";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Vanilla";
            FormClosing += LoginFront_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userLogin;
        private TextBox passLogin;
        private Button button1;
        private CheckBox checkPass;
        private MenuStrip menuStrip1;
        private Button button2;
    }
}