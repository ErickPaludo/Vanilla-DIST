namespace Vanilla
{
    partial class CadastroCd
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
            prediobox = new TextBox();
            laandares = new TextBox();
            button1 = new Button();
            atualizar = new Button();
            dataGridpar = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridimpar = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            minemp = new TextBox();
            dataGridruas = new DataGridView();
            Ruas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridpar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridimpar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridruas).BeginInit();
            SuspendLayout();
            // 
            // prediobox
            // 
            prediobox.Location = new Point(146, 4);
            prediobox.Name = "prediobox";
            prediobox.Size = new Size(120, 23);
            prediobox.TabIndex = 0;
            // 
            // laandares
            // 
            laandares.Location = new Point(146, 33);
            laandares.Name = "laandares";
            laandares.Size = new Size(120, 23);
            laandares.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(260, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GerarCd;
            // 
            // atualizar
            // 
            atualizar.Location = new Point(520, 428);
            atualizar.Name = "atualizar";
            atualizar.Size = new Size(75, 23);
            atualizar.TabIndex = 14;
            atualizar.Text = "Atualizar";
            atualizar.UseVisualStyleBackColor = true;
            atualizar.Click += Atualizar;
            // 
            // dataGridpar
            // 
            dataGridpar.AllowUserToAddRows = false;
            dataGridpar.AllowUserToDeleteRows = false;
            dataGridpar.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridpar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridpar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridpar.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridpar.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridpar.Location = new Point(12, 284);
            dataGridpar.Name = "dataGridpar";
            dataGridpar.ReadOnly = true;
            dataGridpar.RowHeadersVisible = false;
            dataGridpar.RowTemplate.Height = 25;
            dataGridpar.Size = new Size(274, 138);
            dataGridpar.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Lado Par";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridimpar
            // 
            dataGridimpar.AllowUserToAddRows = false;
            dataGridimpar.AllowUserToDeleteRows = false;
            dataGridimpar.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridimpar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridimpar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridimpar.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridimpar.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridimpar.Location = new Point(321, 284);
            dataGridimpar.Name = "dataGridimpar";
            dataGridimpar.ReadOnly = true;
            dataGridimpar.RowHeadersVisible = false;
            dataGridimpar.RowTemplate.Height = 25;
            dataGridimpar.Size = new Size(274, 138);
            dataGridimpar.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Lado Impar";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 7);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 17;
            label1.Text = "Quantidade de Predios:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 36);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 18;
            label2.Text = "Andares de Predios:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 62);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 20;
            label3.Text = "Andar mín empilhadeira:";
            // 
            // minemp
            // 
            minemp.Location = new Point(146, 59);
            minemp.Name = "minemp";
            minemp.Size = new Size(120, 23);
            minemp.TabIndex = 19;
            // 
            // dataGridruas
            // 
            dataGridruas.AllowUserToAddRows = false;
            dataGridruas.AllowUserToDeleteRows = false;
            dataGridruas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridruas.BackgroundColor = SystemColors.Control;
            dataGridruas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridruas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridruas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridruas.Columns.AddRange(new DataGridViewColumn[] { Ruas });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridruas.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridruas.Location = new Point(12, 130);
            dataGridruas.Name = "dataGridruas";
            dataGridruas.ReadOnly = true;
            dataGridruas.RowHeadersVisible = false;
            dataGridruas.RowTemplate.Height = 25;
            dataGridruas.Size = new Size(583, 148);
            dataGridruas.TabIndex = 21;
            // 
            // Ruas
            // 
            Ruas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ruas.HeaderText = "Ruas";
            Ruas.Name = "Ruas";
            Ruas.ReadOnly = true;
            // 
            // CadastroCd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(625, 490);
            Controls.Add(dataGridruas);
            Controls.Add(label3);
            Controls.Add(minemp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridimpar);
            Controls.Add(dataGridpar);
            Controls.Add(atualizar);
            Controls.Add(button1);
            Controls.Add(laandares);
            Controls.Add(prediobox);
            Name = "CadastroCd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroCd";
            ((System.ComponentModel.ISupportInitialize)dataGridpar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridimpar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridruas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox prediobox;
        private TextBox laandares;
        private Button button1;
        private DataGridView dataGridruas;
        private DataGridViewTextBoxColumn Ruas;
        private DataGridViewTextBoxColumn ColumnRua;
        private Button atualizar;
        private DataGridView dataGridpar;
        private DataGridView dataGridimpar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox minemp;
    }
}