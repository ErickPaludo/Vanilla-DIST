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

namespace Vanilla
{
    public partial class CadastroCd : Form
    {
        private Database db = new Database();
        static private List<LogisticaCD> cdList = new List<LogisticaCD>();
        static private List<RegArmazenagem> reg = new List<RegArmazenagem>();
        static public int num_ruas = 0;
        static public int rua_select = 0;
        static public int id_reg;
        static string codbar_endereco, endereco_formated = string.Empty;
        private string endereco = "C:\\Vanilla\\Codigo_de_barras\\CD";

        public CadastroCd()
        {
            InitializeComponent();
        }
        public void RecebeIdReg(int value)
        {
            id_reg = value;
        }
        #region Cadastro de CD
        public void Obtem(int rua)
        {
            num_ruas = rua;
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
                                    db.GravarCd(Convert.ToInt32(prediobox.Text), Convert.ToInt32(laandares.Text), Convert.ToInt32(minemp.Text), gerador_cd, Convert.ToInt32(textBoxCodReg.Text));
                                }
                            }
                            else
                            {
                                db.GravarCd(Convert.ToInt32(prediobox.Text), Convert.ToInt32(laandares.Text), Convert.ToInt32(minemp.Text), gerador_cd, Convert.ToInt32(textBoxCodReg.Text));
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
                    Homepage home = new Homepage();
                    home.DeslogarUsuario();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }
        public void AtualizaTabelaRuas()
        {
            dataGridruas.Rows.Clear();
            db.RetornoCd(true, 0);
            if (num_ruas != 0)
            {
                for (int i = 1; i <= num_ruas; i++)
                {
                    dataGridruas.Rows.Add(i.ToString());
                }
            }
            num_ruas = 0;
        }
        private void SelecionaRua(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                rua_select = Convert.ToInt32(dataGridruas.Rows[e.RowIndex].Cells[0].Value);
                dataGridimpar.Rows.Clear();
                dataGridpar.Rows.Clear();
                rua_select = Convert.ToInt32(dataGridruas.Rows[e.RowIndex].Cells[0].Value);
                db.RetornoCd(false, rua_select);
                foreach (LogisticaCD obj in cdList)
                {
                    if (obj.Id_predio % 2 == 0)
                    {
                        dataGridpar.Rows.Add($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}", obj.Name);
                    }
                    else
                    {
                        dataGridimpar.Rows.Add($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}", obj.Name);
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
                MostrCodBar(rua, predio, la);
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
                MostrCodBar(rua, predio, la);
            }
        }
        private void MostrCodBar(int rua, int predio, int la)
        {
            try
            {
                string codbar = string.Empty;
                db.RetornoCd(false, rua_select);

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
        private void GerarPDF()
        {
            try
            {

                if (rua_select != 0)
                {
                    // Criar um documento PDF
                    iTextSharp.text.Document document = new iTextSharp.text.Document();

                    // Criar um objeto MemoryStream para armazenar o conteúdo do PDF
                    MemoryStream ms = new MemoryStream();

                    // Criar um escritor PDF
                    PdfWriter writer = PdfWriter.GetInstance(document, ms);

                    // Abrir o documento para escrita
                    document.Open();

                    List<LogisticaCD> codigosDeBarras = new List<LogisticaCD>();
                    db.RetornoCd(false, rua_select);
                    foreach (LogisticaCD obj in cdList)
                    {
                        codigosDeBarras.Add(new LogisticaCD(obj.Id_rua, obj.Id_predio, obj.Id_la, obj.Cod_bar));
                    }

                    int contador = 0;

                    foreach (LogisticaCD codigo in codigosDeBarras)
                    {
                        // Gerar o código de barras
                        System.Drawing.Image imagemCodBar = Code128Rendering.MakeBarcodeImage(codigo.Cod_bar, 2, true);

                        // Converter a imagem para um objeto iTextSharp
                        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(imagemCodBar, System.Drawing.Imaging.ImageFormat.Bmp);

                        pdfImage.Alignment = Element.ALIGN_CENTER;

                        // Adicionar a imagem ao documento PDF
                        document.Add(pdfImage);
                        iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph($"{codigo.Cod_bar} | {codigo.Id_rua} - {codigo.Id_predio} - {codigo.Id_la}");

                        paragraph.Alignment = Element.ALIGN_CENTER;

                        document.Add(paragraph);
                        contador++;
                        if (contador == 9) //quantidade de cods por página
                        {
                            document.NewPage();
                            contador = 0;
                        }

                    }

                    // Fechar o documento
                    document.Close();



                    if (!Directory.Exists($"{endereco}\\Rua")) //Verifica se o endereço existe
                    {
                        Directory.CreateDirectory($"{endereco}\\Rua");
                    }
                    // Salvar o conteúdo do documento PDF em um arquivo
                    File.WriteAllBytes($"{endereco}\\Rua\\Endereco_rua_{rua_select}.pdf", ms.ToArray()); //salva o arquivo com o nome da rua
                    Process.Start("explorer.exe", $"{endereco}\\Rua\\Endereco_rua_{rua_select}.pdf"); // abre arquivo
                }
                else
                {
                    MessageBox.Show("Selecione uma Rua!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SalvarCodUnitario(object sender, EventArgs e)
        {
            try
            {

                if (codbar_endereco != string.Empty && endereco_formated != string.Empty)
                {
                    // Criar um documento PDF
                    iTextSharp.text.Document document = new iTextSharp.text.Document();

                    // Criar um objeto MemoryStream para armazenar o conteúdo do PDF
                    MemoryStream ms = new MemoryStream();

                    // Criar um escritor PDF
                    PdfWriter writer = PdfWriter.GetInstance(document, ms);

                    // Abrir o documento para escrita
                    document.Open();


                    // Gerar o código de barras
                    System.Drawing.Image imagemCodBar = Code128Rendering.MakeBarcodeImage(codbar_endereco, 2, true);

                    // Converter a imagem para um objeto iTextSharp
                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(imagemCodBar, System.Drawing.Imaging.ImageFormat.Bmp);

                    pdfImage.Alignment = Element.ALIGN_CENTER;

                    // Adicionar a imagem ao documento PDF
                    document.Add(pdfImage);
                    iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph($"{codbar_endereco} | {endereco_formated}");

                    paragraph.Alignment = Element.ALIGN_CENTER;

                    document.Add(paragraph);

                    // Fechar o documento
                    document.Close();

                    if (!Directory.Exists($"{endereco}\\Predio")) //Verifica se o endereço existe
                    {
                        Directory.CreateDirectory($"{endereco}\\Predio");
                    }
                    // Salvar o conteúdo do documento PDF em um arquivo
                    File.WriteAllBytes($"{endereco}\\Predio\\Endereco_{endereco_formated}.pdf", ms.ToArray()); //salva o arquivo com o nome da rua
                    Process.Start("explorer.exe", $"{endereco}\\Predio\\Endereco_{endereco_formated}.pdf"); // abre arquivo
                }
                else
                {
                    MessageBox.Show("Selecione um Prédio!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxCodReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util util = new Util();
            util.SomenteNumeros(e);
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
                    rua_select = Convert.ToInt32(dataGridruas.Rows[e.RowIndex].Cells[0].Value);
                    GerarPDF();
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
            if (!string.IsNullOrEmpty(textBoxNameReg.Text))
            {
                db.GravaReg(textBoxNameReg.Text);
                textBoxNameReg.Text = string.Empty;
                AtualizaReg();
            }
            else
            {
                MessageBox.Show("Preencha o campo 'Nome da Região' para continuar");
            }
        }
        public void AtualizaReg()
        {
            reg.Clear();
            dataGridViewReg.Rows.Clear();
            db.RetornoReg(0);
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


    }
}
