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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosView));
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
            resources.ApplyResources(dataGridClient, "dataGridClient");
            dataGridClient.Name = "dataGridClient";
            dataGridClient.ReadOnly = true;
            dataGridClient.RowHeadersVisible = false;
            dataGridClient.RowTemplate.Height = 25;
            dataGridClient.CellClick += SelecionaCliente;
            // 
            // Column2
            // 
            resources.ApplyResources(Column2, "Column2");
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // ColumnPrecoF
            // 
            ColumnPrecoF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(ColumnPrecoF, "ColumnPrecoF");
            ColumnPrecoF.Name = "ColumnPrecoF";
            ColumnPrecoF.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
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
            resources.ApplyResources(dataGridTrans, "dataGridTrans");
            dataGridTrans.Name = "dataGridTrans";
            dataGridTrans.ReadOnly = true;
            dataGridTrans.RowHeadersVisible = false;
            dataGridTrans.RowTemplate.Height = 25;
            dataGridTrans.CellClick += SelecionaTansportadora;
            // 
            // Column3
            // 
            resources.ApplyResources(Column3, "Column3");
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
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
            resources.ApplyResources(dataGridItens, "dataGridItens");
            dataGridItens.Name = "dataGridItens";
            dataGridItens.ReadOnly = true;
            dataGridItens.RowHeadersVisible = false;
            dataGridItens.RowTemplate.Height = 25;
            dataGridItens.CellClick += SelecionaItem;
            // 
            // Column4
            // 
            resources.ApplyResources(Column4, "Column4");
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
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
            resources.ApplyResources(dataGridItensSelect, "dataGridItensSelect");
            dataGridItensSelect.Name = "dataGridItensSelect";
            dataGridItensSelect.RowHeadersVisible = false;
            dataGridItensSelect.RowTemplate.Height = 25;
            dataGridItensSelect.CellDoubleClick += RetirarItem;
            dataGridItensSelect.CellValidated += AlterarQtd;
            // 
            // Column5
            // 
            resources.ApplyResources(Column5, "Column5");
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle8.NullValue = "0";
            Column1.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(Column1, "Column1");
            Column1.MaxInputLength = 4;
            Column1.Name = "Column1";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CriarPedido;
            // 
            // lclient
            // 
            resources.ApplyResources(lclient, "lclient");
            lclient.Name = "lclient";
            // 
            // ltransp
            // 
            resources.ApplyResources(ltransp, "ltransp");
            ltransp.Name = "ltransp";
            // 
            // PedidosView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ltransp);
            Controls.Add(lclient);
            Controls.Add(button1);
            Controls.Add(dataGridItensSelect);
            Controls.Add(dataGridItens);
            Controls.Add(label2);
            Controls.Add(dataGridTrans);
            Controls.Add(label1);
            Controls.Add(dataGridClient);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PedidosView";
            TopMost = true;
            Move += Mover;
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