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
    public class TabelaItensClass : IExportarRelatorios
    {
        Util util = new Util();

        private string pasta = @"C:\Vanilla\temp";

        public void ExportPdf()
        {
            try
            {
                TabelaItens list = new TabelaItens();
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


                foreach (CadastrarItens item in list.Itens)
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

        public void ExportXls()
        {
            try
            {
                TabelaItens list = new TabelaItens();
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


                // Configura o alinhamento para o cabeçalho
                IRow headerRow = planilha.CreateRow(0);

                headerRow.HeightInPoints = 20;
                for (int x = 0; x < 8; x++)
                {
                    ICell cell = headerRow.CreateCell(x);
                    cell.SetCellValue(GetHeaderName(x));
                    cell.CellStyle = center;
                    cell.CellStyle.BorderTop = borderStyle.BorderTop;
                    cell.CellStyle.BorderBottom = borderStyle.BorderBottom;
                    cell.CellStyle.BorderLeft = borderStyle.BorderLeft;
                    cell.CellStyle.BorderRight = borderStyle.BorderRight;
                }
                int i = 0; //contador
                foreach (CadastrarItens obj in list.Itens)
                {
                    IRow dataRow = planilha.CreateRow(i + 1);
                    int columnIndex = 0; // Inicialize columnIndex dentro do loop

                    // Defina os valores das células
                    ICell cell = dataRow.CreateCell(columnIndex++);
                    cell.SetCellValue(obj.Nome_f);

                    cell = dataRow.CreateCell(columnIndex++);
                    cell.SetCellValue(obj.Nome_item);

                    cell = dataRow.CreateCell(columnIndex++);
                    cell.SetCellValue(obj.Codbar);

                    cell = dataRow.CreateCell(columnIndex++);
                    cell.SetCellValue(obj.Unmed);

                    cell = dataRow.CreateCell(columnIndex++);
                    cell.SetCellValue(obj.Status_conv);

                    cell = dataRow.CreateCell(columnIndex++);
                    cell.SetCellValue($"R${obj.Preco_custo.ToString("f2")}");

                    cell = dataRow.CreateCell(columnIndex++);
                    cell.SetCellValue($"{obj.Lucro_porcent}%");

                    cell = dataRow.CreateCell(columnIndex++);
                    cell.SetCellValue($"R${obj.Preco_final.ToString("f2")}");


                    for (int j = 0; j < columnIndex; j++)
                    {
                        ICell currentCell = dataRow.GetCell(j) ?? dataRow.CreateCell(j);
                        currentCell.CellStyle = center;
                        currentCell.CellStyle.BorderTop = borderStyle.BorderTop;
                        currentCell.CellStyle.BorderBottom = borderStyle.BorderBottom;
                        currentCell.CellStyle.BorderLeft = borderStyle.BorderLeft;
                        currentCell.CellStyle.BorderRight = borderStyle.BorderRight;
                    }

                    i++; // Incrementa o contador de linhas
                }


                // Salva o arquivo XLS
                string arquivo = $"Itens{DateTime.Now:yyyy-MM-dd}.xls";
                string folder = util.SelectFolder();
                if (!string.IsNullOrEmpty(folder))
                {

                    using (FileStream file = new FileStream(@$"{folder}\{arquivo}", FileMode.Create))
                    {
                        workbook.Write(file);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public string GetHeaderName(int index)
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
      
    }
}

