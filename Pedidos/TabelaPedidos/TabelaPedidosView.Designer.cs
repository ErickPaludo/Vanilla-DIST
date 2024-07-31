namespace Vanilla
{
    partial class TabelaPedidosView
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
            dataGridLinhaPedido = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridPedidos = new DataGridView();
            Column10 = new DataGridViewComboBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridLinhaPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).BeginInit();
            SuspendLayout();
            // 
            // dataGridLinhaPedido
            // 
            dataGridLinhaPedido.AllowUserToAddRows = false;
            dataGridLinhaPedido.AllowUserToDeleteRows = false;
            dataGridLinhaPedido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLinhaPedido.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridLinhaPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridLinhaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLinhaPedido.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column8, Column7, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridLinhaPedido.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridLinhaPedido.Location = new Point(12, 289);
            dataGridLinhaPedido.Name = "dataGridLinhaPedido";
            dataGridLinhaPedido.ReadOnly = true;
            dataGridLinhaPedido.RowHeadersVisible = false;
            dataGridLinhaPedido.RowTemplate.Height = 25;
            dataGridLinhaPedido.Size = new Size(1260, 327);
            dataGridLinhaPedido.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Pedido";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 80;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Item";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Quantidade";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Cubagem";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridPedidos
            // 
            dataGridPedidos.AllowUserToAddRows = false;
            dataGridPedidos.AllowUserToDeleteRows = false;
            dataGridPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPedidos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPedidos.Columns.AddRange(new DataGridViewColumn[] { Column10, Column11, Column12, Column13, Column15, Column16, Column17 });
            dataGridPedidos.Location = new Point(12, 12);
            dataGridPedidos.Name = "dataGridPedidos";
            dataGridPedidos.RowHeadersVisible = false;
            dataGridPedidos.RowTemplate.Height = 25;
            dataGridPedidos.Size = new Size(1260, 271);
            dataGridPedidos.TabIndex = 20;
            dataGridPedidos.CellClick += SelecionaPedido;
            dataGridPedidos.CellMouseClick += dataGridPedidos_CellMouseClick;
            dataGridPedidos.CurrentCellDirtyStateChanged += SelecionaSituacao;
            dataGridPedidos.KeyDown += Atualiza;
            // 
            // Column10
            // 
            Column10.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Column10.HeaderText = "Status";
            Column10.Items.AddRange(new object[] { "Liberado", "Bloqueado", "Encerrado", "Cancelado" });
            Column10.Name = "Column10";
            Column10.Width = 90;
            // 
            // Column11
            // 
            Column11.HeaderText = "Pedido";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column12.HeaderText = "Cliente";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column13.HeaderText = "Transportadora";
            Column13.Name = "Column13";
            // 
            // Column15
            // 
            Column15.HeaderText = "Cubagem";
            Column15.Name = "Column15";
            // 
            // Column16
            // 
            Column16.HeaderText = "Data ini";
            Column16.Name = "Column16";
            Column16.Width = 150;
            // 
            // Column17
            // 
            Column17.HeaderText = "Data Fim";
            Column17.Name = "Column17";
            Column17.Width = 150;
            // 
            // TabelaPedidosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 661);
            Controls.Add(dataGridPedidos);
            Controls.Add(dataGridLinhaPedido);
            Name = "TabelaPedidosView";
            Text = "TabelaPedidosView";
            ((System.ComponentModel.ISupportInitialize)dataGridLinhaPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridPedidos;
        private DataGridView dataGridLinhaPedido;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewComboBoxColumn Column9;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
    }
}