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
    public partial class Sobre : Form
    {
        Database db = new Database();
        public Sobre()
        {
            InitializeComponent();
            version.Text = db.SobreSys();
        }
    }
}
