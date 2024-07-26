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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VanillaMDI));
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
            cPanel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            Badduser = new CustomBtnScreen();
            Ccademp = new CustomBtnScreen();
            Baddcd = new CustomBtnScreen();
            Bcaditem = new CustomBtnScreen();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            customBtnScreen2 = new CustomBtnScreen();
            Bstatuscd = new CustomBtnScreen();
            Blogs = new CustomBtnScreen();
            Bvisualizaemp = new CustomBtnScreen();
            Bvisualizaitens = new CustomBtnScreen();
            Bvisualizacd = new CustomBtnScreen();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            BInsereItem = new CustomBtnScreen();
            customBtnScreen1 = new CustomBtnScreen();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label4 = new Label();
            customBtnScreen3 = new CustomBtnScreen();
            vScrollBar1 = new VScrollBar();
            menuStrip1.SuspendLayout();
            cPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Snameuser, Sconfig });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1350, 24);
            menuStrip1.TabIndex = 17;
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
            Sconfigbanco.Click += EnderecoBanco;
            // 
            // Ssobresistema
            // 
            Ssobresistema.BackColor = Color.DarkSlateBlue;
            Ssobresistema.ForeColor = SystemColors.ButtonHighlight;
            Ssobresistema.Name = "Ssobresistema";
            Ssobresistema.Size = new Size(159, 22);
            Ssobresistema.Text = "Sobre";
            Ssobresistema.Click += ChamaSobre;
            // 
            // cPanel
            // 
            cPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cPanel.BackColor = SystemColors.ButtonHighlight;
            cPanel.Controls.Add(flowLayoutPanel1);
            cPanel.Controls.Add(flowLayoutPanel2);
            cPanel.Controls.Add(flowLayoutPanel3);
            cPanel.Controls.Add(flowLayoutPanel4);
            cPanel.Location = new Point(0, 25);
            cPanel.Name = "cPanel";
            cPanel.Size = new Size(214, 1177);
            cPanel.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(Badduser);
            flowLayoutPanel1.Controls.Add(Ccademp);
            flowLayoutPanel1.Controls.Add(Baddcd);
            flowLayoutPanel1.Controls.Add(Bcaditem);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(212, 156);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 4;
            label1.Text = "Cadastros";
            // 
            // Badduser
            // 
            Badduser.CorBtn = Color.SteelBlue;
            Badduser.ImageBtn = null;
            Badduser.Location = new Point(3, 33);
            Badduser.Name = "Badduser";
            Badduser.Size = new Size(221, 24);
            Badduser.TabIndex = 10;
            Badduser.Tela = "Usuarios";
            Badduser.MyControlClick += StrCadUs;
            // 
            // Ccademp
            // 
            Ccademp.CorBtn = Color.SteelBlue;
            Ccademp.ImageBtn = null;
            Ccademp.Location = new Point(3, 63);
            Ccademp.Name = "Ccademp";
            Ccademp.Size = new Size(221, 25);
            Ccademp.TabIndex = 9;
            Ccademp.Tela = "Empresas";
            Ccademp.MyControlClick += StrEmp;
            // 
            // Baddcd
            // 
            Baddcd.CorBtn = Color.SteelBlue;
            Baddcd.ImageBtn = null;
            Baddcd.Location = new Point(3, 94);
            Baddcd.Name = "Baddcd";
            Baddcd.Size = new Size(221, 27);
            Baddcd.TabIndex = 3;
            Baddcd.Tela = "Endereços";
            Baddcd.MyControlClick += AddCd;
            // 
            // Bcaditem
            // 
            Bcaditem.CorBtn = Color.SteelBlue;
            Bcaditem.ImageBtn = null;
            Bcaditem.Location = new Point(3, 127);
            Bcaditem.Name = "Bcaditem";
            Bcaditem.Size = new Size(221, 24);
            Bcaditem.TabIndex = 11;
            Bcaditem.Tela = "Itens";
            Bcaditem.MyControlClick += AbrirItem;
            Bcaditem.Click += AbrirItem;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(customBtnScreen2);
            flowLayoutPanel2.Controls.Add(Bstatuscd);
            flowLayoutPanel2.Controls.Add(Blogs);
            flowLayoutPanel2.Controls.Add(Bvisualizaemp);
            flowLayoutPanel2.Controls.Add(Bvisualizaitens);
            flowLayoutPanel2.Controls.Add(Bvisualizacd);
            flowLayoutPanel2.Location = new Point(3, 165);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(212, 220);
            flowLayoutPanel2.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 30);
            label2.TabIndex = 5;
            label2.Text = "Visualizadores";
            // 
            // customBtnScreen2
            // 
            customBtnScreen2.CorBtn = Color.LimeGreen;
            customBtnScreen2.ImageBtn = null;
            customBtnScreen2.Location = new Point(3, 33);
            customBtnScreen2.Name = "customBtnScreen2";
            customBtnScreen2.Size = new Size(209, 24);
            customBtnScreen2.TabIndex = 16;
            customBtnScreen2.Tela = "Consultar Pedidos";
            customBtnScreen2.MyControlClick += ConsultarPedidos;
            // 
            // Bstatuscd
            // 
            Bstatuscd.CorBtn = Color.LimeGreen;
            Bstatuscd.ImageBtn = null;
            Bstatuscd.Location = new Point(3, 63);
            Bstatuscd.Name = "Bstatuscd";
            Bstatuscd.Size = new Size(209, 25);
            Bstatuscd.TabIndex = 15;
            Bstatuscd.Tela = "Status do Cd";
            Bstatuscd.MyControlClick += StatusCd;
            // 
            // Blogs
            // 
            Blogs.CorBtn = Color.LimeGreen;
            Blogs.ImageBtn = null;
            Blogs.Location = new Point(3, 94);
            Blogs.Name = "Blogs";
            Blogs.Size = new Size(209, 26);
            Blogs.TabIndex = 6;
            Blogs.Tela = "Consultar Logs";
            Blogs.MyControlClick += VerLog;
            Blogs.Click += VerLog;
            // 
            // Bvisualizaemp
            // 
            Bvisualizaemp.CorBtn = Color.LimeGreen;
            Bvisualizaemp.ImageBtn = null;
            Bvisualizaemp.Location = new Point(3, 126);
            Bvisualizaemp.Name = "Bvisualizaemp";
            Bvisualizaemp.Size = new Size(209, 26);
            Bvisualizaemp.TabIndex = 12;
            Bvisualizaemp.Tela = "Consultar Empresas";
            Bvisualizaemp.MyControlClick += VerEmpresas;
            // 
            // Bvisualizaitens
            // 
            Bvisualizaitens.CorBtn = Color.LimeGreen;
            Bvisualizaitens.ImageBtn = null;
            Bvisualizaitens.Location = new Point(3, 158);
            Bvisualizaitens.Name = "Bvisualizaitens";
            Bvisualizaitens.Size = new Size(209, 26);
            Bvisualizaitens.TabIndex = 13;
            Bvisualizaitens.Tela = "Consultar Itens";
            Bvisualizaitens.MyControlClick += ConsultarItens;
            Bvisualizaitens.Click += ConsultarItens;
            // 
            // Bvisualizacd
            // 
            Bvisualizacd.CorBtn = Color.LimeGreen;
            Bvisualizacd.ImageBtn = null;
            Bvisualizacd.Location = new Point(3, 190);
            Bvisualizacd.Name = "Bvisualizacd";
            Bvisualizacd.Size = new Size(209, 26);
            Bvisualizacd.TabIndex = 14;
            Bvisualizacd.Tela = "Consultar Estoque";
            Bvisualizacd.MyControlClick += AcessaTableCd;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(BInsereItem);
            flowLayoutPanel3.Controls.Add(customBtnScreen1);
            flowLayoutPanel3.Location = new Point(3, 391);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(212, 96);
            flowLayoutPanel3.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 5;
            label3.Text = "Processos Logísticos";
            // 
            // BInsereItem
            // 
            BInsereItem.CorBtn = Color.Orange;
            BInsereItem.ImageBtn = null;
            BInsereItem.Location = new Point(3, 33);
            BInsereItem.Name = "BInsereItem";
            BInsereItem.Size = new Size(221, 26);
            BInsereItem.TabIndex = 6;
            BInsereItem.Tela = "Inserir Itens";
            BInsereItem.MyControlClick += InserirItens;
            // 
            // customBtnScreen1
            // 
            customBtnScreen1.CorBtn = Color.Orange;
            customBtnScreen1.ImageBtn = null;
            customBtnScreen1.Location = new Point(3, 65);
            customBtnScreen1.Name = "customBtnScreen1";
            customBtnScreen1.Size = new Size(221, 28);
            customBtnScreen1.TabIndex = 7;
            customBtnScreen1.Tela = "Criar Pedido";
            customBtnScreen1.MyControlClick += CriarPedido;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Controls.Add(customBtnScreen3);
            flowLayoutPanel4.Location = new Point(3, 493);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(212, 73);
            flowLayoutPanel4.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 30);
            label4.TabIndex = 5;
            label4.Text = "Chat Interno";
            // 
            // customBtnScreen3
            // 
            customBtnScreen3.CorBtn = Color.DarkViolet;
            customBtnScreen3.ImageBtn = null;
            customBtnScreen3.Location = new Point(3, 33);
            customBtnScreen3.Name = "customBtnScreen3";
            customBtnScreen3.Size = new Size(221, 37);
            customBtnScreen3.TabIndex = 6;
            customBtnScreen3.Tela = "WalkTalk Meneger";
            customBtnScreen3.MyControlClick += ChamaWalkTalk;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            vScrollBar1.LargeChange = 80;
            vScrollBar1.Location = new Point(210, 22);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(19, 764);
            vScrollBar1.TabIndex = 23;
            vScrollBar1.Scroll += ScroolBar;
            // 
            // VanillaMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(1350, 729);
            Controls.Add(menuStrip1);
            Controls.Add(cPanel);
            Controls.Add(vScrollBar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(1366, 768);
            Name = "VanillaMDI";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vanilla";
            WindowState = FormWindowState.Maximized;
            FormClosed += Fechar;
            Load += VanillaMDI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            cPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private FlowLayoutPanel cPanel;
        private VScrollBar vScrollBar1;
        private CustomBtnScreen Baddcd;
        private Label label1;
        private Label label2;
        private CustomBtnScreen Blogs;
        private CustomBtnScreen Badduser;
        private CustomBtnScreen Ccademp;
        private CustomBtnScreen Bcaditem;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomBtnScreen Bvisualizaemp;
        private FlowLayoutPanel flowLayoutPanel2;
        private CustomBtnScreen Bvisualizaitens;
        private CustomBtnScreen Bvisualizacd;
        private CustomBtnScreen Bstatuscd;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private CustomBtnScreen BInsereItem;
        private CustomBtnScreen customBtnScreen1;
        private CustomBtnScreen customBtnScreen2;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label4;
        private CustomBtnScreen customBtnScreen3;
    }
}



