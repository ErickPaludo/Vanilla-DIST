using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla;

namespace Vanilla
{
    public interface IBancoView
    {
        void SetController(ControllerBanco controller);
        Form Janela { get; }
        TextBox User { get; set; }
        TextBox Pass { get; set; }
        TextBox Connection { get; set; }
        TextBox Port { get; set; }
        TextBox Sid { get; set; }
        Label Status { get; set; }
    }
}
