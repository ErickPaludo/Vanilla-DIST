using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla;

namespace Vanilla
{
    public interface Ipedido
    {
        void SetController(PedidosController controller);
        Label NameClient { get;set;}
        Label NameTransportadora { get; set; }
        DataGridView TabelaClient { get; set; }
        DataGridView TabelaTransportadora { get; set; }
        DataGridView TabelaItensDisponivel { get; set; }
        DataGridView TabelaItensSelecionados { get; set; }
    }
}
