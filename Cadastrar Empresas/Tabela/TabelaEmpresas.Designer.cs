namespace Vanilla
{
    partial class TabelaEmpresas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaEmpresas));
            dataGridEmp = new DataGridView();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCNPJ = new DataGridViewTextBoxColumn();
            ColumnIE = new DataGridViewTextBoxColumn();
            ColumnType = new DataGridViewTextBoxColumn();
            ColumnTel = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnUF = new DataGridViewTextBoxColumn();
            ColumnCidade = new DataGridViewTextBoxColumn();
            ColumnBairro = new DataGridViewTextBoxColumn();
            ColumnRua = new DataGridViewTextBoxColumn();
            ColumnNumero = new DataGridViewTextBoxColumn();
            ColumnCep = new DataGridViewTextBoxColumn();
            camppesq = new TextBox();
            search = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridEmp).BeginInit();
            SuspendLayout();
            // 
            // dataGridEmp
            // 
            dataGridEmp.AllowUserToAddRows = false;
            dataGridEmp.AllowUserToDeleteRows = false;
            dataGridEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridEmp.BackgroundColor = SystemColors.Control;
            dataGridEmp.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmp.Columns.AddRange(new DataGridViewColumn[] { ColumnStatus, ColumnNome, ColumnCNPJ, ColumnIE, ColumnType, ColumnTel, ColumnEmail, ColumnUF, ColumnCidade, ColumnBairro, ColumnRua, ColumnNumero, ColumnCep });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridEmp.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridEmp.Location = new Point(15, 52);
            dataGridEmp.Name = "dataGridEmp";
            dataGridEmp.ReadOnly = true;
            dataGridEmp.RowHeadersVisible = false;
            dataGridEmp.RowTemplate.Height = 25;
            dataGridEmp.Size = new Size(902, 522);
            dataGridEmp.TabIndex = 13;
            dataGridEmp.CellDoubleClick += Env;
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            ColumnStatus.Width = 75;
            // 
            // ColumnNome
            // 
            ColumnNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnNome.HeaderText = "Nome";
            ColumnNome.MinimumWidth = 100;
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            // 
            // ColumnCNPJ
            // 
            ColumnCNPJ.HeaderText = "CNPJ";
            ColumnCNPJ.Name = "ColumnCNPJ";
            ColumnCNPJ.ReadOnly = true;
            ColumnCNPJ.Width = 130;
            // 
            // ColumnIE
            // 
            ColumnIE.HeaderText = "I.E";
            ColumnIE.Name = "ColumnIE";
            ColumnIE.ReadOnly = true;
            // 
            // ColumnType
            // 
            ColumnType.HeaderText = "Tipo";
            ColumnType.Name = "ColumnType";
            ColumnType.ReadOnly = true;
            // 
            // ColumnTel
            // 
            ColumnTel.HeaderText = "Tel";
            ColumnTel.Name = "ColumnTel";
            ColumnTel.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.ReadOnly = true;
            // 
            // ColumnUF
            // 
            ColumnUF.HeaderText = "UF";
            ColumnUF.Name = "ColumnUF";
            ColumnUF.ReadOnly = true;
            ColumnUF.Width = 80;
            // 
            // ColumnCidade
            // 
            ColumnCidade.HeaderText = "Cidade";
            ColumnCidade.Name = "ColumnCidade";
            ColumnCidade.ReadOnly = true;
            // 
            // ColumnBairro
            // 
            ColumnBairro.HeaderText = "Bairro";
            ColumnBairro.Name = "ColumnBairro";
            ColumnBairro.ReadOnly = true;
            // 
            // ColumnRua
            // 
            ColumnRua.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnRua.HeaderText = "Rua";
            ColumnRua.MinimumWidth = 100;
            ColumnRua.Name = "ColumnRua";
            ColumnRua.ReadOnly = true;
            // 
            // ColumnNumero
            // 
            ColumnNumero.HeaderText = "Numero";
            ColumnNumero.Name = "ColumnNumero";
            ColumnNumero.ReadOnly = true;
            // 
            // ColumnCep
            // 
            ColumnCep.HeaderText = "Cep";
            ColumnCep.Name = "ColumnCep";
            ColumnCep.ReadOnly = true;
            ColumnCep.Width = 85;
            // 
            // camppesq
            // 
            camppesq.Location = new Point(15, 23);
            camppesq.Name = "camppesq";
            camppesq.Size = new Size(142, 23);
            camppesq.TabIndex = 17;
            camppesq.TextChanged += camppesq_TextChanged;
            // 
            // search
            // 
            search.Cursor = Cursors.Hand;
            search.Location = new Point(176, 23);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 16;
            search.Text = "Pesquisar";
            search.UseVisualStyleBackColor = true;
            search.Click += Pesquisar;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(887, 580);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = false;
            button2.Click += Atualizar;
            // 
            // TabelaEmpresas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(944, 618);
            Controls.Add(button2);
            Controls.Add(camppesq);
            Controls.Add(search);
            Controls.Add(dataGridEmp);
            MinimizeBox = false;
            MinimumSize = new Size(960, 657);
            Name = "TabelaEmpresas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabela Empresas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridEmp;
        private TextBox camppesq;
        private Button search;
        private Button button2;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCNPJ;
        private DataGridViewTextBoxColumn ColumnIE;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnTel;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnUF;
        private DataGridViewTextBoxColumn ColumnCidade;
        private DataGridViewTextBoxColumn ColumnBairro;
        private DataGridViewTextBoxColumn ColumnRua;
        private DataGridViewTextBoxColumn ColumnNumero;
        private DataGridViewTextBoxColumn ColumnCep;
    }
}