namespace Vanilla.StatusCd
{
    partial class StatusdoCd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Ltotal = new Label();
            Lquantp = new Label();
            Lquantpk = new Label();
            Lporcent = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Quantidade de Endereços:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 50);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantidade de Pulmões:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 79);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade de Picking:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 104);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 3;
            label4.Text = "Porcentagem de ocupação:";
            // 
            // Ltotal
            // 
            Ltotal.AutoSize = true;
            Ltotal.Location = new Point(176, 19);
            Ltotal.Name = "Ltotal";
            Ltotal.Size = new Size(13, 15);
            Ltotal.TabIndex = 4;
            Ltotal.Text = "0";
            // 
            // Lquantp
            // 
            Lquantp.AutoSize = true;
            Lquantp.Location = new Point(176, 50);
            Lquantp.Name = "Lquantp";
            Lquantp.Size = new Size(13, 15);
            Lquantp.TabIndex = 5;
            Lquantp.Text = "0";
            // 
            // Lquantpk
            // 
            Lquantpk.AutoSize = true;
            Lquantpk.Location = new Point(176, 79);
            Lquantpk.Name = "Lquantpk";
            Lquantpk.Size = new Size(13, 15);
            Lquantpk.TabIndex = 6;
            Lquantpk.Text = "0";
            // 
            // Lporcent
            // 
            Lporcent.AutoSize = true;
            Lporcent.Location = new Point(183, 104);
            Lporcent.Name = "Lporcent";
            Lporcent.Size = new Size(13, 15);
            Lporcent.TabIndex = 7;
            Lporcent.Text = "0";
            // 
            // StatusdoCd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 159);
            Controls.Add(Lporcent);
            Controls.Add(Lquantpk);
            Controls.Add(Lquantp);
            Controls.Add(Ltotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StatusdoCd";
            Text = "StatusdoCd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Ltotal;
        private Label Lquantp;
        private Label Lquantpk;
        private Label Lporcent;
    }
}