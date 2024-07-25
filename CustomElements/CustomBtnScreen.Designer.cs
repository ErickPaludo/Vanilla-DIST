namespace Vanilla
{
    partial class CustomBtnScreen
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Ccademp = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Ccademp
            // 
            Ccademp.BackColor = Color.MidnightBlue;
            Ccademp.Cursor = Cursors.Hand;
            Ccademp.FlatAppearance.BorderColor = Color.FromArgb(100, 0, 0, 0);
            Ccademp.FlatStyle = FlatStyle.Flat;
            Ccademp.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Ccademp.ForeColor = SystemColors.ButtonHighlight;
            Ccademp.Location = new Point(3, 4);
            Ccademp.Name = "Ccademp";
            Ccademp.Size = new Size(16, 17);
            Ccademp.TabIndex = 1;
            Ccademp.TextAlign = ContentAlignment.MiddleLeft;
            Ccademp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 1);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 25);
            panel1.TabIndex = 3;
            // 
            // CustomBtnScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Ccademp);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "CustomBtnScreen";
            Size = new Size(263, 25);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Ccademp;
        private Label label1;
        private Panel panel1;
    }
}
