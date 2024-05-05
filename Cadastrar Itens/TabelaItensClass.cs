using System;
using System.IO;
using Aspose.Words.Tables;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace Vanilla
{
    public class TabelaItensClass : IExportarXLS
    {
        public void Export(List<CadastrarItens> itens)
        {
            try
            {

                // Cria um novo documento com orientação paisagem e margens definidas
                Document document = new Document(PageSize.A4);

                PdfWriter.GetInstance(document, new FileStream("Planilha.pdf", FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(8); // Cria uma tabela com 11 colunas

                // Define a largura de cada coluna
                float[] widths = new float[] { 20f, 20f, 20f, 10f, 10f, 15f, 10f, 15f };
                table.SetWidths(widths);

                int font_size_head = 7;
                int font_size = 8;
                Font font_head = new Font(Font.FontFamily.HELVETICA, font_size_head);
                Font font_data = new Font(Font.FontFamily.HELVETICA, font_size);

                table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                // Adiciona células à tabela
                table.AddCell(GetCell("FORNECEDOR", font_head));
                table.AddCell(GetCell("NOME", font_head));
                table.AddCell(GetCell("CODIGO DE BARRAS", font_head));
                table.AddCell(GetCell("UN.MED", font_head));
                table.AddCell(GetCell("STATUS", font_head));
                table.AddCell(GetCell("PREÇO DE CUSTO", font_head));
                table.AddCell(GetCell("LUCRO", font_head));
                table.AddCell(GetCell("PREÇO FINAL", font_head));
                

                foreach (CadastrarItens item in itens)
                {
                    table.AddCell(GetCell(item.Nome_f, font_data));
                    table.AddCell(GetCell(item.Nome_item, font_data));
                    table.AddCell(GetCell(item.Codbar, font_data));
                    table.AddCell(GetCell(item.Unmed, font_data));
                    table.AddCell(GetCell(item.Status_conv, font_data));
                    table.AddCell(GetCell($"R${item.Preco_custo.ToString("f2")}", font_data));
                    table.AddCell(GetCell($"{item.Lucro_porcent.ToString("f1")}%", font_data));
                    table.AddCell(GetCell($"R${item.Preco_final.ToString("f2")}", font_data));
                }

                document.Add(table);
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); // Exibe uma caixa de diálogo com a mensagem de erro
            }
        }
        public PdfPCell GetCell(string text, Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            return cell;
        }
    }
}
