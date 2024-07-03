using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanilla
{
    public class PedidosController
    {
        Ipedido view;
        PedidosModel model;

        public PedidosController(Ipedido view, PedidosModel model)
        {
            this.view = view;
            this.model = model;
            view.SetController(this);
            Exibir();
        }
        public void Exibir()
        {
            view.TabelaClient.Rows.Clear();
            view.TabelaTransportadora.Rows.Clear();
            view.TabelaItensDisponivel.Rows.Clear();
            view.TabelaItensSelecionados.Rows.Clear();

            model.ColetarDados(0);
            foreach (var obj in model.Empresas)
            {
                view.TabelaClient.Rows.Add(obj.Key, obj.Value);
            }
            model.ColetarDados(2);
            foreach (var obj in model.Empresas)
            {
                view.TabelaTransportadora.Rows.Add(obj.Key, obj.Value);
            }
            model.RetornarItens();
            foreach (var obj in model.Itens)
            {
                view.TabelaItensDisponivel.Rows.Add(obj.Id_item, obj.Nome_item);
            }
        }
        public void AtualizaItens()
        {
            view.TabelaItensDisponivel.Rows.Clear();
            view.TabelaItensSelecionados.Rows.Clear();
            foreach (var obj in model.Itens)
            {
                if (obj.ItemDisp) { view.TabelaItensSelecionados.Rows.Add(obj.Id_item, obj.Nome_item, obj.Qtd); }
                else { view.TabelaItensDisponivel.Rows.Add(obj.Id_item, obj.Nome_item); }
            }
        }
        public void SelecionaItem(int id){ model.ItemSelecionado(id);
            AtualizaItens();
        }
    }
}
