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
            Tuser = new TextBox();
            Tpass = new TextBox();
            Blogin = new Button();
            Csenha = new CheckBox();
            menuStrip = new MenuStrip();
            Bconfigbank = new Button();
            SuspendLayout();
            // 
            // Tuser
            // 
            Tuser.Location = new Point(441, 152);
            Tuser.MaxLength = 15;
            Tuser.Name = "Tuser";
            Tuser.PlaceholderText = "Usuário";
            Tuser.Size = new Size(236, 23);
            Tuser.TabIndex = 2;
            Tuser.Text = "erickp";
            // 
            // Tpass
            // 
            Tpass.Location = new Point(441, 213);
            Tpass.MaxLength = 15;
            Tpass.Name = "Tpass";
            Tpass.PlaceholderText = "Senha";
            Tpass.Size = new Size(236, 23);
            Tpass.TabIndex = 3;
            Tpass.Text = "senha1";
            Tpass.UseSystemPasswordChar = true;
            // 
            // Blogin
            // 
            Blogin.BackColor = SystemColors.HighlightText;
            Blogin.BackgroundImageLayout = ImageLayout.Center;
            Blogin.Cursor = Cursors.Hand;
            Blogin.FlatStyle = FlatStyle.Flat;
            Blogin.Location = new Point(484, 267);
            Blogin.Name = "Blogin";
            Blogin.Size = new Size(142, 32);
            Blogin.TabIndex = 4;
            Blogin.Text = "Entrar";
            Blogin.UseVisualStyleBackColor = false;
            Blogin.Click += LogarSystem;
            Blogin.Enter += LogarSystem;
            // 
            // Csenha
            // 
            Csenha.AutoSize = true;
            Csenha.BackColor = Color.Transparent;
            Csenha.Location = new Point(441, 242);
            Csenha.Name = "Csenha";
            Csenha.Size = new Size(89, 19);
            Csenha.TabIndex = 5;
            Csenha.Text = "Exibir senha";
            Csenha.UseVisualStyleBackColor = false;
            Csenha.Click += VerificarVisibilidadeSenha;
            // 
            // menuStrip
            // 
            menuStrip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip.BackColor = SystemColors.ButtonHighlight;
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Location = new Point(537, 9);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(202, 24);
            menuStrip.TabIndex = 7;
            menuStrip.Text = "menuStrip";
            // 
            // Bconfigbank
            // 
            Bconfigbank.BackColor = SystemColors.HighlightText;
            Bconfigbank.BackgroundImageLayout = ImageLayout.Center;
            Bconfigbank.Cursor = Cursors.Hand;
            Bconfigbank.FlatStyle = FlatStyle.Flat;
            Bconfigbank.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            Bconfigbank.Location = new Point(631, 447);
            Bconfigbank.Name = "Bconfigbank";
            Bconfigbank.Size = new Size(107, 23);
            Bconfigbank.TabIndex = 8;
            Bconfigbank.Text = "Configurar banco";
            Bconfigbank.UseVisualStyleBackColor = false;
            Bconfigbank.Click += ConfigBanco;
            // 
            // LoginFront
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(747, 482);
            Controls.Add(Bconfigbank);
            Controls.Add(Csenha);
            Controls.Add(Blogin);
            Controls.Add(Tpass);
            Controls.Add(Tuser);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginFront";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Vanilla";
            FormClosed += LoginFront_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Tuser;
        private TextBox Tpass;
        private Button Blogin;
        private CheckBox Csenha;
        private MenuStrip menuStrip;
        private Button Bconfigbank;
    }
}