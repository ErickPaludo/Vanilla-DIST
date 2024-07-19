using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public interface ITabelaPedidos
    {
        void SetController(ControllerTabelaPedidos controller);
        DataGridView Tabela_pedidos { get; set; }
        DataGridView Tabela_linha_pedidos { get; set; }
    }
}
