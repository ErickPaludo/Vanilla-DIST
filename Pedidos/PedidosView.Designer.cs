namespace Vanilla
{
    partial class PedidosView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dataGridClient = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            ColumnPrecoF = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dataGridTrans = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridItens = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridItensSelect = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            lclient = new Label();
            ltransp = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTrans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItensSelect).BeginInit();
            SuspendLayout();
            // 
            // dataGridClient
            // 
            dataGridClient.AllowUserToAddRows = false;
            dataGridClient.AllowUserToDeleteRows = false;
            dataGridClient.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClient.Columns.AddRange(new DataGridViewColumn[] { Column2, ColumnPrecoF });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridClient.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridClient.Location = new Point(12, 44);
            dataGridClient.Name = "dataGridClient";
            dataGridClient.ReadOnly = true;
            dataGridClient.RowHeadersVisible = false;
            dataGridClient.RowTemplate.Height = 25;
            dataGridClient.Size = new Size(348, 160);
            dataGridClient.TabIndex = 13;
            dataGridClient.CellClick += SelecionaCliente;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cod";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 80;
            // 
            // ColumnPrecoF
            // 
            ColumnPrecoF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnPrecoF.HeaderText = "Cliente";
            ColumnPrecoF.Name = "ColumnPrecoF";
            ColumnPrecoF.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 14;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 26);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 16;
            label2.Text = "Transportadora:";
            // 
            // dataGridTrans
            // 
            dataGridTrans.AllowUserToAddRows = false;
            dataGridTrans.AllowUserToDeleteRows = false;
            dataGridTrans.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridTrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTrans.Columns.AddRange(new DataGridViewColumn[] { Column3, dataGridViewTextBoxColumn1 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridTrans.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridTrans.Location = new Point(384, 44);
            dataGridTrans.Name = "dataGridTrans";
            dataGridTrans.ReadOnly = true;
            dataGridTrans.RowHeadersVisible = false;
            dataGridTrans.RowTemplate.Height = 25;
            dataGridTrans.Size = new Size(348, 160);
            dataGridTrans.TabIndex = 15;
            dataGridTrans.CellClick += SelecionaTansportadora;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cod";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Transportadora";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridItens
            // 
            dataGridItens.AllowUserToAddRows = false;
            dataGridItens.AllowUserToDeleteRows = false;
            dataGridItens.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItens.Columns.AddRange(new DataGridViewColumn[] { Column4, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridItens.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridItens.Location = new Point(12, 210);
            dataGridItens.Name = "dataGridItens";
            dataGridItens.ReadOnly = true;
            dataGridItens.RowHeadersVisible = false;
            dataGridItens.RowTemplate.Height = 25;
            dataGridItens.Size = new Size(348, 178);
            dataGridItens.TabIndex = 17;
            dataGridItens.CellClick += SelecionaItem;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cod";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Item";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridItensSelect
            // 
            dataGridItensSelect.AllowUserToAddRows = false;
            dataGridItensSelect.AllowUserToDeleteRows = false;
            dataGridItensSelect.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridItensSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridItensSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItensSelect.Columns.AddRange(new DataGridViewColumn[] { Column5, dataGridViewTextBoxColumn3, Column1 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridItensSelect.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridItensSelect.Location = new Point(384, 210);
            dataGridItensSelect.Name = "dataGridItensSelect";
            dataGridItensSelect.RowHeadersVisible = false;
            dataGridItensSelect.RowTemplate.Height = 25;
            dataGridItensSelect.Size = new Size(348, 178);
            dataGridItensSelect.TabIndex = 20;
            dataGridItensSelect.CellDoubleClick += RetirarItem;
            dataGridItensSelect.CellValidated += AlterarQtd;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cod";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Item";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle8.NullValue = "0";
            Column1.DefaultCellStyle = dataGridViewCellStyle8;
            Column1.HeaderText = "Qtd";
            Column1.MaxInputLength = 4;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // button1
            // 
            button1.Location = new Point(657, 397);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CriarPedido;
            // 
            // lclient
            // 
            lclient.AutoSize = true;
            lclient.Location = new Point(65, 26);
            lclient.Name = "lclient";
            lclient.Size = new Size(38, 15);
            lclient.TabIndex = 22;
            lclient.Text = "label3";
            // 
            // ltransp
            // 
            ltransp.AutoSize = true;
            ltransp.Location = new Point(479, 26);
            ltransp.Name = "ltransp";
            ltransp.Size = new Size(38, 15);
            ltransp.TabIndex = 23;
            ltransp.Text = "label4";
            // 
            // PedidosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 432);
            Controls.Add(ltransp);
            Controls.Add(lclient);
            Controls.Add(button1);
            Controls.Add(dataGridItensSelect);
            Controls.Add(dataGridItens);
            Controls.Add(label2);
            Controls.Add(dataGridTrans);
            Controls.Add(label1);
            Controls.Add(dataGridClient);
            Name = "PedidosView";
            Text = "PedidosView";
            ((System.ComponentModel.ISupportInitialize)dataGridClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTrans).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItensSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridClient;
        private Label label1;
        private Label label2;
        private DataGridView dataGridTrans;
        private DataGridView dataGridItens;
        private DataGridView dataGridItensSelect;
        private Button button1;
        private Label lclient;
        private Label ltransp;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn ColumnPrecoF;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column1;
    }
}