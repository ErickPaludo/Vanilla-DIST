namespace Vanilla
{
    partial class Telas
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
            Ccademp.Location = new Point(3, 3);
            Ccademp.Name = "Ccademp";
            Ccademp.Size = new Size(30, 30);
            Ccademp.TabIndex = 1;
            Ccademp.TextAlign = ContentAlignment.MiddleLeft;
            Ccademp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HoloLens MDL2 Assets", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 27);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Telas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Ccademp);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "Telas";
            Size = new Size(288, 37);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Ccademp;
        private Label label1;
    }
}
