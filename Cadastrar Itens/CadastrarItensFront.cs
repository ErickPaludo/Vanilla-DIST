using GenCode128;
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
    public partial class CadastrarItensFront : Form
    {
        Util cnpj = new Util();
        Database db = new Database();
        CadastrarItens cad = new CadastrarItens();
        private static List<CadastrarItens> import = new List<CadastrarItens>(); //Lista que vai coletar as informacoes dos fornecedores para adicionar na tabela
        private int id_fornecedor; // Id do fornecedor fica armazenado nessa variavel
        private static int id_item;
        public CadastrarItensFront()
        {
            InitializeComponent();
        }
        private void NewItem(object sender, EventArgs e)//Inicia chamado para inserir itens
        {
            ModifyElements(true);
            newItem.Enabled = false;
            editarItem.Enabled = false;
            codigoBarras.Text = cad.GeraCodBarrar();
            MostrCodBar();
        }
        public void ModifyElements(bool type) //Altera propriedades
        {
            selectFornecedor.Text = string.Empty;
            AddTable();
            calcular.Enabled = type;
            label1.Enabled = type;
            label2.Enabled = type;
            label3.Enabled = type;
            label4.Enabled = type;
            label5.Enabled = type;
            label6.Enabled = type;
            label7.Enabled = type;
            label8.Enabled = type;
            label9.Enabled = type;
            calcular.Enabled = type;
            comboUMed.Enabled = type;
            buttonAtualizarTable.Enabled = type;
            selectFornecedor.Enabled = type;
            precoFinal.Enabled = type;
            Lucro.Enabled = type;
            precoFinal.Enabled = type;
            nomeItem.Enabled = type;
            comboStatus.Enabled = type;
            dataGridFornecedores.Enabled = type;
            descItem.Enabled = type;
            quantItem.Enabled = type;
            precoCusto.Enabled = type;
            porcentLucro.Enabled = type;
            newFornec.Enabled = type;
            buttonGravar.Visible = type;
            codMaual.Enabled = type;
            cancelar.Enabled = type;
        }
        public void ClearCamp() //Limpa tudo
        {
            codMaual.Checked = false;
            comboStatus.SelectedIndex = -1;
            comboUMed.SelectedIndex = -1;
            selectFornecedor.Text = string.Empty;
            comboStatus.Text = string.Empty;
            comboUMed.Text = string.Empty;
            precoFinal.Text = string.Empty;
            precoFinal.Text = string.Empty;
            nomeItem.Text = string.Empty;
            descItem.Text = string.Empty;
            quantItem.Text = string.Empty;
            precoCusto.Text = string.Empty;
            porcentLucro.Text = string.Empty;
            codigoBarras.Text = string.Empty;
            codigoBarras.Enabled = false;
            newItem.Enabled = true;
            editarItem.Enabled = true;
        }
        public void ImportarDados(int id_fornec, string nome, string cnpj) //Importa dados do bd, add em uma lista
        {
            import.Add(new CadastrarItens(id_fornec, nome, cnpj));
        }
        public void AddTable()//add os fornecedores na tabela
        {
            import.Clear();
            dataGridFornecedores.Rows.Clear();
            db.TabelaFornecItem();
            foreach (CadastrarItens item in import)
            {
                dataGridFornecedores.Rows.Add(item.Id, item.Nome_emp, cnpj.FormataCnpj(item.Cnpj));
            }
        }
        private void AddFornecedor(object sender, EventArgs e)//chama o front para add fornecedores
        {
            CadastraCNPJ newcnpj = new CadastraCNPJ(1);
            newcnpj.ShowDialog();
            AddTable();
        }
        private void SelectFornec(object sender, DataGridViewCellEventArgs e)//seleciona o fornecedor via tabela
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectFornecedor.Text = $"{dataGridFornecedores.Rows[e.RowIndex].Cells[1].Value.ToString()}";
                id_fornecedor = Convert.ToInt32(dataGridFornecedores.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
        private void PrecoFinal(object sender, EventArgs e) //Vai executar o calculo de valor final
        {

        }
        private void PadronizaPCusto(object sender, EventArgs e) //Apenas define o valo R$00,00 no custo caso ele seja vazio
        {
            if (precoCusto.Text != string.Empty)
            {
                precoCusto.Text = $"{Convert.ToDecimal(precoCusto.Text):f2}";
            }
        }
        private void PrecoFinal_(object sender, EventArgs e) //Vai executar o calculo de valor final quando clicar na textbox
        {
            PrecoFinal(sender, e);
        }
        private void buttonAtualizarTable_Click(object sender, EventArgs e) //Atualiza a tabela de fornecedores
        {
            AddTable();
        }
        private void buttonGravar_Click(object sender, EventArgs e) //Grava o item
        {
            //Verifica os parametros
            if (!string.IsNullOrEmpty(nomeItem.Text) && (!string.IsNullOrEmpty(codigoBarras.Text) && (!string.IsNullOrEmpty(comboStatus.Text) && (!string.IsNullOrEmpty(selectFornecedor.Text)) && (!string.IsNullOrEmpty(comboUMed.Text)) && (!string.IsNullOrEmpty(quantItem.Text)) && (!string.IsNullOrEmpty(precoFinal.Text)))))
            {
                if (db.AntiCopy("id", "itens_base", id_item.ToString()) == true)
                {
                    cad.CadastraItem(id_fornecedor, codigoBarras.Text, nomeItem.Text, comboStatus.Text, descItem.Text, comboUMed.Text, Convert.ToInt32(quantItem.Text), Convert.ToDecimal(precoCusto.Text), Convert.ToDecimal(porcentLucro.Text), (cad.CalculaPrecoFinal(Convert.ToDecimal(precoCusto.Text), (Convert.ToDecimal(porcentLucro.Text)))));
                }
                else
                {
                    cad.EditaItens(id_item, id_fornecedor, codigoBarras.Text, nomeItem.Text.ToString(), comboStatus.Text.ToString(), descItem.Text.ToString(), comboUMed.Text.ToString(), Convert.ToInt32(quantItem.Text), Convert.ToDecimal(precoCusto.Text), Convert.ToDecimal(porcentLucro.Text), (cad.CalculaPrecoFinal(Convert.ToDecimal(precoCusto.Text), (Convert.ToDecimal(porcentLucro.Text)))));
                }
                id_item = 0; //valor redefinido para zero pois caso contrario, um novo item sobreescreve um item j[a registrado
                id_fornecedor = 0;
                ClearCamp(); //Limpa toda interface
                ModifyElements(false); //Bloqueia interface ate que o user escolha o que deve ser feito
            }
            else
            {
                MessageBox.Show("Revise os campos!"); //Ocorre quando ha algum campo vazio
            }
        }
        private void codMaual_Click(object sender, EventArgs e)//habilita ou desabilita o cod de barras manual
        {
            if (codMaual.Checked == true)
            {
                codigoBarras.Enabled = true;
                codigoBarras.Text = string.Empty;
            }
            else
            {
                codigoBarras.Enabled = false;
                codigoBarras.Text = cad.GeraCodBarrar();
                MostrCodBar();
            }
        }
        private void VerificarCod(object sender, EventArgs e)//Assim que se digita o codigo de barras, ele verifica se nao ha outro codigo identico
        {
            if (db.BuscarCodBar(codigoBarras.Text) != true || codigoBarras.Text == string.Empty || codigoBarras.Text.Length < 13)
            {
                codigoBarras.Text = string.Empty;
            }
            else
            {
                MostrCodBar();
            }
        }
        private void MostrCodBar()
        {
            try
            {
                Image varpictureCodBar = Code128Rendering.MakeBarcodeImage(codigoBarras.Text, 3, true);
                pictureCodBar.Image = varpictureCodBar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void ReturnItens(int id_i)
        {
            id_item = id_i;
        }

        private void EditItem(object sender, EventArgs e)
        {
            ModifyElements(true);
            newItem.Enabled = false;
            editarItem.Enabled = false;
            codMaual.Enabled = false;
            TabelaItens itens = new TabelaItens(true); //chama a tabela itens
            itens.AtualizarItens(); //atualiza a tabela antes de abrir
            itens.ShowDialog();
            string r_codbar, name, description, r_und_med, r_name, r_status;
            int r_quant;
            decimal r_pre_c, r_porc_l, r_pre_f;

            //metodo da classe database que retorna os dados dos itens
            db.RetornarItens(id_item, out id_fornecedor, out r_codbar, out name, out description, out r_und_med, out r_quant, out r_pre_c, out r_porc_l, out r_pre_f, out r_name, out r_status);
            if (id_item != 0)
            {
                nomeItem.Text = name;
                descItem.Text = description;
                codigoBarras.Text = r_codbar;
                porcentLucro.Text = r_porc_l.ToString("f2");
                precoCusto.Text = r_pre_c.ToString("f2");
                precoFinal.Text = r_pre_f.ToString("f2");
                comboStatus.Text = r_status;
                comboUMed.Text = r_und_med;
                quantItem.Text = r_quant.ToString();
                selectFornecedor.Text = r_name;
            }
            else
            {
                ModifyElements(false);
                ClearCamp();
            }
            MostrCodBar();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (porcentLucro.Text != string.Empty && precoCusto.Text != string.Empty)
            {
                precoFinal.Text = $"R$ {(cad.CalculaPrecoFinal(Convert.ToDecimal(precoCusto.Text), (Convert.ToDecimal(porcentLucro.Text)))).ToString("f2")}";
            }
            else
            {
                precoFinal.Text = string.Empty;
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            ClearCamp();
            ModifyElements(false);
            newItem.Enabled = true;
            editarItem.Enabled = true;
        }
        #region LimitPropriedades
        private void Qnt_KeyDown(object sender, KeyEventArgs e)
        {
            cnpj.AntiCtrlV(e);
        } //Anti ctrl V
        private void PrecoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            cnpj.AntiCtrlV(e);
        } //Anti ctrl V
        private void Cod_KeyDown(object sender, KeyEventArgs e) //Anti ctrl V
        {
            cnpj.AntiCtrlV(e);
        }
        private void PercentLucro_KeyDown(object sender, KeyEventArgs e)
        {
            cnpj.AntiCtrlV(e);
        } //Anti ctrl V
        private void Cod_KeyPress(object sender, KeyPressEventArgs e) //Somente numeros
        {
            cnpj.SomenteNumeros(e);
        }
        private void Qnt_KeyPress(object sender, KeyPressEventArgs e) //Somente numeros
        {
            cnpj.SomenteNumeros(e);
        }
        private void PrecoCusto_KeyPress(object sender, KeyPressEventArgs e) //Somente numeros
        {
            cnpj.SomenteUmaVirgula(e, precoCusto.Text.ToString());
        }
        private void PercentLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnpj.SomenteUmaVirgula(e, porcentLucro.Text.ToString());
        } //Somente numeros

#endregion
    }

}
