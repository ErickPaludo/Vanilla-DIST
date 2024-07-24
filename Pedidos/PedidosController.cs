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
        Pedidos temp = new Pedidos();

        public PedidosController(Ipedido view, PedidosModel model)
        {
            this.view = view;
            this.model = model;
            view.SetController(this);
            view.NameClient.Text = string.Empty;
            view.NameTransportadora.Text = string.Empty;
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
        public void SelecionaItem(int id)
        {
            model.ItemSelecionado(id);
            AtualizaItens();
        }
        public void SelecionaCliente(int id, string nome)
        {
            temp.Id_c = id;
            view.NameClient.Text = nome;
        }
        public void SelecionaTransportadora(int id, string nome)
        {
            temp.Id_t = id;
            view.NameTransportadora.Text = nome;
        }
        public void AlteraQtd(int id, int qtd) { model.MudarQtdItem(id, qtd); }
        public void CadastraPedido()
        {
            if (temp.Id_c != 0 && temp.Id_t != 0)
            {
                bool val = false;
                foreach (var obj in model.Itens)
                {
                    if (obj.ItemDisp)
                    {
                        val = true;
                        break;
                    }
                }
                if (val)
                {

                    foreach (var obj in model.Itens)
                    {
                        if (obj.ItemDisp)
                        {
                            if (obj.Qtd == 0)
                            {
                                MessageBox.Show($"Impossível criar pedido, item {obj.Nome_item} possui quantidade 0");
                                val = false;
                                break;
                            }
                        }
                    }
                    if (val)
                    {
                        model.Cadastrar(new Pedidos(temp.Id_c, temp.Id_t));
                        Clear();
                        
                    }
                }
                else { MessageBox.Show("Selecione os itens do pedido!"); }
            }
            else { MessageBox.Show("Selecione Cliente e transportadora"); }

        }
        public void Clear()
        {
            Exibir();
            view.NameClient.Text = string.Empty;
            view.NameTransportadora.Text = string.Empty;
        }
    }
}
