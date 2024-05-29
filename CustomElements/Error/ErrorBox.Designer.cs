using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vanilla
{
    partial class ErrorBox
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
            errorComponent1 = new ErrorComponent();
            SuspendLayout();
            // 
            // errorComponent1
            // 
            errorComponent1.Location = new Point(-5, -3);
            errorComponent1.Name = "errorComponent1";
            errorComponent1.RichBoxAdvanced = "";
            errorComponent1.RichBoxBasic = "";
            errorComponent1.Size = new Size(678, 263);
            errorComponent1.TabIndex = 0;
            // 
            // ErrorBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 273);
            ControlBox = false;
            Controls.Add(errorComponent1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ErrorBox";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private ErrorComponent errorComponent1;
    }
}