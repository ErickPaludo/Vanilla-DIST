namespace Vanilla
{
    partial class TabelaEnderecos
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dataGridCd = new DataGridView();
            ColumnEndereco = new DataGridViewTextBoxColumn();
            ColumnCod = new DataGridViewTextBoxColumn();
            ColumnRegiao = new DataGridViewTextBoxColumn();
            ColumnItem = new DataGridViewTextBoxColumn();
            radioButtonEnd = new RadioButton();
            radioButtonPick = new RadioButton();
            groupBox1 = new GroupBox();
            radioButtonTodos = new RadioButton();
            radioButtonOcupados = new RadioButton();
            radioButtonLivres = new RadioButton();
            camppesq = new TextBox();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCd).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCd
            // 
            dataGridCd.AllowUserToAddRows = false;
            dataGridCd.AllowUserToDeleteRows = false;
            dataGridCd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCd.BackgroundColor = SystemColors.Control;
            dataGridCd.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridCd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridCd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCd.Columns.AddRange(new DataGridViewColumn[] { ColumnEndereco, ColumnCod, ColumnRegiao, ColumnItem });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridCd.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridCd.Location = new Point(12, 121);
            dataGridCd.Name = "dataGridCd";
            dataGridCd.ReadOnly = true;
            dataGridCd.RowHeadersVisible = false;
            dataGridCd.RowTemplate.Height = 25;
            dataGridCd.Size = new Size(900, 423);
            dataGridCd.TabIndex = 14;
            dataGridCd.CellContentClick += dataGridCd_CellContentClick;
            // 
            // ColumnEndereco
            // 
            ColumnEndereco.HeaderText = "Endereço";
            ColumnEndereco.Name = "ColumnEndereco";
            ColumnEndereco.ReadOnly = true;
            ColumnEndereco.Width = 150;
            // 
            // ColumnCod
            // 
            ColumnCod.HeaderText = "Código de Barras";
            ColumnCod.Name = "ColumnCod";
            ColumnCod.ReadOnly = true;
            ColumnCod.Width = 180;
            // 
            // ColumnRegiao
            // 
            ColumnRegiao.HeaderText = "Região de Separação";
            ColumnRegiao.Name = "ColumnRegiao";
            ColumnRegiao.ReadOnly = true;
            ColumnRegiao.Width = 150;
            // 
            // ColumnItem
            // 
            ColumnItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnItem.HeaderText = "Item";
            ColumnItem.Name = "ColumnItem";
            ColumnItem.ReadOnly = true;
            // 
            // radioButtonEnd
            // 
            radioButtonEnd.AutoSize = true;
            radioButtonEnd.Checked = true;
            radioButtonEnd.Location = new Point(6, 22);
            radioButtonEnd.Name = "radioButtonEnd";
            radioButtonEnd.Size = new Size(131, 19);
            radioButtonEnd.TabIndex = 15;
            radioButtonEnd.TabStop = true;
            radioButtonEnd.Text = "Endereços (Pulmão)";
            radioButtonEnd.UseVisualStyleBackColor = true;
            radioButtonEnd.Click += AtualizarEnd;
            // 
            // radioButtonPick
            // 
            radioButtonPick.AutoSize = true;
            radioButtonPick.Location = new Point(6, 47);
            radioButtonPick.Name = "radioButtonPick";
            radioButtonPick.Size = new Size(107, 19);
            radioButtonPick.TabIndex = 16;
            radioButtonPick.Text = "Picking (Sub la)";
            radioButtonPick.UseVisualStyleBackColor = true;
            radioButtonPick.Click += AtualizaPick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonEnd);
            groupBox1.Controls.Add(radioButtonPick);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 79);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipos de Endereço";
            // 
            // radioButtonTodos
            // 
            radioButtonTodos.AutoSize = true;
            radioButtonTodos.Checked = true;
            radioButtonTodos.Location = new Point(227, 47);
            radioButtonTodos.Name = "radioButtonTodos";
            radioButtonTodos.Size = new Size(56, 19);
            radioButtonTodos.TabIndex = 18;
            radioButtonTodos.TabStop = true;
            radioButtonTodos.Text = "Todos";
            radioButtonTodos.UseVisualStyleBackColor = true;
            radioButtonTodos.Click += RadionClick;
            // 
            // radioButtonOcupados
            // 
            radioButtonOcupados.AutoSize = true;
            radioButtonOcupados.Location = new Point(227, 71);
            radioButtonOcupados.Name = "radioButtonOcupados";
            radioButtonOcupados.Size = new Size(136, 19);
            radioButtonOcupados.TabIndex = 19;
            radioButtonOcupados.Text = "Endereços Ocupados";
            radioButtonOcupados.UseVisualStyleBackColor = true;
            radioButtonOcupados.Click += RadionClick;
            // 
            // radioButtonLivres
            // 
            radioButtonLivres.AutoSize = true;
            radioButtonLivres.Location = new Point(227, 96);
            radioButtonLivres.Name = "radioButtonLivres";
            radioButtonLivres.Size = new Size(112, 19);
            radioButtonLivres.TabIndex = 20;
            radioButtonLivres.Text = "Endereços Livres";
            radioButtonLivres.UseVisualStyleBackColor = true;
            radioButtonLivres.Click += RadionClick;
            // 
            // camppesq
            // 
            camppesq.Location = new Point(12, 7);
            camppesq.Name = "camppesq";
            camppesq.Size = new Size(190, 23);
            camppesq.TabIndex = 22;
            // 
            // search
            // 
            search.Cursor = Cursors.Hand;
            search.Location = new Point(208, 7);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 21;
            search.Text = "Pesquisar";
            search.UseVisualStyleBackColor = true;
            search.Click += Pesquisar;
            // 
            // TabelaEnderecos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 575);
            Controls.Add(camppesq);
            Controls.Add(search);
            Controls.Add(radioButtonLivres);
            Controls.Add(radioButtonOcupados);
            Controls.Add(radioButtonTodos);
            Controls.Add(groupBox1);
            Controls.Add(dataGridCd);
            Name = "TabelaEnderecos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabelaEnderecos";
            ((System.ComponentModel.ISupportInitialize)dataGridCd).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCd;
        private DataGridViewTextBoxColumn ColumnEndereco;
        private DataGridViewTextBoxColumn ColumnCod;
        private DataGridViewTextBoxColumn ColumnRegiao;
        private DataGridViewTextBoxColumn ColumnItem;
        private RadioButton radioButtonEnd;
        private RadioButton radioButtonPick;
        private GroupBox groupBox1;
        private RadioButton radioButtonTodos;
        private RadioButton radioButtonOcupados;
        private RadioButton radioButtonLivres;
        private TextBox camppesq;
        private Button search;
    }
}