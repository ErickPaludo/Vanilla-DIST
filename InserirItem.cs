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
    public partial class InserirItem : Form
    {
        Database db = new Database();
        private static List<CadastrarItens> item = new List<CadastrarItens>();
        static int id_select;
        public InserirItem()
        {
            InitializeComponent();
        }

        public void Atualizar()
        {
            item.Clear();
            dataGridViewItens.Rows.Clear();
            db.ChamaView("view_itens", 2);
            foreach (CadastrarItens obj in item)
            {
                dataGridViewItens.Rows.Add(obj.Nome_item, obj.Quantidade);
            }
        }

        public void AddListItems(int id, string nome, int quantidade)
        {
            item.Add(new CadastrarItens(id, nome, quantidade));
        }

        private void Inserir(object sender, EventArgs e)
        {
            db.InsereItens(id_select,Convert.ToInt32(Tquant.Text));
            id_select = 0;
            Atualizar();
        }

        private void Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //Está sendo enviada a inscrição estadual para busca de dados (vai ser alterado para cnpj)
            {
                string select = (dataGridViewItens.Rows[e.RowIndex].Cells[0].Value).ToString();
                foreach(CadastrarItens obj in item)
                {
                    if(obj.Nome_item == select)
                    {
                        id_select = obj.Id_item;
                        Litem.Text = obj.Nome_item;
                    }
                }
         
            }
        }
    }
}
