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
    public partial class CustomBtnScreen : UserControl
    {
          public event EventHandler MyControlClick;
       public string Tela { get { return label1.Text; } set { label1.Text = value; } }
       public Color CorBtn { get { return Ccademp.BackColor; } set {  Ccademp.BackColor = value; } }
       public Image ImageBtn { get { return Ccademp.Image; } set { Ccademp.Image = value; } }
        public CustomBtnScreen()
        {
            InitializeComponent();
            panel1.Click += new EventHandler(DClick);
            label1.Click += new EventHandler(DClick);
            Ccademp.Click += new EventHandler(DClick);
        }
        private void DClick(object sender, EventArgs e)
        {
            MyControlClick?.Invoke(this, e);
        }
    }
}
