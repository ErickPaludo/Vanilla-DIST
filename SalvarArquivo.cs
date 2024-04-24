using GenCode128;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using static Org.BouncyCastle.Math.EC.ECCurve;
using Newtonsoft.Json.Linq;

namespace Vanilla
{
    public class SalvarArquivo
    {
        Config config = new Config();
        static private List<LogisticaCD> cdList = new List<LogisticaCD>();
        static private List<LogisticaCD> picking = new List<LogisticaCD>();
        private string endereco = "C:\\Vanilla\\Codigo_de_barras\\CD";
        public void GravaListEndereco(int rua, int predio, int andar, string codbar)
        {
            cdList.Add(new LogisticaCD(rua, predio, andar, codbar));
        }
        public void PickingAdd(int rua, int predio, int andar, int subla, string codbar, string nome_item)
        {
            picking.Add(new LogisticaCD(rua, predio, andar, subla, codbar, nome_item));
        }
        public void GerarPDF(int rua)
        {
            try
            {
                if (rua != 0)
                {
                    // Criar um documento PDF
                    iTextSharp.text.Document document = new iTextSharp.text.Document();

                    // Criar um objeto MemoryStream para armazenar o conteúdo do PDF
                    MemoryStream ms = new MemoryStream();

                    // Criar um escritor PDF
                    PdfWriter writer = PdfWriter.GetInstance(document, ms);

                    // Abrir o documento para escrita
                    document.Open();

                    RetornaRua(rua);

                    RetornaRuaPicking(rua);

                 

                    int contador = 0;

                    foreach (LogisticaCD codigo in cdList)
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

                    foreach (LogisticaCD codigo in picking)
                    {
                        // Gerar o código de barras
                        System.Drawing.Image imagemCodBar = Code128Rendering.MakeBarcodeImage(codigo.Cod_bar, 2, true);

                        // Converter a imagem para um objeto iTextSharp
                        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(imagemCodBar, System.Drawing.Imaging.ImageFormat.Bmp);

                        pdfImage.Alignment = Element.ALIGN_CENTER;

                        // Adicionar a imagem ao documento PDF
                        document.Add(pdfImage);
                        iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph($"{codigo.Cod_bar} | {codigo.Id_rua} - {codigo.Id_predio} - {codigo.Id_la} - {codigo.Id_Subla}");

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
                    File.WriteAllBytes($"{endereco}\\Rua\\Endereco_rua_{rua}.pdf", ms.ToArray()); //salva o arquivo com o nome da rua
                    Process.Start("explorer.exe", $"{endereco}\\Rua\\Endereco_rua_{rua}.pdf"); // abre arquivo
                    cdList.Clear();
                    picking.Clear();
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
        private void RetornaRua(int rua)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand($"select * from view_enderecos_cd where rua= {rua}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                               GravaListEndereco(Convert.ToInt32(reader["rua"]), Convert.ToInt32(reader["predio"]), Convert.ToInt32(reader["la"]), reader["cod"].ToString());
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void RetornaRuaPicking(int rua)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand($"select * from view_subla where rua= {rua}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                PickingAdd(Convert.ToInt32(reader["rua"]), Convert.ToInt32(reader["predio"]), Convert.ToInt32(reader["la"]), Convert.ToInt32(reader["sub_la"]), reader["cod"].ToString(), reader["item"].ToString());
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SalvarCodUnitario(string codbar_endereco, string endereco_formated)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
