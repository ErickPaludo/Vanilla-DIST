using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vanilla.CadastraCd.Tabela;

namespace Vanilla
{
    public partial class TabelaEnderecos : Form
    {
        static private List<LogisticaCD> cdList = new List<LogisticaCD>();
        static private List<LogisticaCD> picking = new List<LogisticaCD>();
        ClassTabelaEnd cadcd = new ClassTabelaEnd();
        public bool edit = false;
        public TabelaEnderecos()
        {
            InitializeComponent();
        }

        public void ModoDeRetorno(int type)
        {
            search.Visible = false;
            camppesq.Visible = false;
            radioButtonLivres.Checked = true;
            radioButtonOcupados.Enabled = false;
            radioButtonTodos.Enabled = false;
            edit = true;
            //Referente a enderecos picking
            if (type == 1)
            {
                radioButtonPick.Checked = true;
                radioButtonEnd.Enabled = false;
                AtualizarPicking();
            }
            else //referente a enderecos pulmao
            {
                radioButtonPick.Enabled = false;
                radioButtonEnd.Checked = true;
            }
        }
        public void Atualizar()
        {
            cdList.Clear();
            dataGridCd.Rows.Clear();
            cadcd.RetornaEnd();
            foreach (LogisticaCD obj in cdList)
            {
                if (radioButtonLivres.Checked)
                {
                    if (obj.Item_no_endereco == "")
                    {
                        dataGridCd.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la}", obj.Cod_bar, obj.Name, obj.Item_no_endereco);
                    }
                }
                else if (radioButtonOcupados.Checked)
                {
                    if (obj.Item_no_endereco != "")
                    {
                        dataGridCd.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la}", obj.Cod_bar, obj.Name, obj.Item_no_endereco);
                    }
                }
                else
                {
                    dataGridCd.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la}", obj.Cod_bar, obj.Name, obj.Item_no_endereco);
                }
            }
        }
        public void AtualizarPicking()
        {
            picking.Clear();
            dataGridCd.Rows.Clear();
            cadcd.RetornaSubLa();
            foreach (LogisticaCD obj in picking)
            {

                if (radioButtonLivres.Checked)
                {
                    if (obj.Item_no_endereco == "")
                    {
                        dataGridCd.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la} - {obj.Id_Subla}", obj.Cod_bar, obj.Name, obj.Item_no_endereco);
                    }
                }
                else if (radioButtonOcupados.Checked)
                {
                    if (obj.Item_no_endereco != "")
                    {
                        dataGridCd.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la} - {obj.Id_Subla}", obj.Cod_bar, obj.Name, obj.Item_no_endereco);
                    }
                }
                else
                {
                    dataGridCd.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la} - {obj.Id_Subla}", obj.Cod_bar, obj.Name, obj.Item_no_endereco);
                }

            }
        }
        public void GravaListEndereco(int rua, int predio, int andar, string codbar, string name_reg, string nome_item)
        {
            cdList.Add(new LogisticaCD(rua, predio, andar, codbar, name_reg, nome_item));
        }
        public void GravaListPicking(int id, int rua, int predio, int andar, int subla, string codbar, string name_reg, string nome_item)
        {
            picking.Add(new LogisticaCD(id, rua, predio, andar, subla, codbar, name_reg, nome_item));
        }


        private void AtualizarEnd(object sender, EventArgs e)
        {
            if (radioButtonEnd.Checked)
            {
                Atualizar();
            }
            else
            {
                dataGridCd.Rows.Clear();
            }
        }

        private void AtualizaPick(object sender, EventArgs e)
        {
            if (radioButtonPick.Checked)
            {
                AtualizarPicking();
            }
            else
            {
                dataGridCd.Rows.Clear();
            }
        }

        private void RadionClick(object sender, EventArgs e)
        {
            RadionAtualiza();
        }

        private void RadionAtualiza()
        {
            if (radioButtonEnd.Checked)
            {
                Atualizar();
            }
            else
            {
                AtualizarPicking();
            }
        }

        private void Pesquisar(object sender, EventArgs e)
        {

            if (radioButtonEnd.Checked)
            {
                cdList.Clear();
                cadcd.RetornaEnd();
                dataGridCd.Rows.Clear();
                var enderecosFiltrados = cdList.Where(item => item.Cod_bar.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Item_no_endereco.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase)).ToList(); // Filtro
                foreach (var obj in enderecosFiltrados) //Imprimi na tela
                {
                    dataGridCd.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la}", obj.Cod_bar, obj.Name, obj.Item_no_endereco);
                }
            }
            else
            {
                picking.Clear();
                cadcd.RetornaSubLa();
                dataGridCd.Rows.Clear();
                var enderecosFiltrados = picking.Where(item => item.Cod_bar.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Item_no_endereco.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase)).ToList(); // Filtro
                foreach (var obj in enderecosFiltrados) //Imprimi na tela
                {
                    dataGridCd.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la} - {obj.Id_Subla}", obj.Cod_bar, obj.Name, obj.Item_no_endereco);
                }
            }
        }

        private void dataGridCd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (edit == true)//Permite a edicao do item
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //Está sendo enviada a inscrição estadual para busca de dados (vai ser alterado para cnpj)
                {
                    string codbar = (dataGridCd.Rows[e.RowIndex].Cells[1].Value).ToString();
                    string endereco = (dataGridCd.Rows[e.RowIndex].Cells[0].Value).ToString();
                    if (radioButtonEnd.Checked)
                    {
                        foreach (var obj in cdList)
                        {
                            dataGridCd.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la}", obj.Cod_bar, obj.Name, obj.Item_no_endereco);
                        }
                    }
                    else
                    {
                        foreach (var obj in picking)
                        {
                            if (obj.Cod_bar == codbar)
                            {
                                CadastrarItensFront.id_endereco = obj.Id;
                                CadastrarItensFront.endereco = endereco;
                            }
                        }
                    }
                    this.Close();
                }
            }
        }
    }
}
