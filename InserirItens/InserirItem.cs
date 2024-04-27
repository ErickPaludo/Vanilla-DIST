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
        Util util = new Util();
        ClassQuantItem estoque_item = new ClassQuantItem();
        private static List<CadastrarItens> item = new List<CadastrarItens>();
        static int id_select;
        public InserirItem()
        {
            InitializeComponent();
        }

        public void ExistenciaEndereco()
        {
            if(estoque_item.VerificaExistencia() != true)
            {
                Binserir.Enabled = false;
            }
        }

        public void Atualizar()
        {
            ExistenciaEndereco();
            item.Clear();
            dataGridViewItens.Rows.Clear();
            estoque_item.RetornaItens();
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
            if (id_select != 0)
            {
                if (!string.IsNullOrEmpty(Tquant.Text))
                {
                    DialogResult result = MessageBox.Show("Essa operação não poderá ser desfeita, deseja continuar?", $"Inserir itenss", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        estoque_item.InsereItens(id_select, Convert.ToInt32(Tquant.Text));
                        id_select = 0;
                        Tquant.Text = string.Empty;
                        Litem.Text = string.Empty;
                        Atualizar();
                    }
                }
                else
                {
                    MessageBox.Show("Verifique o campo de quantidades novamente!", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um item!", "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //Está sendo enviada a inscrição estadual para busca de dados (vai ser alterado para cnpj)
            {
                string select = (dataGridViewItens.Rows[e.RowIndex].Cells[0].Value).ToString();
                foreach (CadastrarItens obj in item)
                {
                    if (obj.Nome_item == select)
                    {
                        id_select = obj.Id_item;
                        Litem.Text = obj.Nome_item;
                    }
                }

            }
        }

        private void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            util.SomenteNumeros(e);
        }
    }
}
