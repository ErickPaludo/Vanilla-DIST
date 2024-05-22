using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public interface IViewMsg
    {
        void SetController(ControllerMsg controller);
        RichTextBox Allmsg
        {
            get; set;
        }
        TextBox UserText
        {
            get; set;
        }
        DataGridView GridUser
        {
            get;set;
        }
        Label Destinatario
        {
            get;set;
        }
        Button Env
        {
            get;set;
        }
    }
}
