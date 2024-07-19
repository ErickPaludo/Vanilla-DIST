using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class ControllerTabelaPedidos
    {
        ITabelaPedidos view;
        ModelTabelaPedidos model;
        public ControllerTabelaPedidos(ITabelaPedidos view, ModelTabelaPedidos model)
        {
            this.view = view;
            this.model = model;
            view.SetController(this);
            AtualizaPedidos();
        }
        public void AtualizaPedidos()
        {
            model.ColetaPedidos();
            view.Tabela_pedidos.Rows.Clear();
            foreach(var obj in model.ListaPedidos)
            {
                int rowIndex = view.Tabela_pedidos.Rows.Add(obj.N_pedido, obj.Cliente, obj.Transportadora,obj.Status, obj.Cubagem.ToString("f3"),obj.Data_ini.ToString(), obj.Data_fim.ToString());

                if(obj.Status == "Bloqueado")
                {
                    view.Tabela_pedidos.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        public void AtualizaLinhaPedidos(int id_pedido)
        {
            model.ColetaLinhaPedidos(id_pedido.ToString());
            view.Tabela_linha_pedidos.Rows.Clear();
            foreach (var obj in model.Listalinhapedidos)
            {
                 view.Tabela_linha_pedidos.Rows.Add(obj.N_pedido, obj.Item, obj.Qtd.ToString(), obj.Cubagem.ToString("f3"));
            }
        }
    }
}
