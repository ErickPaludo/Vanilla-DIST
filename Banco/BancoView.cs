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
    public partial class BancoView : Form, IBancoView
    {
        ControllerBanco controller;
        public BancoView()
        {
            InitializeComponent();
        }
        public void SetController(ControllerBanco controller)
        {
            this.controller = controller;
        }

        private void Gravar(object sender, EventArgs e)
        {
            controller.GravarEndereco();
        }
        public Form Janela { get { return this; } }
        public TextBox User { get { return labeluser; } set { labeluser = value; } }
        public TextBox Pass { get { return labelsenha; } set { labelsenha = value; } }
        public TextBox Connection { get { return labelconnect; } set { labelconnect = value; } }
        public TextBox Port { get { return labelport; } set { labelport = value; } }
        public TextBox Sid { get { return labelsid; } set { labelsid = value; } }
        public Label Status { get { return labelstatus; } set { labelstatus = value; } }
    }
}
