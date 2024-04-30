using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanilla
{

    public partial class TabelaItens : Form
    {
        Database db = new Database();
        Util cnpj = new Util();
        CadastrarItens itens_ = new CadastrarItens();
        static private List<CadastrarItens> itens = new List<CadastrarItens>();
        private bool executer;//variavel responsavel permitir a visualizacao ou alteracao dos itens
        public TabelaItens(bool op)
        {
            InitializeComponent();
            executer = op;
        }

        private void Pesquisar(object sender, EventArgs e) //Pesquisa na lista que veio do banco se existe o  item solicitado (id,nome,codbar)
        {
            dataGridItens.Rows.Clear();

            var itensFiltrados = itens
      .Where(item => item.Nome_f.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Codbar.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Id.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Status_conv.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase))
      .ToList();
            foreach (var obj in itensFiltrados)
            {
                dataGridItens.Rows.Add(obj.Id_item, obj.Id, obj.Nome_f, obj.Nome_item, obj.Quantidade, obj.Codbar, obj.Unmed, obj.Status_conv, obj.Descricao, $"R${obj.Preco_custo.ToString("f2")}", $"{obj.Lucro_porcent.ToString("f1")} %", $"R$ {obj.Preco_final.ToString("f2")}");
            }
        }
        public void AtualizarItens()
        {
            itens.Clear();
            itens_.ReturItens();
            dataGridItens.Rows.Clear();
            var listaOrdenada = itens.OrderBy(item => item.Id_item); //ordena itens pelo id
            foreach (CadastrarItens obj in listaOrdenada)
            {
                dataGridItens.Rows.Add(obj.Id_item, obj.Id, obj.Nome_f, obj.Nome_item, obj.Codbar, obj.Unmed, obj.Status_conv, obj.Descricao, $"R$ {obj.Preco_custo.ToString("f2")}", $"{obj.Lucro_porcent.ToString("f1")} %", $"R$ {obj.Preco_final.ToString("f2")}");
            }
        }
        public void AddNaTabelaItens(int id, int id_forn, string nome_fantasia, string codbar, string item, string descricao, string unmed, decimal preco_custo, decimal lucro_porcent, decimal preco_final, string status)
        {
            itens.Add(new CadastrarItens(id, id_forn, nome_fantasia, item, preco_custo, lucro_porcent, preco_final, codbar, status, descricao, unmed));
        }

        private void Env(object sender, DataGridViewCellMouseEventArgs e)//double click na celula para edicao do item
        {
            if (executer == true)//Permite a edicao do item
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = Convert.ToInt32(dataGridItens.Rows[e.RowIndex].Cells[0].Value);
                    CadastrarItensFront caditem = new CadastrarItensFront();
                    caditem.ReturnItens(id);
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarItens();
        }

        private void Exportar(object sender, EventArgs e)
        {
            TabelaItensClass export = new TabelaItensClass();
            export.Export(itens);
        }
    }
}
