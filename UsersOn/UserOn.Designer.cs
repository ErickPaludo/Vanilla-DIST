namespace Vanilla
{
    partial class UserOn
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
            dataGridLogados = new DataGridView();
            Deslog = new DataGridViewButtonColumn();
            ColumnUser = new DataGridViewTextBoxColumn();
            ColumnHost = new DataGridViewTextBoxColumn();
            ColumnIP = new DataGridViewTextBoxColumn();
            ColumnData = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridLogados).BeginInit();
            SuspendLayout();
            // 
            // dataGridLogados
            // 
            dataGridLogados.AllowUserToAddRows = false;
            dataGridLogados.AllowUserToDeleteRows = false;
            dataGridLogados.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridLogados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridLogados.BackgroundColor = SystemColors.Control;
            dataGridLogados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridLogados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridLogados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLogados.Columns.AddRange(new DataGridViewColumn[] { Deslog, ColumnUser, ColumnHost, ColumnIP, ColumnData });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridLogados.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridLogados.Location = new Point(12, 12);
            dataGridLogados.Name = "dataGridLogados";
            dataGridLogados.ReadOnly = true;
            dataGridLogados.RowHeadersVisible = false;
            dataGridLogados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridLogados.RowTemplate.Height = 25;
            dataGridLogados.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridLogados.Size = new Size(656, 376);
            dataGridLogados.TabIndex = 7;
            dataGridLogados.CellContentClick += dataGridLogados_CellContentClick;
            dataGridLogados.CellFormatting += dataGridLogados_CellFormatting;
            dataGridLogados.KeyDown += Atualize;
            // 
            // Deslog
            // 
            Deslog.HeaderText = "";
            Deslog.Name = "Deslog";
            Deslog.ReadOnly = true;
            Deslog.Resizable = DataGridViewTriState.True;
            Deslog.Text = "Deslogar";
            // 
            // ColumnUser
            // 
            ColumnUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnUser.HeaderText = "Usuário";
            ColumnUser.Name = "ColumnUser";
            ColumnUser.ReadOnly = true;
            // 
            // ColumnHost
            // 
            ColumnHost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnHost.HeaderText = "Nome da Máquina";
            ColumnHost.Name = "ColumnHost";
            ColumnHost.ReadOnly = true;
            // 
            // ColumnIP
            // 
            ColumnIP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnIP.HeaderText = "IP";
            ColumnIP.Name = "ColumnIP";
            ColumnIP.ReadOnly = true;
            // 
            // ColumnData
            // 
            ColumnData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnData.HeaderText = "Entrada";
            ColumnData.Name = "ColumnData";
            ColumnData.ReadOnly = true;
            // 
            // UserOn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 414);
            Controls.Add(dataGridLogados);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "UserOn";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuários Online";
            ((System.ComponentModel.ISupportInitialize)dataGridLogados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridLogados;
        private DataGridViewButtonColumn Deslog;
        private DataGridViewTextBoxColumn ColumnUser;
        private DataGridViewTextBoxColumn ColumnHost;
        private DataGridViewTextBoxColumn ColumnIP;
        private DataGridViewTextBoxColumn ColumnData;
    }
}