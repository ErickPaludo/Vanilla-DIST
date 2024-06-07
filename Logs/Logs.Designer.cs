namespace Vanilla
{
    partial class Logs
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridLog = new DataGridView();
            ColumnUser = new DataGridViewTextBoxColumn();
            ColumnLog = new DataGridViewTextBoxColumn();
            ColumnData = new DataGridViewTextBoxColumn();
            dateinicial = new DateTimePicker();
            datefinal = new DateTimePicker();
            camppesq = new TextBox();
            search = new Button();
            combouser = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridLog).BeginInit();
            SuspendLayout();
            // 
            // dataGridLog
            // 
            dataGridLog.AllowUserToAddRows = false;
            dataGridLog.AllowUserToDeleteRows = false;
            dataGridLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLog.BackgroundColor = SystemColors.Control;
            dataGridLog.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLog.Columns.AddRange(new DataGridViewColumn[] { ColumnUser, ColumnLog, ColumnData });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridLog.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridLog.Location = new Point(12, 47);
            dataGridLog.Name = "dataGridLog";
            dataGridLog.ReadOnly = true;
            dataGridLog.RowHeadersVisible = false;
            dataGridLog.RowTemplate.Height = 25;
            dataGridLog.Size = new Size(1001, 522);
            dataGridLog.TabIndex = 14;
            // 
            // ColumnUser
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ColumnUser.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnUser.HeaderText = "Usuário";
            ColumnUser.Name = "ColumnUser";
            ColumnUser.ReadOnly = true;
            // 
            // ColumnLog
            // 
            ColumnLog.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnLog.HeaderText = "Log";
            ColumnLog.Name = "ColumnLog";
            ColumnLog.ReadOnly = true;
            // 
            // ColumnData
            // 
            ColumnData.HeaderText = "Data / Hora";
            ColumnData.Name = "ColumnData";
            ColumnData.ReadOnly = true;
            ColumnData.Width = 150;
            // 
            // dateinicial
            // 
            dateinicial.Format = DateTimePickerFormat.Short;
            dateinicial.Location = new Point(362, 15);
            dateinicial.Name = "dateinicial";
            dateinicial.Size = new Size(95, 23);
            dateinicial.TabIndex = 16;
            // 
            // datefinal
            // 
            datefinal.Format = DateTimePickerFormat.Short;
            datefinal.Location = new Point(463, 15);
            datefinal.Name = "datefinal";
            datefinal.Size = new Size(95, 23);
            datefinal.TabIndex = 17;
            // 
            // camppesq
            // 
            camppesq.Location = new Point(12, 15);
            camppesq.Name = "camppesq";
            camppesq.Size = new Size(263, 23);
            camppesq.TabIndex = 19;
            // 
            // search
            // 
            search.Cursor = Cursors.Hand;
            search.Location = new Point(281, 15);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 18;
            search.Text = "Pesquisar";
            search.UseVisualStyleBackColor = true;
            search.Click += AtualizarViaBtn;
            // 
            // combouser
            // 
            combouser.Cursor = Cursors.Hand;
            combouser.DropDownStyle = ComboBoxStyle.DropDownList;
            combouser.FormattingEnabled = true;
            combouser.Items.AddRange(new object[] { "TODOS" });
            combouser.Location = new Point(892, 15);
            combouser.Name = "combouser";
            combouser.Size = new Size(121, 23);
            combouser.TabIndex = 20;
            // 
            // Logs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 626);
            Controls.Add(combouser);
            Controls.Add(camppesq);
            Controls.Add(search);
            Controls.Add(datefinal);
            Controls.Add(dateinicial);
            Controls.Add(dataGridLog);
            MinimumSize = new Size(1041, 665);
            Name = "Logs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logs";
            ((System.ComponentModel.ISupportInitialize)dataGridLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridLog;
        private DateTimePicker dateinicial;
        private DateTimePicker datefinal;
        private TextBox camppesq;
        private Button search;
        private DataGridViewTextBoxColumn ColumnUser;
        private DataGridViewTextBoxColumn ColumnLog;
        private DataGridViewTextBoxColumn ColumnData;
        private ComboBox combouser;
    }
}