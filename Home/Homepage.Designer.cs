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
            cademp = new Button();
            caditem = new Button();
            adduser = new Button();
            addcd = new Button();
            menuStrip1 = new MenuStrip();
            nameuser = new ToolStripMenuItem();
            useron = new ToolStripMenuItem();
            alterarOutrosUsuários = new ToolStripMenuItem();
            userConfigToolStripMenuItem = new ToolStripMenuItem();
            trocarDeContaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            endereçoDoBandoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            emp = new Button();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            containercad = new FlowLayoutPanel();
            containerlabelcad = new FlowLayoutPanel();
            cadastrar = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            visualizar = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            logs = new Button();
            ConsultaItens = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            containercad.SuspendLayout();
            containerlabelcad.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cademp
            // 
            cademp.BackColor = Color.MidnightBlue;
            cademp.Cursor = Cursors.Hand;
            cademp.FlatAppearance.BorderColor = Color.Black;
            cademp.FlatAppearance.BorderSize = 0;
            cademp.FlatStyle = FlatStyle.Flat;
            cademp.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cademp.ForeColor = SystemColors.ButtonHighlight;
            cademp.Location = new Point(3, 47);
            cademp.Name = "cademp";
            cademp.Size = new Size(167, 114);
            cademp.TabIndex = 0;
            cademp.Text = "Empresa";
            cademp.TextAlign = ContentAlignment.MiddleLeft;
            cademp.UseVisualStyleBackColor = false;
            cademp.Click += button1_Click;
            // 
            // caditem
            // 
            caditem.BackColor = Color.MidnightBlue;
            caditem.Cursor = Cursors.Hand;
            caditem.FlatAppearance.BorderColor = Color.Black;
            caditem.FlatAppearance.BorderSize = 0;
            caditem.FlatStyle = FlatStyle.Flat;
            caditem.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            caditem.ForeColor = SystemColors.ButtonHighlight;
            caditem.Location = new Point(176, 47);
            caditem.Name = "caditem";
            caditem.Size = new Size(167, 114);
            caditem.TabIndex = 1;
            caditem.Text = "Itens";
            caditem.TextAlign = ContentAlignment.MiddleLeft;
            caditem.UseVisualStyleBackColor = false;
            caditem.Click += AbrirItem;
            // 
            // adduser
            // 
            adduser.BackColor = Color.MidnightBlue;
            adduser.Cursor = Cursors.Hand;
            adduser.FlatAppearance.BorderColor = Color.Black;
            adduser.FlatAppearance.BorderSize = 0;
            adduser.FlatStyle = FlatStyle.Flat;
            adduser.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            adduser.ForeColor = SystemColors.ButtonHighlight;
            adduser.Location = new Point(349, 47);
            adduser.Name = "adduser";
            adduser.Size = new Size(167, 114);
            adduser.TabIndex = 2;
            adduser.Text = "Usuario";
            adduser.TextAlign = ContentAlignment.MiddleLeft;
            adduser.UseVisualStyleBackColor = false;
            adduser.Click += button5_Click;
            // 
            // addcd
            // 
            addcd.BackColor = Color.MidnightBlue;
            addcd.Cursor = Cursors.Hand;
            addcd.FlatAppearance.BorderColor = Color.Black;
            addcd.FlatAppearance.BorderSize = 0;
            addcd.FlatStyle = FlatStyle.Flat;
            addcd.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addcd.ForeColor = SystemColors.ButtonHighlight;
            addcd.Location = new Point(522, 47);
            addcd.Name = "addcd";
            addcd.Size = new Size(167, 114);
            addcd.TabIndex = 3;
            addcd.Text = "Add Cd";
            addcd.TextAlign = ContentAlignment.MiddleLeft;
            addcd.UseVisualStyleBackColor = false;
            addcd.Click += AddCd;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkSlateBlue;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { nameuser, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(163, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // nameuser
            // 
            nameuser.DropDownItems.AddRange(new ToolStripItem[] { useron, alterarOutrosUsuários, userConfigToolStripMenuItem, trocarDeContaToolStripMenuItem, sairToolStripMenuItem });
            nameuser.ForeColor = SystemColors.ButtonHighlight;
            nameuser.Name = "nameuser";
            nameuser.Size = new Size(59, 20);
            nameuser.Text = "Usuário";
            nameuser.Click += nameuser_Click;
            // 
            // useron
            // 
            useron.BackColor = Color.DarkSlateBlue;
            useron.ForeColor = SystemColors.ButtonHighlight;
            useron.Name = "useron";
            useron.Size = new Size(193, 22);
            useron.Text = "Usuários Online";
            useron.Click += LOgados;
            // 
            // alterarOutrosUsuários
            // 
            alterarOutrosUsuários.BackColor = Color.DarkSlateBlue;
            alterarOutrosUsuários.ForeColor = SystemColors.ButtonHighlight;
            alterarOutrosUsuários.Name = "alterarOutrosUsuários";
            alterarOutrosUsuários.Size = new Size(193, 22);
            alterarOutrosUsuários.Text = "Alterar outros usuários";
            alterarOutrosUsuários.Click += AlterarQualqueruser;
            // 
            // userConfigToolStripMenuItem
            // 
            userConfigToolStripMenuItem.BackColor = Color.DarkSlateBlue;
            userConfigToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            userConfigToolStripMenuItem.Name = "userConfigToolStripMenuItem";
            userConfigToolStripMenuItem.Size = new Size(193, 22);
            userConfigToolStripMenuItem.Text = "Alterar Conta";
            userConfigToolStripMenuItem.Click += AlterarUser;
            // 
            // trocarDeContaToolStripMenuItem
            // 
            trocarDeContaToolStripMenuItem.BackColor = Color.DarkSlateBlue;
            trocarDeContaToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            trocarDeContaToolStripMenuItem.Name = "trocarDeContaToolStripMenuItem";
            trocarDeContaToolStripMenuItem.Size = new Size(193, 22);
            trocarDeContaToolStripMenuItem.Text = "Trocar de Conta";
            trocarDeContaToolStripMenuItem.Click += TrocarConta;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.BackColor = Color.DarkSlateBlue;
            sairToolStripMenuItem.ForeColor = SystemColors.Control;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(193, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += Exit;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { endereçoDoBandoToolStripMenuItem, sobreToolStripMenuItem });
            configuraçõesToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // endereçoDoBandoToolStripMenuItem
            // 
            endereçoDoBandoToolStripMenuItem.BackColor = Color.DarkSlateBlue;
            endereçoDoBandoToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            endereçoDoBandoToolStripMenuItem.Name = "endereçoDoBandoToolStripMenuItem";
            endereçoDoBandoToolStripMenuItem.Size = new Size(159, 22);
            endereçoDoBandoToolStripMenuItem.Text = "Endereço Banco";
            endereçoDoBandoToolStripMenuItem.Click += EndereçoBanco;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.BackColor = Color.DarkSlateBlue;
            sobreToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(159, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += VerSobre;
            // 
            // emp
            // 
            emp.BackColor = Color.Green;
            emp.Cursor = Cursors.Hand;
            emp.FlatAppearance.BorderColor = Color.Black;
            emp.FlatAppearance.BorderSize = 0;
            emp.FlatStyle = FlatStyle.Flat;
            emp.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            emp.ForeColor = SystemColors.ButtonHighlight;
            emp.Location = new Point(176, 3);
            emp.Name = "emp";
            emp.Size = new Size(167, 114);
            emp.TabIndex = 5;
            emp.Text = "Empresas";
            emp.TextAlign = ContentAlignment.MiddleLeft;
            emp.UseVisualStyleBackColor = false;
            emp.Click += VerEmpresas;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(containercad);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(25, 48);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(868, 484);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // containercad
            // 
            containercad.Controls.Add(containerlabelcad);
            containercad.Controls.Add(cademp);
            containercad.Controls.Add(caditem);
            containercad.Controls.Add(adduser);
            containercad.Controls.Add(addcd);
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
            flowLayoutPanel2.Controls.Add(logs);
            flowLayoutPanel2.Controls.Add(emp);
            flowLayoutPanel2.Controls.Add(ConsultaItens);
            flowLayoutPanel2.Location = new Point(3, 211);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(784, 125);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // logs
            // 
            logs.BackColor = Color.Green;
            logs.Cursor = Cursors.Hand;
            logs.FlatAppearance.BorderColor = Color.Black;
            logs.FlatAppearance.BorderSize = 0;
            logs.FlatStyle = FlatStyle.Flat;
            logs.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            logs.ForeColor = SystemColors.ButtonHighlight;
            logs.Location = new Point(3, 3);
            logs.Name = "logs";
            logs.Size = new Size(167, 114);
            logs.TabIndex = 4;
            logs.Text = "Logs";
            logs.TextAlign = ContentAlignment.MiddleLeft;
            logs.UseVisualStyleBackColor = false;
            logs.Click += VerLog;
            // 
            // ConsultaItens
            // 
            ConsultaItens.BackColor = Color.Green;
            ConsultaItens.Cursor = Cursors.Hand;
            ConsultaItens.FlatAppearance.BorderColor = Color.Black;
            ConsultaItens.FlatAppearance.BorderSize = 0;
            ConsultaItens.FlatStyle = FlatStyle.Flat;
            ConsultaItens.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ConsultaItens.ForeColor = SystemColors.ButtonHighlight;
            ConsultaItens.Location = new Point(349, 3);
            ConsultaItens.Name = "ConsultaItens";
            ConsultaItens.Size = new Size(167, 114);
            ConsultaItens.TabIndex = 6;
            ConsultaItens.Text = "Itens";
            ConsultaItens.TextAlign = ContentAlignment.MiddleLeft;
            ConsultaItens.UseVisualStyleBackColor = false;
            ConsultaItens.Click += ConsultarItens;
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
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(981, 544);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cademp;
        private Button caditem;
        private Button adduser;
        private Button addcd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nameuser;
        private ToolStripMenuItem userConfigToolStripMenuItem;
        private ToolStripMenuItem trocarDeContaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem alterarOutrosUsuários;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem endereçoDoBandoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Button emp;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button logs;
        private Button ConsultaItens;
        private Label cadastrar;
        private Label visualizar;
        private FlowLayoutPanel containerlabelcad;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel containercad;
        private ToolStripMenuItem useron;
        private PictureBox pictureBox1;
    }
}