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
            get;set;
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
        Button CadEmpresas
        {
            get;set;
        }
        Button CadItens
        {
            get; set;
        }
        Button CadUser
        {
            get; set;
        }
        Button LayoutCd
        {
            get; set;
        }
        Button ViewLog
        {
            get; set;
        }
        Button ViewEmp
        {
            get; set;
        }
        Button ViewItens
        {
            get; set;
        }
        Button ViewEnd
        {
            get; set;
        }
        Button CdStatus
        {
            get; set;
        }
        Button InsItem
        {
            get; set;
        }
        DataGridView Janelas
        {
            get; set;
        }
        Button MsgOpen
        {
            get; set;
        }
    }
}
