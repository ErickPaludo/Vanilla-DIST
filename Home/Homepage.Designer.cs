namespace Vanilla
{
    partial class Homepage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            Ccademp = new Button();
            Bcaditem = new Button();
            Badduser = new Button();
            Baddcd = new Button();
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
            Bvisualizaemp = new Button();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            containercad = new FlowLayoutPanel();
            containerlabelcad = new FlowLayoutPanel();
            cadastrar = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            visualizar = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Blogs = new Button();
            Bvisualizaitens = new Button();
            Bvisualizacd = new Button();
            Bstatuscd = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            Llogistica = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            BInsereItem = new Button();
            pictureBox1 = new PictureBox();
            Bmsg = new Button();
            menuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            containercad.SuspendLayout();
            containerlabelcad.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Ccademp
            // 
            Ccademp.BackColor = Color.MidnightBlue;
            Ccademp.Cursor = Cursors.Hand;
            Ccademp.FlatAppearance.BorderColor = Color.Black;
            Ccademp.FlatAppearance.BorderSize = 0;
            Ccademp.FlatStyle = FlatStyle.Flat;
            Ccademp.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Ccademp.ForeColor = SystemColors.ButtonHighlight;
            Ccademp.Location = new Point(3, 47);
            Ccademp.Name = "Ccademp";
            Ccademp.Size = new Size(167, 114);
            Ccademp.TabIndex = 0;
            Ccademp.Text = "Empresa";
            Ccademp.TextAlign = ContentAlignment.MiddleLeft;
            Ccademp.UseVisualStyleBackColor = false;
            Ccademp.Click += StrEmp;
            // 
            // Bcaditem
            // 
            Bcaditem.BackColor = Color.MidnightBlue;
            Bcaditem.Cursor = Cursors.Hand;
            Bcaditem.FlatAppearance.BorderColor = Color.Black;
            Bcaditem.FlatAppearance.BorderSize = 0;
            Bcaditem.FlatStyle = FlatStyle.Flat;
            Bcaditem.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Bcaditem.ForeColor = SystemColors.ButtonHighlight;
            Bcaditem.Location = new Point(176, 47);
            Bcaditem.Name = "Bcaditem";
            Bcaditem.Size = new Size(167, 114);
            Bcaditem.TabIndex = 1;
            Bcaditem.Text = "Itens";
            Bcaditem.TextAlign = ContentAlignment.MiddleLeft;
            Bcaditem.UseVisualStyleBackColor = false;
            Bcaditem.Click += AbrirItem;
            // 
            // Badduser
            // 
            Badduser.BackColor = Color.MidnightBlue;
            Badduser.Cursor = Cursors.Hand;
            Badduser.FlatAppearance.BorderColor = Color.Black;
            Badduser.FlatAppearance.BorderSize = 0;
            Badduser.FlatStyle = FlatStyle.Flat;
            Badduser.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Badduser.ForeColor = SystemColors.ButtonHighlight;
            Badduser.Location = new Point(349, 47);
            Badduser.Name = "Badduser";
            Badduser.Size = new Size(167, 114);
            Badduser.TabIndex = 2;
            Badduser.Text = "Usuario";
            Badduser.TextAlign = ContentAlignment.MiddleLeft;
            Badduser.UseVisualStyleBackColor = false;
            Badduser.Click += StrCadUs;
            // 
            // Baddcd
            // 
            Baddcd.BackColor = Color.MidnightBlue;
            Baddcd.Cursor = Cursors.Hand;
            Baddcd.FlatAppearance.BorderColor = Color.Black;
            Baddcd.FlatAppearance.BorderSize = 0;
            Baddcd.FlatStyle = FlatStyle.Flat;
            Baddcd.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Baddcd.ForeColor = SystemColors.ButtonHighlight;
            Baddcd.Location = new Point(522, 47);
            Baddcd.Name = "Baddcd";
            Baddcd.Size = new Size(167, 114);
            Baddcd.TabIndex = 3;
            Baddcd.Text = "Endereços Cd";
            Baddcd.TextAlign = ContentAlignment.MiddleLeft;
            Baddcd.UseVisualStyleBackColor = false;
            Baddcd.Click += AddCd;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateBlue;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Snameuser, Sconfig });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(163, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
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
            Suseron.Click += LOgados;
            // 
            // Salterauseradm
            // 
            Salterauseradm.BackColor = Color.DarkSlateBlue;
            Salterauseradm.ForeColor = SystemColors.ButtonHighlight;
            Salterauseradm.Name = "Salterauseradm";
            Salterauseradm.Size = new Size(193, 22);
            Salterauseradm.Text = "Alterar outros usuários";
            Salterauseradm.Click += AlterarQualqueruser;
            // 
            // Salteraruser
            // 
            Salteraruser.BackColor = Color.DarkSlateBlue;
            Salteraruser.ForeColor = SystemColors.ButtonHighlight;
            Salteraruser.Name = "Salteraruser";
            Salteraruser.Size = new Size(193, 22);
            Salteraruser.Text = "Alterar Conta";
            Salteraruser.Click += AlterarUser;
            // 
            // Slogout
            // 
            Slogout.BackColor = Color.DarkSlateBlue;
            Slogout.ForeColor = SystemColors.ButtonHighlight;
            Slogout.Name = "Slogout";
            Slogout.Size = new Size(193, 22);
            Slogout.Text = "Trocar de Conta";
            Slogout.Click += TrocarConta;
            // 
            // Sexit
            // 
            Sexit.BackColor = Color.DarkSlateBlue;
            Sexit.ForeColor = SystemColors.Control;
            Sexit.Name = "Sexit";
            Sexit.Size = new Size(193, 22);
            Sexit.Text = "Sair";
            Sexit.Click += Exit;
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
            Sconfigbanco.Click += EndereçoBanco;
            // 
            // Ssobresistema
            // 
            Ssobresistema.BackColor = Color.DarkSlateBlue;
            Ssobresistema.ForeColor = SystemColors.ButtonHighlight;
            Ssobresistema.Name = "Ssobresistema";
            Ssobresistema.Size = new Size(159, 22);
            Ssobresistema.Text = "Sobre";
            Ssobresistema.Click += VerSobre;
            // 
            // Bvisualizaemp
            // 
            Bvisualizaemp.BackColor = Color.Green;
            Bvisualizaemp.Cursor = Cursors.Hand;
            Bvisualizaemp.FlatAppearance.BorderColor = Color.Black;
            Bvisualizaemp.FlatAppearance.BorderSize = 0;
            Bvisualizaemp.FlatStyle = FlatStyle.Flat;
            Bvisualizaemp.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Bvisualizaemp.ForeColor = SystemColors.ButtonHighlight;
            Bvisualizaemp.Location = new Point(176, 3);
            Bvisualizaemp.Name = "Bvisualizaemp";
            Bvisualizaemp.Size = new Size(167, 114);
            Bvisualizaemp.TabIndex = 5;
            Bvisualizaemp.Text = "Empresas";
            Bvisualizaemp.TextAlign = ContentAlignment.MiddleLeft;
            Bvisualizaemp.UseVisualStyleBackColor = false;
            Bvisualizaemp.Click += VerEmpresas;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(containercad);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Location = new Point(25, 48);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(868, 517);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // containercad
            // 
            containercad.Controls.Add(containerlabelcad);
            containercad.Controls.Add(Ccademp);
            containercad.Controls.Add(Bcaditem);
            containercad.Controls.Add(Badduser);
            containercad.Controls.Add(Baddcd);
            containercad.Location = new Point(3, 3);
            containercad.Name = "containercad";
            containercad.Size = new Size(784, 163);
            containercad.TabIndex = 16;
            // 
            // containerlabelcad
            // 
            containerlabelcad.Controls.Add(cadastrar);
            containerlabelcad.Location = new Point(3, 3);
            containerlabelcad.Name = "containerlabelcad";
            containerlabelcad.Size = new Size(784, 38);
            containerlabelcad.TabIndex = 15;
            // 
            // cadastrar
            // 
            cadastrar.AutoSize = true;
            cadastrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrar.ForeColor = SystemColors.ActiveCaptionText;
            cadastrar.Location = new Point(3, 0);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(113, 32);
            cadastrar.TabIndex = 0;
            cadastrar.Text = "Cadastrar";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(visualizar);
            flowLayoutPanel4.Location = new Point(3, 172);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(784, 33);
            flowLayoutPanel4.TabIndex = 17;
            // 
            // visualizar
            // 
            visualizar.AutoSize = true;
            visualizar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            visualizar.ForeColor = SystemColors.ActiveCaptionText;
            visualizar.Location = new Point(3, 0);
            visualizar.Name = "visualizar";
            visualizar.Size = new Size(114, 32);
            visualizar.TabIndex = 0;
            visualizar.Text = "Visualizar";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(Blogs);
            flowLayoutPanel2.Controls.Add(Bvisualizaemp);
            flowLayoutPanel2.Controls.Add(Bvisualizaitens);
            flowLayoutPanel2.Controls.Add(Bvisualizacd);
            flowLayoutPanel2.Controls.Add(Bstatuscd);
            flowLayoutPanel2.Location = new Point(3, 211);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(865, 125);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // Blogs
            // 
            Blogs.BackColor = Color.Green;
            Blogs.Cursor = Cursors.Hand;
            Blogs.FlatAppearance.BorderColor = Color.Black;
            Blogs.FlatAppearance.BorderSize = 0;
            Blogs.FlatStyle = FlatStyle.Flat;
            Blogs.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Blogs.ForeColor = SystemColors.ButtonHighlight;
            Blogs.Location = new Point(3, 3);
            Blogs.Name = "Blogs";
            Blogs.Size = new Size(167, 114);
            Blogs.TabIndex = 4;
            Blogs.Text = "Logs";
            Blogs.TextAlign = ContentAlignment.MiddleLeft;
            Blogs.UseVisualStyleBackColor = false;
            Blogs.Click += VerLog;
            // 
            // Bvisualizaitens
            // 
            Bvisualizaitens.BackColor = Color.Green;
            Bvisualizaitens.Cursor = Cursors.Hand;
            Bvisualizaitens.FlatAppearance.BorderColor = Color.Black;
            Bvisualizaitens.FlatAppearance.BorderSize = 0;
            Bvisualizaitens.FlatStyle = FlatStyle.Flat;
            Bvisualizaitens.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Bvisualizaitens.ForeColor = SystemColors.ButtonHighlight;
            Bvisualizaitens.Location = new Point(349, 3);
            Bvisualizaitens.Name = "Bvisualizaitens";
            Bvisualizaitens.Size = new Size(167, 114);
            Bvisualizaitens.TabIndex = 6;
            Bvisualizaitens.Text = "Itens";
            Bvisualizaitens.TextAlign = ContentAlignment.MiddleLeft;
            Bvisualizaitens.UseVisualStyleBackColor = false;
            Bvisualizaitens.Click += ConsultarItens;
            // 
            // Bvisualizacd
            // 
            Bvisualizacd.BackColor = Color.Green;
            Bvisualizacd.Cursor = Cursors.Hand;
            Bvisualizacd.FlatAppearance.BorderColor = Color.Black;
            Bvisualizacd.FlatAppearance.BorderSize = 0;
            Bvisualizacd.FlatStyle = FlatStyle.Flat;
            Bvisualizacd.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Bvisualizacd.ForeColor = SystemColors.ButtonHighlight;
            Bvisualizacd.Location = new Point(522, 3);
            Bvisualizacd.Name = "Bvisualizacd";
            Bvisualizacd.Size = new Size(167, 114);
            Bvisualizacd.TabIndex = 18;
            Bvisualizacd.Text = "Endereços Cd";
            Bvisualizacd.TextAlign = ContentAlignment.MiddleLeft;
            Bvisualizacd.UseVisualStyleBackColor = false;
            Bvisualizacd.Click += AcessaTableCd;
            // 
            // Bstatuscd
            // 
            Bstatuscd.BackColor = Color.Green;
            Bstatuscd.Cursor = Cursors.Hand;
            Bstatuscd.FlatAppearance.BorderColor = Color.Black;
            Bstatuscd.FlatAppearance.BorderSize = 0;
            Bstatuscd.FlatStyle = FlatStyle.Flat;
            Bstatuscd.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Bstatuscd.ForeColor = SystemColors.ButtonHighlight;
            Bstatuscd.Location = new Point(695, 3);
            Bstatuscd.Name = "Bstatuscd";
            Bstatuscd.Size = new Size(167, 114);
            Bstatuscd.TabIndex = 19;
            Bstatuscd.Text = "Status CD";
            Bstatuscd.TextAlign = ContentAlignment.MiddleLeft;
            Bstatuscd.UseVisualStyleBackColor = false;
            Bstatuscd.Click += StatusCd;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(Llogistica);
            flowLayoutPanel3.Location = new Point(3, 342);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(784, 33);
            flowLayoutPanel3.TabIndex = 18;
            // 
            // Llogistica
            // 
            Llogistica.AutoSize = true;
            Llogistica.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Llogistica.ForeColor = SystemColors.ActiveCaptionText;
            Llogistica.Location = new Point(3, 0);
            Llogistica.Name = "Llogistica";
            Llogistica.Size = new Size(228, 32);
            Llogistica.TabIndex = 0;
            Llogistica.Text = "Processos Logisticos";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(BInsereItem);
            flowLayoutPanel5.Location = new Point(3, 381);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(784, 125);
            flowLayoutPanel5.TabIndex = 19;
            // 
            // BInsereItem
            // 
            BInsereItem.BackColor = Color.Orange;
            BInsereItem.Cursor = Cursors.Hand;
            BInsereItem.FlatAppearance.BorderColor = Color.Black;
            BInsereItem.FlatAppearance.BorderSize = 0;
            BInsereItem.FlatStyle = FlatStyle.Flat;
            BInsereItem.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BInsereItem.ForeColor = SystemColors.ButtonHighlight;
            BInsereItem.Location = new Point(3, 3);
            BInsereItem.Name = "BInsereItem";
            BInsereItem.Size = new Size(167, 114);
            BInsereItem.TabIndex = 5;
            BInsereItem.Text = "Inserir item";
            BInsereItem.TextAlign = ContentAlignment.MiddleLeft;
            BInsereItem.UseVisualStyleBackColor = false;
            BInsereItem.Click += InserirItens;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.DarkSlateBlue;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(981, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Bmsg
            // 
            Bmsg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Bmsg.BackgroundImage = (Image)resources.GetObject("Bmsg.BackgroundImage");
            Bmsg.FlatStyle = FlatStyle.Popup;
            Bmsg.Location = new Point(922, 518);
            Bmsg.Name = "Bmsg";
            Bmsg.Size = new Size(50, 50);
            Bmsg.TabIndex = 16;
            Bmsg.UseVisualStyleBackColor = true;
            Bmsg.Click += ChamaChat;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(981, 577);
            Controls.Add(Bmsg);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Homepage";
            Text = "Início";
            WindowState = FormWindowState.Maximized;
            FormClosing += Homepage_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            containercad.ResumeLayout(false);
            containerlabelcad.ResumeLayout(false);
            containerlabelcad.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Ccademp;
        private Button Bcaditem;
        private Button Badduser;
        private Button Baddcd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Snameuser;
        private ToolStripMenuItem Salteraruser;
        private ToolStripMenuItem Slogout;
        private ToolStripMenuItem Sexit;
        private ToolStripMenuItem Salterauseradm;
        private ToolStripMenuItem Sconfig;
        private ToolStripMenuItem Sconfigbanco;
        private ToolStripMenuItem Ssobresistema;
        private Button Bvisualizaemp;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button Blogs;
        private Button Bvisualizaitens;
        private Label cadastrar;
        private Label visualizar;
        private FlowLayoutPanel containerlabelcad;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel containercad;
        private ToolStripMenuItem Suseron;
        private PictureBox pictureBox1;
        private Button Bvisualizacd;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label Llogistica;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button BInsereItem;
        private Button Bstatuscd;
        private Button Bmsg;
    }
}