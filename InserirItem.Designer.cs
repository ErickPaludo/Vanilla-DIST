namespace Vanilla
{
    partial class InserirItem
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
            dataGridViewItens = new DataGridView();
            ColumnItem = new DataGridViewTextBoxColumn();
            ColumnQuantidade = new DataGridViewTextBoxColumn();
            button1 = new Button();
            Tquant = new TextBox();
            Litem = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewItens
            // 
            dataGridViewItens.AllowUserToAddRows = false;
            dataGridViewItens.AllowUserToDeleteRows = false;
            dataGridViewItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewItens.BackgroundColor = SystemColors.Control;
            dataGridViewItens.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Columns.AddRange(new DataGridViewColumn[] { ColumnItem, ColumnQuantidade });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewItens.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewItens.Location = new Point(12, 79);
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.ReadOnly = true;
            dataGridViewItens.RowHeadersVisible = false;
            dataGridViewItens.RowTemplate.Height = 25;
            dataGridViewItens.Size = new Size(556, 235);
            dataGridViewItens.TabIndex = 26;
            dataGridViewItens.CellClick += Cellclick;
            // 
            // ColumnItem
            // 
            ColumnItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnItem.HeaderText = "Item";
            ColumnItem.Name = "ColumnItem";
            ColumnItem.ReadOnly = true;
            // 
            // ColumnQuantidade
            // 
            ColumnQuantidade.HeaderText = "Quantidade";
            ColumnQuantidade.Name = "ColumnQuantidade";
            ColumnQuantidade.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(231, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Inserir;
            // 
            // Tquant
            // 
            Tquant.Location = new Point(12, 12);
            Tquant.Name = "Tquant";
            Tquant.Size = new Size(201, 23);
            Tquant.TabIndex = 28;
            // 
            // Litem
            // 
            Litem.AutoSize = true;
            Litem.Location = new Point(12, 49);
            Litem.Name = "Litem";
            Litem.Size = new Size(37, 15);
            Litem.TabIndex = 29;
            Litem.Text = "Litem";
            // 
            // InserirItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 326);
            Controls.Add(Litem);
            Controls.Add(Tquant);
            Controls.Add(button1);
            Controls.Add(dataGridViewItens);
            Name = "InserirItem";
            Text = "InserirItem";
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewItens;
        private DataGridViewTextBoxColumn ColumnItem;
        private DataGridViewTextBoxColumn ColumnQuantidade;
        private Button button1;
        private TextBox Tquant;
        private Label Litem;
    }
}