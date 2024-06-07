using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public interface IHomePage
    {
        void SetController(HomeController controler);
        Form Home { get; set; }
        ToolStripMenuItem UserMenu
        {
            get; set;
        }
        ToolStripMenuItem UserOn
        {
            get; set;
        }
        ToolStripMenuItem AlterUserAdm
        {
            get; set;
        }
        ToolStripMenuItem AlterUserDefaul
        {
            get; set;
        }
        ToolStripMenuItem Logoff
        {
            get; set;
        }
        ToolStripMenuItem Sair
        {
            get; set;
        }
        CustomBtnScreen CadEmpresas
        {
            get; set;
        }
        CustomBtnScreen CadItens
        {
            get; set;
        }
        CustomBtnScreen CadUser
        {
            get; set;
        }
        CustomBtnScreen LayoutCd
        {
            get; set;
        }
        CustomBtnScreen ViewLog
        {
            get; set;
        }
        CustomBtnScreen ViewEmp
        {
            get; set;
        }
        CustomBtnScreen ViewItens
        {
            get; set;
        }
        CustomBtnScreen ViewEnd
        {
            get; set;
        }
        CustomBtnScreen CdStatus
        {
            get; set;
        }
        CustomBtnScreen InsItem
        {
            get; set;
        }
    }
}
