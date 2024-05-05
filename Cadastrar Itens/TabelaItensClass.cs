using System;
using System.Diagnostics;
using System.IO;
using Aspose.Words.Tables;
using iTextSharp.text;
using iTextSharp.text.pdf;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using Font = iTextSharp.text.Font;

namespace Vanilla
{
    public class TabelaItensClass
    {
       private string pasta = @"C:\Vanilla\temp";
        public void ExportPdf(List<CadastrarItens> itens)
        {
            try
            {

                // Cria um novo documento com orientação paisagem e margens definidas
                Document document = new Document(PageSize.A4);

                string arquivo = $"Itens{DateTime.Now:yyyy-MM-dd}.pdf";

                PdfWriter.GetInstance(document, new FileStream(@$"{pasta}\{arquivo}", FileMode.Create));
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
                Process.Start("explorer.exe", @$"{pasta}\{arquivo}"); 
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

        public void ExportXls(List<CadastrarItens> itens)
        {
            try
            {

                HSSFWorkbook workbook = new HSSFWorkbook();

                ISheet planilha = workbook.CreateSheet("Itens");
                var center = workbook.CreateCellStyle();
                center.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

                planilha.SetColumnWidth(0, 8000);  // Fornecedor
                planilha.SetColumnWidth(1, 20000);  // Nome
                planilha.SetColumnWidth(2, 4000);  // Código de Barras
                planilha.SetColumnWidth(3, 2500);  // Unidade de Medida
                planilha.SetColumnWidth(4, 4000);  // Status
                planilha.SetColumnWidth(5, 4000); // Preço de Custo
                planilha.SetColumnWidth(6, 4000);  // Lucro
                planilha.SetColumnWidth(7, 4000);  // Preço Final

                // Estilo para bordas destacadas
                var borderStyle = workbook.CreateCellStyle();
                borderStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                borderStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                borderStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                borderStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;

                // Estilo para formatação de valores decimais monetários
                var currencyStyle = workbook.CreateCellStyle();
                currencyStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                currencyStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                currencyStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                currencyStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                currencyStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Right;

                // Cria um formato para valores decimais monetários
                var currencyFormat = workbook.CreateDataFormat().GetFormat("[$R$-416]#,##0.00 ");

                // Aplica o formato de moeda às células das colunas 7, 8 e 9
                currencyStyle.DataFormat = currencyFormat;

                // Configura o alinhamento para o cabeçalho
                IRow headerRow = planilha.CreateRow(0);

                headerRow.HeightInPoints = 20;
                for (int i = 0; i < 8; i++)
                {
                    ICell cell = headerRow.CreateCell(i);
                    cell.SetCellValue(GetHeaderName(i));
                    cell.CellStyle = center;
                    cell.CellStyle.BorderTop = borderStyle.BorderTop;
                    cell.CellStyle.BorderBottom = borderStyle.BorderBottom;
                    cell.CellStyle.BorderLeft = borderStyle.BorderLeft;
                    cell.CellStyle.BorderRight = borderStyle.BorderRight;
                }

                for (int i = 0; i < itens.Count; i++)
                {
                    CadastrarItens item = itens[i];
                    IRow dataRow = planilha.CreateRow(i + 1);
                    for (int j = 0; j < 8; j++)
                    {
                        ICell cell = dataRow.CreateCell(j);
                        if (j == 5 || j == 7)
                        {
                            cell.SetCellValue(Convert.ToDouble(GetCellValue(item, j)));
                            cell.CellStyle = currencyStyle; // Aplica o estilo de moeda
                            cell.CellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center; // Centraliza a célula
                        }
                        else
                        {
                            cell.SetCellValue(GetCellValue(item, j).ToString());
                            // Aplica o estilo de centralização para todas as células, exceto para as colunas 7 e 9
                            cell.CellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                        }

                        // Aplica o estilo de borda para todas as células
                        cell.CellStyle.BorderTop = borderStyle.BorderTop;
                        cell.CellStyle.BorderBottom = borderStyle.BorderBottom;
                        cell.CellStyle.BorderLeft = borderStyle.BorderLeft;
                        cell.CellStyle.BorderRight = borderStyle.BorderRight;
                    }
                }

                // Verificar se a pasta existe, senão criar
                if (!Directory.Exists(pasta))
                {
                    try
                    {
                        Directory.CreateDirectory(pasta);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao criar a pasta: {ex.Message}");
                        return; // Encerrar o programa se houver erro ao criar a pasta
                    }
                }


                // Salva o arquivo XLS
                string arquivo = $"Itens{DateTime.Now:yyyy-MM-dd}.xls";

                using (FileStream file = new FileStream(@$"{pasta}\{arquivo}", FileMode.Create))
                {
                    workbook.Write(file);

                    Process.Start(@"C:\Program Files\LibreOffice\program\scalc.exe", @$"{pasta}\{arquivo}");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private string GetHeaderName(int index)
        {
            switch (index)
            {
                case 0:
                    return "Fornecedor";
                case 1:
                    return "Nome";
                case 2:
                    return "Código de Barras";
                case 3:
                    return "Un.Med";
                case 4:
                    return "Status";
                case 5:
                    return "Preço de Custo";
                case 6:
                    return "Lucro";
                case 7:
                    return "Preço Final";
                default:
                    return "";
            }
        }

        private object GetCellValue(CadastrarItens item, int index)
        {
            switch (index)
            {
                case 0:
                    return item.Nome_f;
                case 1:
                    return item.Nome_item;
                case 2:
                    return item.Codbar;
                case 3:
                    return item.Unmed;
                case 4:
                    return item.Status_conv;
                case 5:
                    return item.Preco_custo;
                case 6:
                    return $"{item.Lucro_porcent}%";
                case 7:
                    return item.Preco_final;
                default:
                    return "";
            }
        }
    }
}
