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
    public partial class Telas : UserControl
    {
      
       public string Tela { get { return label1.Text; } set { label1.Text = value; } }
       public Color CorBtn { get { return Ccademp.BackColor; } set {  Ccademp.BackColor = value; } }
       public Image ImageBtn { get { return Ccademp.Image; } set { Ccademp.Image = value; } }
        public Telas()
        {
            InitializeComponent();
        }
    }
}
