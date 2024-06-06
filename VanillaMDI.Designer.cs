namespace Vanilla
{
    partial class VanillaMDI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            Snameuser = new ToolStripMenuItem();
            Suseron = new ToolStripMenuItem();
            Salterauseradm = new ToolStripMenuItem();
            Salteraruser = new ToolStripMenuItem();
            Slogout = new ToolStripMenuItem();
            Sexit = new ToolStripMenuItem();
            Sconfig = new ToolStripMenuItem();
            Sconfigbanco = new ToolStripMenuItem();
            Ssobresistema = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.DarkSlateBlue;
            pictureBox1.Location = new Point(144, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(592, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Snameuser, Sconfig });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(737, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // Snameuser
            // 
            Snameuser.DropDownItems.AddRange(new ToolStripItem[] { Suseron, Salterauseradm, Salteraruser, Slogout, Sexit });
            Snameuser.ForeColor = SystemColors.ButtonHighlight;
            Snameuser.Name = "Snameuser";
            Snameuser.Size = new Size(59, 20);
            Snameuser.Text = "Usuário";
            // 
            // Suseron
            // 
            Suseron.BackColor = Color.DarkSlateBlue;
            Suseron.ForeColor = SystemColors.ButtonHighlight;
            Suseron.Name = "Suseron";
            Suseron.Size = new Size(193, 22);
            Suseron.Text = "Usuários Online";
            // 
            // Salterauseradm
            // 
            Salterauseradm.BackColor = Color.DarkSlateBlue;
            Salterauseradm.ForeColor = SystemColors.ButtonHighlight;
            Salterauseradm.Name = "Salterauseradm";
            Salterauseradm.Size = new Size(193, 22);
            Salterauseradm.Text = "Alterar outros usuários";
            // 
            // Salteraruser
            // 
            Salteraruser.BackColor = Color.DarkSlateBlue;
            Salteraruser.ForeColor = SystemColors.ButtonHighlight;
            Salteraruser.Name = "Salteraruser";
            Salteraruser.Size = new Size(193, 22);
            Salteraruser.Text = "Alterar Conta";
            // 
            // Slogout
            // 
            Slogout.BackColor = Color.DarkSlateBlue;
            Slogout.ForeColor = SystemColors.ButtonHighlight;
            Slogout.Name = "Slogout";
            Slogout.Size = new Size(193, 22);
            Slogout.Text = "Trocar de Conta";
            // 
            // Sexit
            // 
            Sexit.BackColor = Color.DarkSlateBlue;
            Sexit.ForeColor = SystemColors.Control;
            Sexit.Name = "Sexit";
            Sexit.Size = new Size(193, 22);
            Sexit.Text = "Sair";
            // 
            // Sconfig
            // 
            Sconfig.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Sconfig.DropDownItems.AddRange(new ToolStripItem[] { Sconfigbanco, Ssobresistema });
            Sconfig.ForeColor = SystemColors.ButtonHighlight;
            Sconfig.Name = "Sconfig";
            Sconfig.Size = new Size(96, 20);
            Sconfig.Text = "Configurações";
            // 
            // Sconfigbanco
            // 
            Sconfigbanco.BackColor = Color.DarkSlateBlue;
            Sconfigbanco.ForeColor = SystemColors.ButtonHighlight;
            Sconfigbanco.Name = "Sconfigbanco";
            Sconfigbanco.Size = new Size(159, 22);
            Sconfigbanco.Text = "Endereço Banco";
            // 
            // Ssobresistema
            // 
            Ssobresistema.BackColor = Color.DarkSlateBlue;
            Ssobresistema.ForeColor = SystemColors.ButtonHighlight;
            Ssobresistema.Name = "Ssobresistema";
            Ssobresistema.Size = new Size(159, 22);
            Ssobresistema.Text = "Sobre";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.Location = new Point(0, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(224, 507);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // VanillaMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(737, 529);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "VanillaMDI";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VanillaMDI";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Snameuser;
        private ToolStripMenuItem Suseron;
        private ToolStripMenuItem Salterauseradm;
        private ToolStripMenuItem Salteraruser;
        private ToolStripMenuItem Slogout;
        private ToolStripMenuItem Sexit;
        private ToolStripMenuItem Sconfig;
        private ToolStripMenuItem Sconfigbanco;
        private ToolStripMenuItem Ssobresistema;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}



