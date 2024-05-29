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
    public partial class ErrorBox : Form
    {
        public ErrorBox(string erroBasic,string erroAdvenced)
        {
            InitializeComponent();
            errorComponent1.RichBoxBasic = erroBasic;
            errorComponent1.RichBoxAdvanced = erroAdvenced;
            this.ShowDialog();
        }
    }
}
