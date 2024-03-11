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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridLogados = new DataGridView();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridLogados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridLogados.BackgroundColor = SystemColors.Control;
            dataGridLogados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridLogados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridLogados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLogados.Columns.AddRange(new DataGridViewColumn[] { ColumnUser, ColumnHost, ColumnIP, ColumnData });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridLogados.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridLogados.Enabled = false;
            dataGridLogados.Location = new Point(12, 12);
            dataGridLogados.Name = "dataGridLogados";
            dataGridLogados.ReadOnly = true;
            dataGridLogados.RowHeadersVisible = false;
            dataGridLogados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridLogados.RowTemplate.Height = 25;
            dataGridLogados.Size = new Size(656, 397);
            dataGridLogados.TabIndex = 7;
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
            ClientSize = new Size(680, 440);
            Controls.Add(dataGridLogados);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "UserOn";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuários Online";
            KeyDown += Atualize;
            ((System.ComponentModel.ISupportInitialize)dataGridLogados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridLogados;
        private DataGridViewTextBoxColumn ColumnUser;
        private DataGridViewTextBoxColumn ColumnHost;
        private DataGridViewTextBoxColumn ColumnIP;
        private DataGridViewTextBoxColumn ColumnData;
    }
}