namespace Vanilla
{
    partial class ErrorComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorComponent));
            tabControl1 = new TabControl();
            tabPageBasic = new TabPage();
            richTextBoxBasic = new RichTextBox();
            tabPageAdvanced = new TabPage();
            richTextBoxAdvanced = new RichTextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPageBasic.SuspendLayout();
            tabPageAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageBasic);
            tabControl1.Controls.Add(tabPageAdvanced);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(3, 16);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(472, 218);
            tabControl1.TabIndex = 0;
            // 
            // tabPageBasic
            // 
            tabPageBasic.Controls.Add(richTextBoxBasic);
            tabPageBasic.Location = new Point(4, 24);
            tabPageBasic.Name = "tabPageBasic";
            tabPageBasic.Padding = new Padding(3);
            tabPageBasic.Size = new Size(464, 190);
            tabPageBasic.TabIndex = 0;
            tabPageBasic.Text = "Erro";
            tabPageBasic.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBasic
            // 
            richTextBoxBasic.BackColor = Color.FromArgb(224, 224, 224);
            richTextBoxBasic.Dock = DockStyle.Fill;
            richTextBoxBasic.ForeColor = SystemColors.ControlText;
            richTextBoxBasic.Location = new Point(3, 3);
            richTextBoxBasic.Name = "richTextBoxBasic";
            richTextBoxBasic.ReadOnly = true;
            richTextBoxBasic.Size = new Size(458, 184);
            richTextBoxBasic.TabIndex = 0;
            richTextBoxBasic.Text = "";
            // 
            // tabPageAdvanced
            // 
            tabPageAdvanced.Controls.Add(richTextBoxAdvanced);
            tabPageAdvanced.Location = new Point(4, 24);
            tabPageAdvanced.Name = "tabPageAdvanced";
            tabPageAdvanced.Padding = new Padding(3);
            tabPageAdvanced.Size = new Size(464, 190);
            tabPageAdvanced.TabIndex = 1;
            tabPageAdvanced.Text = "Avançado";
            tabPageAdvanced.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAdvanced
            // 
            richTextBoxAdvanced.BackColor = Color.FromArgb(224, 224, 224);
            richTextBoxAdvanced.Dock = DockStyle.Fill;
            richTextBoxAdvanced.Location = new Point(3, 3);
            richTextBoxAdvanced.Name = "richTextBoxAdvanced";
            richTextBoxAdvanced.ReadOnly = true;
            richTextBoxAdvanced.Size = new Size(458, 184);
            richTextBoxAdvanced.TabIndex = 1;
            richTextBoxAdvanced.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(536, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 1;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Encerrar;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(477, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 190);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ErrorComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "ErrorComponent";
            Size = new Size(680, 264);
            tabControl1.ResumeLayout(false);
            tabPageBasic.ResumeLayout(false);
            tabPageAdvanced.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageBasic;
        private RichTextBox richTextBoxBasic;
        private TabPage tabPageAdvanced;
        private RichTextBox richTextBoxAdvanced;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
