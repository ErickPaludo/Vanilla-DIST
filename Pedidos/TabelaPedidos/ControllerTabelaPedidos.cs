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
                int rowIndex = view.Tabela_pedidos.Rows.Add(obj.Status,obj.N_pedido, obj.Cliente, obj.Transportadora, obj.Cubagem.ToString("f3"),obj.Data_ini.ToString(), obj.Data_fim.ToString());

                if(obj.Status == "Bloqueado")
                {
                    view.Tabela_pedidos.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if(obj.Status == "Liberado")
                {
                    view.Tabela_pedidos.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;
                }
                else if (obj.Status == "Cancelado")
                {
                    view.Tabela_pedidos.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Gray;
                    view.Tabela_pedidos.Rows[rowIndex].Cells[0].ReadOnly = true;
                }
                else
                {
                    view.Tabela_pedidos.Rows[rowIndex].Cells[0].ReadOnly = true;
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
        public void AlterarSituacao(int id_pedido, string situacao)
        {
            if (situacao == "Cancelado" || situacao == "Encerrado")
            {
                DialogResult dialog = MessageBox.Show($"O pedido será {situacao}, essa alteração não poderá ser desfeita. \nDeseja continuar?", "Alteração do status", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    model.AlterarSituacao(id_pedido, situacao);
                }
            }
            else
            {
                model.AlterarSituacao(id_pedido, situacao);
            }
            AtualizaPedidos();
            view.Tabela_linha_pedidos.Rows.Clear();
        }
    }
}
