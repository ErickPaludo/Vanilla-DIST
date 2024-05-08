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

namespace Vanilla
{
    public partial class TabelaEmpresas : Form
    {
        #region Cabeçalho
        static private List<CadastraCnpjBack> listaCNPJs = new List<CadastraCnpjBack>();
        private TabelaEmpClass table = new TabelaEmpClass();
        private static bool executer;
        #endregion
        #region Construtores
        public TabelaEmpresas(bool type)
        {
            InitializeComponent();
            executer = type;
        }
        public TabelaEmpresas()
        {
        }
        #endregion

        private void Atualizar(object sender, EventArgs e)//Vai imprimir na tela os dados
        {
            Carregar();
        }
        public void Carregar()
        {
            Cursor = Cursors.WaitCursor;
            listaCNPJs.Clear();
            table.CarregarDadosEmpresas(0, "");
            dataGridEmp.Rows.Clear();
            foreach (CadastraCnpjBack obj in listaCNPJs)
            {
                dataGridEmp.Rows.Add(obj.Status_Format, obj.Nome_emp, obj.Cnpj, obj.Ie, obj.Type_f, obj.Tel, obj.Email, obj.UF, obj.Cidade, obj.Bairro, obj.Rua, obj.Numero, obj.CEP);
            }
            Cursor = Cursors.Default;
        }
        public void RecebeInfoList(string status, string type, string nome_emp, string cnpj, string ie, string tel, string email, int id, int id_end, string uf, string cidade, string bairro, string rua, int numero, string cep)//Recebe todas as informações do banco
        {
            listaCNPJs.Add(new CadastraCnpjBack(status, type, nome_emp, cnpj, ie, tel, email, id, id_end, uf, cidade, bairro, rua, numero, cep));
        }
        private void Pesquisar(object sender, EventArgs e) //Pesquisa na lista que veio do banco se existe o  item solicitado (id,nome,codbar)
        {
            Cursor = Cursors.WaitCursor;
            dataGridEmp.Rows.Clear();

            var itensFiltrados = listaCNPJs
      .Where(item => item.Nome_emp.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Cnpj.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Id.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Ie.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Email.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Tel.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.UF.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Cidade.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.CEP.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Status.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Status_Format.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Type_f.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase))
      .ToList(); // Filtro
            foreach (var obj in itensFiltrados) //Imprimi na tela
            {
                dataGridEmp.Rows.Add(obj.Status_Format, obj.Nome_emp, obj.Cnpj, obj.Ie, obj.Type_f, obj.Tel, obj.Email, obj.UF, obj.Cidade, obj.Bairro, obj.Rua, obj.Numero, obj.CEP);
            }
            Cursor = Cursors.Default;
        }
        private void Env(object sender, DataGridViewCellEventArgs e)
        {
            if (executer == true)//Permite a edicao do item
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //Está sendo enviada a inscrição estadual para busca de dados (vai ser alterado para cnpj)
                {
                    string cnpj = (dataGridEmp.Rows[e.RowIndex].Cells[2].Value).ToString();
                    CadastraCNPJ edit = new CadastraCNPJ();

                    edit.ReturDadosCnpj(cnpj, true);
                    this.Close();
                }
            }
        }

        private void camppesq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
