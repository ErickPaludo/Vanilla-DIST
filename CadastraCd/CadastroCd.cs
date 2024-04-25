using Aspose.Words.Shaping;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Aspose.Words;
using System.Diagnostics;
using Vanilla.CadastraCd;
using Vanilla.CadastraCd.CadRegion;

namespace Vanilla
{
    public partial class CadastroCd : Form
    {
        private Database db = new Database();
        private Util util = new Util();
        ClassAddCd cadcd = new ClassAddCd();
        static private List<LogisticaCD> ruasList = new List<LogisticaCD>();
        static private List<LogisticaCD> cdList = new List<LogisticaCD>();
        static private List<LogisticaCD> picking = new List<LogisticaCD>();
        static private List<RegArmazenagem> reg = new List<RegArmazenagem>();
        static public int num_ruas = 0;
        static public int rua_select = 0;
        static public int id_reg;
        static string codbar_endereco, endereco_formated = string.Empty;
      

        public CadastroCd()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            textBoxSubLa.Text = string.Empty;
            checkBoxSubla.Enabled = false;
            prediobox.Text = string.Empty;
            laandares.Text = string.Empty;
            minemp.Text = string.Empty;
            textBoxCodReg.Text = string.Empty;
            textBoxNomeR.Text = string.Empty;
            textBoxCodReg.Text = string.Empty;
        }
        public void RecebeIdReg(int value)
        {
            id_reg = value;
        }
        #region Cadastro de CD
        public void ObtemRuas(int rua, string nome, string status)
        {
            ruasList.Add(new LogisticaCD(rua, nome, status));
        }
        private void GerarCd(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (db.VerificaLogin() == true)
                {
                    if (minemp.Text == string.Empty)
                    {
                        minemp.Text = "0";
                    }
                    if (db.AntiCopy("nome", "vnl_ruas", textBoxNomeR.Text) == true)
                    {
                        int subla;
                        if (textBoxSubLa.Text == string.Empty)
                        {
                            subla = 0;
                        }
                        else
                        {
                            subla = Convert.ToInt32(textBoxSubLa.Text);
                        }
                        if (!string.IsNullOrEmpty(prediobox.Text) && !string.IsNullOrEmpty(laandares.Text) && !string.IsNullOrEmpty(textBoxCodReg.Text) && Convert.ToInt32(minemp.Text) <= Convert.ToInt32(laandares.Text))
                        {
                            if (checkBoxImpar.Checked == true || checkBoxPar.Checked == true)
                            {
                                int gerador_cd; // 0 - full | 1 - lado impar | 2 - lado par                        
                                if (checkBoxImpar.Checked == true && checkBoxPar.Checked == true)
                                {
                                    gerador_cd = 0;
                                }
                                else if (checkBoxImpar.Checked == true)
                                {
                                    gerador_cd = 1;
                                }
                                else
                                {
                                    gerador_cd = 2;
                                }
                                if (Convert.ToInt16(prediobox.Text) >= 100 || Convert.ToInt16(laandares.Text) >= 25)
                                {
                                    DialogResult result = MessageBox.Show("A quantidade de prédios / andares a ser gerada é muito alta, essa operação pode demorar alguns minutos, deseja continuar a operação?", "Excesso de prédios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                    if (result == DialogResult.Yes)
                                    {
                                        cadcd.GravarCd(Convert.ToInt32(prediobox.Text), Convert.ToInt32(laandares.Text), Convert.ToInt32(minemp.Text), gerador_cd, Convert.ToInt32(textBoxCodReg.Text), textBoxNomeR.Text, subla);
                                        Clear();
                                    }
                                }
                                else
                                {
                                    cadcd.GravarCd(Convert.ToInt32(prediobox.Text), Convert.ToInt32(laandares.Text), Convert.ToInt32(minemp.Text), gerador_cd, Convert.ToInt32(textBoxCodReg.Text), textBoxNomeR.Text, subla);
                                    Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Verifique os campos novamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            AtualizaTabelaRuas();
                        }
                        else
                        {
                            MessageBox.Show("Verifique os campos novamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Já existe uma rua cadastrada com este nome!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Homepage home = new Homepage();
                    home.DeslogarUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }
        public void AtualizaTabelaRuas()
        {
            dataGridruas.Rows.Clear();
            cadcd.RetornaRuas();
            foreach (LogisticaCD obj in ruasList)
            {
                dataGridruas.Rows.Add(obj.Id_rua, obj.Nome, obj.Status);
            }
            ruasList.Clear();
        }
        private void SelecionaRua(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                rua_select = Convert.ToInt32(dataGridruas.Rows[e.RowIndex].Cells[0].Value);
                dataGridimpar.Rows.Clear();
                dataGridpar.Rows.Clear();
                rua_select = Convert.ToInt32(dataGridruas.Rows[e.RowIndex].Cells[0].Value);
                cadcd.RetornaRuaUnica(rua_select);
                foreach (LogisticaCD obj in cdList)
                {
                    if (obj.Id_predio % 2 == 0)
                    {
                        dataGridpar.Rows.Add($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}", obj.Item_no_endereco);
                    }
                    else
                    {
                        dataGridimpar.Rows.Add($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}", obj.Item_no_endereco);
                    }
                }
                cdList.Clear();
            }
        }
        public void GravaListEndereco(int rua, int predio, int andar, string codbar, string name_reg)
        {
            cdList.Add(new LogisticaCD(rua, predio, andar, codbar, name_reg));
        }
        private void Atualizar(object sender, EventArgs e)
        {
            dataGridruas.Rows.Clear();
            dataGridruas.Rows.Clear();
            dataGridpar.Rows.Clear();
            dataGridimpar.Rows.Clear();
            AtualizaTabelaRuas();
        }
        private void SelecionaEnderecoPar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                endereco_formated = dataGridpar.Rows[e.RowIndex].Cells[0].Value.ToString();
                string[] numeros = endereco_formated.Split('-');
                int[] num_sep = Array.ConvertAll(numeros, int.Parse);
                int rua = num_sep[0];
                int predio = num_sep[1];
                int la = num_sep[2];
                picking.Clear();
                cadcd.RetornaPredio(predio);
                if (la == 1 && picking.Count() != 0)
                {
                    pictureCodBar.Image = null;
                    dataGridPicking.Rows.Clear();
                    foreach (LogisticaCD obj in picking)
                    {
                        dataGridPicking.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la} - {obj.Id_Subla}", obj.Item_no_endereco);
                    }
                }
                else
                {
                    dataGridPicking.Rows.Clear();
                    MostrCodBar(rua, predio, la, 0);
                }
            }
        }
        private void SelecionaEnderecoImpar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                endereco_formated = dataGridimpar.Rows[e.RowIndex].Cells[0].Value.ToString();
                string[] numeros = endereco_formated.Split('-');
                int[] num_sep = Array.ConvertAll(numeros, int.Parse);
                int rua = num_sep[0];
                int predio = num_sep[1];
                int la = num_sep[2];
                picking.Clear();
                cadcd.RetornaPredio(predio);
                if (la == 1 && picking.Count() != 0)
                {
                    pictureCodBar.Image = null;
                    dataGridPicking.Rows.Clear();
                    foreach (LogisticaCD obj in picking)
                    {
                        dataGridPicking.Rows.Add($"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la} - {obj.Id_Subla}", obj.Item_no_endereco);
                    }
                }
                else
                {
                    dataGridPicking.Rows.Clear();
                    MostrCodBar(rua, predio, la, 0);
                }

            }
        }
        private void MostrCodBar(int rua, int predio, int la, int subla)
        {
            try
            {
                string codbar = string.Empty;

                if (subla == 0)
                {
                    cadcd.RetornaRuaUnica(rua_select);
                    foreach (LogisticaCD obj in cdList)
                    {
                        if (obj.Id_rua == rua && obj.Id_predio == predio && obj.Id_la == la)
                        {
                            codbar = obj.Cod_bar;
                            codbar_endereco = obj.Cod_bar;
                            endereco_formated = $"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la}";
                        }
                    }
                    cdList.Clear();
                }
                else
                {
                    cadcd.RetornaPredio(predio);
                    foreach (LogisticaCD obj in picking)
                    {
                        if (obj.Id_rua == rua && obj.Id_predio == predio && obj.Id_la == la && obj.Id_Subla == subla)
                        {
                            codbar = obj.Cod_bar;
                            codbar_endereco = obj.Cod_bar;
                            endereco_formated = $"{obj.Id_rua} - {obj.Id_predio} - {obj.Id_la} - {obj.Id_Subla}";
                        }
                    }
                    picking.Clear();
                }


                System.Drawing.Image varpictureCodBar = Code128Rendering.MakeBarcodeImage(codbar, 3, true);
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
                            graphics.DrawString($"{codbar_endereco} | {endereco_formated}", font, brush, new PointF(190, varpictureCodBar.Height + 5));
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
        public void PickingAdd(int rua, int predio, int andar, int subla, string codbar, string nome_item)
        {
            picking.Add(new LogisticaCD(rua, predio, andar, subla, codbar, nome_item));
        }

        private void SalvarCodUnitario(object sender, EventArgs e)
        {
            try
            {
                if (codbar_endereco != string.Empty && endereco_formated != string.Empty)
                {
                    SalvarArquivo save = new SalvarArquivo();
                    save.SalvarCodUnitario(codbar_endereco, endereco_formated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Leave(object sender, EventArgs e)
        {
            if (textBoxCodReg.Text == string.Empty)
            {
                textBoxNameRegiao.Text = string.Empty;
            }
            else
            {
                PesquisaReg();
            }
        }
        private void PesquisaReg()
        {
            if (string.IsNullOrEmpty(textBoxCodReg.Text))
            {
                SelecionarReg reg_sep = new SelecionarReg();
                reg_sep.AtualizaReg();
                reg_sep.ShowDialog();
                textBoxCodReg.Text = id_reg.ToString();
            }
            else
            {
                id_reg = Convert.ToInt16(textBoxCodReg.Text);
            }

            AtualizaReg();
            bool validador = false;
            foreach (RegArmazenagem obj in reg)
            {
                if (obj.Id == id_reg)
                {
                    textBoxNameRegiao.Text = obj.Name.ToString();
                    validador = true;
                }
            }
            if (validador != true)
            {
                textBoxCodReg.Text = string.Empty;
                textBoxNameRegiao.Text = string.Empty;
                MessageBox.Show("Região não encontradaa!");
            }
        }
        private void BtnPesquisarRegioes(object sender, EventArgs e)
        {
            PesquisaReg();
        }
        private void dataGridRuas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridruas.Columns[e.ColumnIndex] == dataGridruas.Columns["ColumnBtnSalva"])
            {
                DialogResult result = MessageBox.Show("Sera gerado um relatório em .PDF de todos os endereços desta rua, deseja proceguir?", "Confirmação gerador de PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SalvarArquivo pdf = new SalvarArquivo();
                    pdf.GerarPDF(Convert.ToInt32(dataGridruas.Rows[e.RowIndex].Cells[0].Value));
                }
            }
        }
        private void dataGridRuas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridruas.Rows[e.RowIndex].Cells["ColumnBtnSalva"].ToolTipText = "Gerar PDF com todas as etiquetas de endereço";
        }
        #endregion

        #region Cadastro de Região
        private void RegistraArmz(object sender, EventArgs e)
        {
            if (db.VerificaLogin() == true)
            {
                if (!string.IsNullOrEmpty(Tnamereg.Text))
                {
                    if (db.AntiCopy("nome", "vnl_regiao", Tnamereg.Text) == true)
                    {
                        RegArmazenagem region = new RegArmazenagem();
                        region.GravaReg(Tnamereg.Text);
                        Tnamereg.Text = string.Empty;
                        AtualizaReg();
                    }
                    else
                    {
                        MessageBox.Show("Região já cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o campo 'Nome da Região' para continuar");
                }
            }
            else
            {
                Homepage home = new Homepage();
                home.DeslogarUsuario();
            }
        }
        public void AtualizaReg()
        {
            RegArmazenagem region = new RegArmazenagem();
            reg.Clear();
            dataGridViewReg.Rows.Clear();
            region.RetornoReg(0);
            foreach (RegArmazenagem obj in reg)
            {
                dataGridViewReg.Rows.Add(obj.Id, obj.Name, obj.Status);
            }
        }
        public void GravarListaReg(int id, string name, string status)
        {
            reg.Add(new RegArmazenagem(id, name, status));
        }
        private void AtualizaTable(object sender, EventArgs e)
        {
            AtualizaReg();
        }
        #endregion

        private void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            util.SomenteNumeros(e);
        }

        private void CheckSubLa(object sender, EventArgs e)
        {
            if (checkBoxSubla.Checked)
            {
                labelsubla.Enabled = true;
                textBoxSubLa.Enabled = true;
            }
            else
            {
                labelsubla.Enabled = false;
                textBoxSubLa.Enabled = false;
            }
        }

        private void SelecionaPicking(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                endereco_formated = dataGridPicking.Rows[e.RowIndex].Cells[0].Value.ToString();
                string[] numeros = endereco_formated.Split('-');
                int[] num_sep = Array.ConvertAll(numeros, int.Parse);
                int rua = num_sep[0];
                int predio = num_sep[1];
                int la = num_sep[2];
                int subla = num_sep[3];
                MostrCodBar(rua, predio, la, subla);
            }
        }
    }
}
