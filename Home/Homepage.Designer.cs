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
            menuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            containercad.SuspendLayout();
            containerlabelcad.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // cademp
            // 
            cademp.BackColor = Color.White;
            cademp.Location = new Point(3, 47);
            cademp.Name = "cademp";
            cademp.Size = new Size(114, 114);
            cademp.TabIndex = 0;
            cademp.Text = "Empresa";
            cademp.UseVisualStyleBackColor = false;
            cademp.Click += button1_Click;
            // 
            // caditem
            // 
            caditem.BackColor = Color.White;
            caditem.Location = new Point(123, 47);
            caditem.Name = "caditem";
            caditem.Size = new Size(114, 114);
            caditem.TabIndex = 3;
            caditem.Text = "Itens";
            caditem.UseVisualStyleBackColor = false;
            caditem.Click += AbrirItem;
            // 
            // adduser
            // 
            adduser.Location = new Point(243, 47);
            adduser.Name = "adduser";
            adduser.Size = new Size(114, 114);
            adduser.TabIndex = 4;
            adduser.Text = "Usuario";
            adduser.UseVisualStyleBackColor = true;
            adduser.Click += button5_Click;
            // 
            // addcd
            // 
            addcd.Location = new Point(363, 47);
            addcd.Name = "addcd";
            addcd.Size = new Size(114, 114);
            addcd.TabIndex = 10;
            addcd.Text = "Add Cd";
            addcd.UseVisualStyleBackColor = true;
            addcd.Visible = false;
            addcd.Click += AddCd;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nameuser, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(981, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // nameuser
            // 
            nameuser.DropDownItems.AddRange(new ToolStripItem[] { useron, alterarOutrosUsuários, userConfigToolStripMenuItem, trocarDeContaToolStripMenuItem, sairToolStripMenuItem });
            nameuser.Name = "nameuser";
            nameuser.Size = new Size(59, 20);
            nameuser.Text = "Usuário";
            // 
            // useron
            // 
            useron.Name = "useron";
            useron.Size = new Size(193, 22);
            useron.Text = "Usuários Online";
            useron.Click += LOgados;
            // 
            // alterarOutrosUsuários
            // 
            alterarOutrosUsuários.Name = "alterarOutrosUsuários";
            alterarOutrosUsuários.Size = new Size(193, 22);
            alterarOutrosUsuários.Text = "Alterar outros usuários";
            alterarOutrosUsuários.Click += AlterarQualqueruser;
            // 
            // userConfigToolStripMenuItem
            // 
            userConfigToolStripMenuItem.Name = "userConfigToolStripMenuItem";
            userConfigToolStripMenuItem.Size = new Size(193, 22);
            userConfigToolStripMenuItem.Text = "Alterar Conta";
            userConfigToolStripMenuItem.Click += AlterarUser;
            // 
            // trocarDeContaToolStripMenuItem
            // 
            trocarDeContaToolStripMenuItem.Name = "trocarDeContaToolStripMenuItem";
            trocarDeContaToolStripMenuItem.Size = new Size(193, 22);
            trocarDeContaToolStripMenuItem.Text = "Trocar de Conta";
            trocarDeContaToolStripMenuItem.Click += TrocarConta;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(193, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += Exit;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { endereçoDoBandoToolStripMenuItem, sobreToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // endereçoDoBandoToolStripMenuItem
            // 
            endereçoDoBandoToolStripMenuItem.Name = "endereçoDoBandoToolStripMenuItem";
            endereçoDoBandoToolStripMenuItem.Size = new Size(159, 22);
            endereçoDoBandoToolStripMenuItem.Text = "Endereço Banco";
            endereçoDoBandoToolStripMenuItem.Click += EndereçoBanco;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(159, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += VerSobre;
            // 
            // emp
            // 
            emp.Location = new Point(123, 3);
            emp.Name = "emp";
            emp.Size = new Size(114, 114);
            emp.TabIndex = 13;
            emp.Text = "Empresas";
            emp.UseVisualStyleBackColor = true;
            emp.Click += VerEmpresas;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(containercad);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(23, 27);
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
            logs.Location = new Point(3, 3);
            logs.Name = "logs";
            logs.Size = new Size(114, 114);
            logs.TabIndex = 15;
            logs.Text = "Logs";
            logs.UseVisualStyleBackColor = true;
            logs.Click += VerLog;
            // 
            // ConsultaItens
            // 
            ConsultaItens.Location = new Point(243, 3);
            ConsultaItens.Name = "ConsultaItens";
            ConsultaItens.Size = new Size(114, 114);
            ConsultaItens.TabIndex = 16;
            ConsultaItens.Text = "Itens";
            ConsultaItens.UseVisualStyleBackColor = true;
            ConsultaItens.Click += ConsultarItens;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 544);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
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
    }
}