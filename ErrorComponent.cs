using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanilla
{
    public partial class ErrorComponent : UserControl
    {
        public string RichBoxBasic
        {
            get { return richTextBoxBasic.Text; }
            set { richTextBoxBasic.Text = value; }
        }
        public string RichBoxAdvanced
        {
            get { return richTextBoxAdvanced.Text; }
            set { richTextBoxAdvanced.Text = value; }
        }

        public ErrorComponent()
        {
            InitializeComponent();
        }

        private void Encerrar(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            parentForm.Close();
        }
    }
}
