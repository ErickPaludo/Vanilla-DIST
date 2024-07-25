using GenCode128;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;

namespace Vanilla
{
    public partial class CadastrarItensFront : Form
    {
        Util cnpj = new Util();
        Database db = new Database();
        CadastrarItens cad = new CadastrarItens();
        private LicencasLogin lic = new LicencasLogin();
        private static List<CadastrarItens> import = new List<CadastrarItens>(); //Lista que vai coletar as informacoes dos fornecedores para adicionar na tabela
        private int id_fornecedor; // Id do fornecedor fica armazenado nessa variavel
        private static int id_item;
        public static int id_endereco = 0;
        public static string endereco;
        public CadastrarItensFront()
        {
            InitializeComponent();
        }
        private void NewItem(object sender, EventArgs e)//Inicia chamado para inserir itens
        {
            ModifyElements(true);
            Snovoitem.Enabled = false;
            SeditarItem.Enabled = false;
            TcodigoBarras.Text = cad.GeraCodBarrar();
            MostrCodBar();
        }
        public void ModifyElements(bool type) //Altera propriedades
        {
            Lselectfornecedor.Text = string.Empty;
            AddTable();
            Snomeitem.Enabled = type;
            Lcodbar.Enabled = type;
            Lstatus.Enabled = type;
            Ldesc.Enabled = type;
            Lfornecedor.Enabled = type;
            Lun.Enabled = type;
            Lprecocusto.Enabled = type;
            Lpreco.Enabled = type;
            Laltura.Enabled = type;
            Lcomprimento.Enabled = type;
            Llargura.Enabled = type;
            Taltura.Enabled = type;
            Tcomprimento.Enabled = type;
            TLargura.Enabled = type;
            comboUMed.Enabled = type;
            buttonAtualizarTable.Enabled = type;
            Lselectfornecedor.Enabled = type;
            LprecoFinal.Enabled = type;
            Llucro.Enabled = type;
            LprecoFinal.Enabled = type;
            TnomeItem.Enabled = type;
            comboStatus.Enabled = type;
            dataGridFornecedores.Enabled = type;
            TdescItem.Enabled = type;
            TprecoCusto.Enabled = type;
            TporcentLucro.Enabled = type;
            newFornec.Enabled = type;
            BGravar.Visible = type;
            CcodMaual.Enabled = type;
            Bcancelar.Enabled = type;
            Bsalvararquivo.Enabled = type;
            Bimprimir.Enabled = type;
            Bselectend.Enabled = type;
            dataGridFornecedores.Enabled = type;
            Lcubagen.Enabled = type;
        }
        public void ClearCamp() //Limpa tudo
        {
            id_endereco = 0;
            dataGridFornecedores.Rows.Clear();
            CcodMaual.Checked = false;
            comboStatus.SelectedIndex = -1;
            comboUMed.SelectedIndex = -1;
            Lselectfornecedor.Text = string.Empty;
            comboStatus.Text = string.Empty;
            comboUMed.Text = string.Empty;
            LprecoFinal.Text = string.Empty;
            LprecoFinal.Text = string.Empty;
            TnomeItem.Text = string.Empty;
            TdescItem.Text = string.Empty;
            TprecoCusto.Text = string.Empty;
            TporcentLucro.Text = string.Empty;
            TcodigoBarras.Text = string.Empty;
            TcodigoBarras.Enabled = false;
            Snovoitem.Enabled = true;
            SeditarItem.Enabled = true;
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
            newcnpj.DesativaEdit();
            newcnpj.ShowDialog();
            AddTable();
        }
        private void SelectFornec(object sender, DataGridViewCellEventArgs e)//seleciona o fornecedor via tabela
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Lselectfornecedor.Text = $"{dataGridFornecedores.Rows[e.RowIndex].Cells[1].Value.ToString()}";
                id_fornecedor = Convert.ToInt32(dataGridFornecedores.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
        private void PadronizaPCusto(object sender, EventArgs e) //Apenas define o valo R$00,00 no custo caso ele seja vazio
        {
            if (TporcentLucro.Text != string.Empty && TprecoCusto.Text != string.Empty)
            {
                LprecoFinal.Text = $"R$ {(cad.CalculaPrecoFinal(Convert.ToDecimal(TprecoCusto.Text), (Convert.ToDecimal(TporcentLucro.Text)))).ToString("f2")}";
            }
            else
            {
                LprecoFinal.Text = string.Empty;
            }
        }
        private void buttonAtualizarTable_Click(object sender, EventArgs e) //Atualiza a tabela de fornecedores
        {
            AddTable();
        }
        private void buttonGravar_Click(object sender, EventArgs e) //Grava o item
        {
            //Verifica os parametros
            if (lic.VerificaLogin() == true)
            {
                if (!string.IsNullOrEmpty(TnomeItem.Text) && (!string.IsNullOrEmpty(TcodigoBarras.Text) && (!string.IsNullOrEmpty(comboStatus.Text) && (!string.IsNullOrEmpty(Lselectfornecedor.Text)) && (!string.IsNullOrEmpty(comboUMed.Text)) && (!string.IsNullOrEmpty(LprecoFinal.Text) && (!string.IsNullOrEmpty(Lcubagen.Text))))))
                {
                    if (db.AntiCopy("id", "vnl_itens", id_item.ToString()) == true)
                    {
                        cad.CadastraItem(id_fornecedor, TcodigoBarras.Text, TnomeItem.Text, comboStatus.Text, TdescItem.Text, comboUMed.Text, Convert.ToDecimal(TprecoCusto.Text), Convert.ToDecimal(TporcentLucro.Text), (cad.CalculaPrecoFinal(Convert.ToDecimal(TprecoCusto.Text), (Convert.ToDecimal(TporcentLucro.Text)))), id_endereco, Convert.ToDouble(Lcubagen.Text), Convert.ToDouble(Taltura.Text), Convert.ToDouble(TLargura.Text), Convert.ToDouble(Tcomprimento.Text));
                    }
                    else
                    {
                        cad.EditaItens(id_item, id_fornecedor, TcodigoBarras.Text, TnomeItem.Text.ToString(), comboStatus.Text.ToString(), TdescItem.Text.ToString(), comboUMed.Text.ToString(), Convert.ToDecimal(TprecoCusto.Text), Convert.ToDecimal(TporcentLucro.Text), (cad.CalculaPrecoFinal(Convert.ToDecimal(TprecoCusto.Text), (Convert.ToDecimal(TporcentLucro.Text)))));
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
            else
            {
             //   VanillaMDI home = new VanillaMDI();
            }
        }
        private void codMaual_Click(object sender, EventArgs e)//habilita ou desabilita o cod de barras manual
        {
            if (CcodMaual.Checked == true)
            {
                TcodigoBarras.Enabled = true;
                TcodigoBarras.Text = string.Empty;
            }
            else
            {
                TcodigoBarras.Enabled = false;
                TcodigoBarras.Text = cad.GeraCodBarrar();
                MostrCodBar();
            }
        }
        private void VerificarCod(object sender, EventArgs e)//Assim que se digita o codigo de barras, ele verifica se nao ha outro codigo identico
        {
            if (db.BuscarCodBar(TcodigoBarras.Text) != true || TcodigoBarras.Text == string.Empty || TcodigoBarras.Text.Length < 13)
            {
                TcodigoBarras.Text = string.Empty;
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
                Image varpictureCodBar = Code128Rendering.MakeBarcodeImage(TcodigoBarras.Text, 3, true);
                pictureCodBar.Image = varpictureCodBar;
                int heightWithText = varpictureCodBar.Height + 30; // Aumente esse valor conforme necessário
                Bitmap bmp = new Bitmap(varpictureCodBar.Width, heightWithText);

                // Adicionar o número do código de barras como texto na imagem
                using (Graphics graphics = Graphics.FromImage(bmp))
                {
                    graphics.DrawImage(varpictureCodBar, 0, 0); // Desenhe a imagem original

                    // Definir fonte e cor do texto
                    using (System.Drawing.Font font = new System.Drawing.Font("Imperial", 12))
                    {
                        using (SolidBrush brush = new SolidBrush(Color.Black))
                        {
                            // Desenhar o número do código de barras
                            graphics.DrawString(TcodigoBarras.Text, font, brush, new PointF(235, varpictureCodBar.Height + 5));
                            // Ajuste as coordenadas conforme necessário para posicionar o texto onde desejar
                        }
                    }
                }
                // Exibir a imagem do código de barras com o número no PictureBox
                pictureCodBar.Image = bmp;
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
            Snovoitem.Enabled = false;
            SeditarItem.Enabled = false;
            CcodMaual.Enabled = false;
            Bselectend.Enabled = false;
            Lcubagen.Enabled = false;
            Taltura.Enabled = false;
            Tcomprimento.Enabled = false;
            TLargura.Enabled = false;
            Lenderecoselecionado.Text = string.Empty;
            TabelaItens itens = new TabelaItens(true); //chama a tabela itens
            itens.AtualizarItens(); //atualiza a tabela antes de abrir
            itens.ShowDialog();


            CadastrarItens r_item;
            r_item = cad.RetornarItens(id_item);
            if (id_item != 0)
            {
                TnomeItem.Text = r_item.Nome_item;
                TdescItem.Text = r_item.Descricao;
                TcodigoBarras.Text = r_item.Codbar;
                TporcentLucro.Text = r_item.Lucro_porcent.ToString("f2");
                TprecoCusto.Text = r_item.Preco_custo.ToString("f2");
                LprecoFinal.Text = r_item.Preco_final.ToString("f2");
                comboStatus.Text = r_item.Status_conv;
                comboUMed.Text = r_item.Unmed;
                Lselectfornecedor.Text = r_item.Nome_f;
                Taltura.Text = r_item.Altura.ToString();
                TLargura.Text = r_item.Largura.ToString();
                Tcomprimento.Text = r_item.Comprimento.ToString();
                Lcubagen.Text = r_item.Cubagem.ToString();
            }
            else
            {
                ModifyElements(false);
                ClearCamp();
            }
            MostrCodBar();
        }


        private void Cancelar(object sender, EventArgs e)
        {
            ClearCamp();
            ModifyElements(false);
            Snovoitem.Enabled = true;
            SeditarItem.Enabled = true;
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
            cnpj.SomenteUmaVirgula(e, TprecoCusto.Text.ToString());
        }
        private void PercentLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnpj.SomenteUmaVirgula(e, TporcentLucro.Text.ToString());
        } //Somente numeros

        #endregion

        private void btnSalvararquivo_Click(object sender, EventArgs e)
        {
            string endereco = "C:\\Vanilla\\Codigo_de_barras\\Itens";

            if (!Directory.Exists(endereco)) //Verifica se o endereço existe
            {
                Directory.CreateDirectory(endereco);
            }

            pictureCodBar.Image.Save(endereco + "\\temp.jpg"); //salva temporariamente em jpg

            var doc = new Document();
            var builder = new DocumentBuilder(doc);

            builder.InsertImage(endereco + "\\temp.jpg");
            doc.Save(endereco + "\\codbar_" + TcodigoBarras.Text + ".pdf");

            if (System.IO.File.Exists(endereco + "\\codbar_" + TcodigoBarras.Text + ".pdf"))
            {
                Process.Start("explorer.exe", $"{endereco}\\codbar_{TcodigoBarras.Text}.pdf");
            }
            File.Delete(endereco + "\\temp.jpg");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (var g = e.Graphics)
            {
                using (var fnt = new System.Drawing.Font("Courier New", 16))
                {
                    g.DrawImage(this.pictureCodBar.Image, 20, 50);
                    var caption = TcodigoBarras.Text;
                    g.DrawString(caption, fnt, Brushes.Black, 130, 110);
                }
            }
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            try
            {
                this.printDocument1.Print();
            }
            catch (Exception ex) { MessageBox.Show($"Ocorreu um erro:\n{ex.Message}"); }
        }

        private void CalculaMetrosCubicos(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Taltura.Text) && !string.IsNullOrEmpty(TLargura.Text) && !string.IsNullOrEmpty(Tcomprimento.Text))
            {
                double cubagem = cad.CalculaMetrosCubicos(Convert.ToDouble(Taltura.Text), Convert.ToDouble(TLargura.Text), Convert.ToDouble(Tcomprimento.Text));

                if (cubagem <= 1.92)
                {
                    Lcubagen.Text = $"{cubagem.ToString("F4")}";
                }
                else
                {
                    MessageBox.Show($"A cubagem do item é maios do que a cubagem padrão do estoque! ({cubagem.ToString("f4")}/1.92)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Taltura.Text = string.Empty;
                    TLargura.Text = string.Empty;
                    Tcomprimento.Text = string.Empty;
                    Lcubagen.Text = string.Empty;
                }


            }
            else
            {
                Lcubagen.Text = string.Empty;
            }
        }

        private void SelectEnd(object sender, EventArgs e)
        {
            TabelaEnderecos tbend = new TabelaEnderecos();
            tbend.ModoDeRetorno(1);
            tbend.ShowDialog();
            Lenderecoselecionado.Text = endereco;
        }

        private void CadastrarItensFront_Load(object sender, EventArgs e)
        {

        }
    }

}
