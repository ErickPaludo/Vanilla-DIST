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
        CadastrarItens itens_ = new CadastrarItens();
        static private List<CadastrarItens> itens = new List<CadastrarItens>();
        public List<CadastrarItens> Itens
        {
            get
            {
                return itens;
            }
        }
        private bool executer;//variavel responsavel permitir a visualizacao ou alteracao dos itens

        public TabelaItens()
        {
            InitializeComponent();
        }

        public TabelaItens(bool op)
        {
            InitializeComponent();
            executer = op;
        }

        private void Pesquisar(object sender, EventArgs e) //faz uma pesquisa customizada no banco
        {
            itens.Clear();
            string column = string.Empty;
            dataGridItens.Rows.Clear();
            if (Rnome.Checked)
            {
                column = "nome";
            }
            else
            {
                column = "codbar";
            }
            itens_.ReturItensCuston(column, Tcamppesq.Text);
            CaregaTable();        
        }
        public void AtualizarItens()//Pega todos os itens do estoque
        {
            itens.Clear();
            itens_.ReturItens();           
            CaregaTable();
        }
        public void CaregaTable()//Carrega a lista de itens
        {
            dataGridItens.Rows.Clear();
            foreach (CadastrarItens obj in itens)
            {
                dataGridItens.Rows.Add(obj.Id_item, obj.Id, obj.Nome_f, obj.Nome_item, obj.Codbar, obj.Unmed, obj.Status_conv, obj.Descricao, $"R$ {obj.Preco_custo.ToString("f2")}", $"{obj.Lucro_porcent.ToString("f1")} %", $"R$ {obj.Preco_final.ToString("f2")}");
            }
        }
        public void AddNaTabelaItens(CadastrarItens novo_item)//Recebe os dados do banco e registra na liste
        {
            itens.Add(novo_item);
        } //Voltar versão

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

        private void button2_Click(object sender, EventArgs e)//Atualiza o Datagrid manualmente
        {
            AtualizarItens();
        }

        private void ExportarXls(object sender, EventArgs e)//Exporta lista para XLS
        {
            TabelaItensClass export = new TabelaItensClass();
            export.ExportXls();
        }

        private void ExportarPdf(object sender, EventArgs e)//Exporta lista para PDF
        {
            TabelaItensClass export = new TabelaItensClass();
            export.ExportPdf();
        }
    }
}
