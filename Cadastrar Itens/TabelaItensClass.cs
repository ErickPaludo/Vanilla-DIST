using System;
using System.Collections.Generic;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Diagnostics;

namespace Vanilla
{
    public class TabelaItensClass : IExportarXLS
    {

        public void Export(List<CadastrarItens> itens)
        {
            try
            {

                HSSFWorkbook workbook = new HSSFWorkbook();

                ISheet planilha = workbook.CreateSheet("Itens");
                var center = workbook.CreateCellStyle();
                center.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

                planilha.SetColumnWidth(0, 4000);  // ID
                planilha.SetColumnWidth(1, 4000);  // Id Fornecedor
                planilha.SetColumnWidth(2, 8000);  // Fornecedor
                planilha.SetColumnWidth(3, 20000);  // Nome
                planilha.SetColumnWidth(4, 4000);  // Código de Barras
                planilha.SetColumnWidth(5, 2500);  // Unidade de Medida
                planilha.SetColumnWidth(6, 4000);  // Status
                planilha.SetColumnWidth(7, 4000); // Preço de Custo
                planilha.SetColumnWidth(8, 4000);  // Lucro
                planilha.SetColumnWidth(9, 4000);  // Preço Final
                planilha.SetColumnWidth(10, 20000); // Descrição

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
                for (int i = 0; i < 11; i++)
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
                    for (int j = 0; j < 11; j++)
                    {
                        ICell cell = dataRow.CreateCell(j);
                        if (j == 7 || j == 9)
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

                string pasta = @"C:\Vanilla\temp";

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

                using (FileStream file = new FileStream(@$"C:\Vanilla\temp\{arquivo}", FileMode.Create))
                {
                    workbook.Write(file);

                    Process.Start(@"C:\Program Files\LibreOffice\program\scalc.exe", @$"{pasta}\{arquivo}");

                }
            }
        catch(Exception ex){ MessageBox.Show(ex.ToString()); }
        }

        private string GetHeaderName(int index)
        {
            switch (index)
            {
                case 0:
                    return "ID";
                case 1:
                    return "Id Fornecedor";
                case 2:
                    return "Fornecedor";
                case 3:
                    return "Nome";
                case 4:
                    return "Código de Barras";
                case 5:
                    return "Un.Med";
                case 6:
                    return "Status";
                case 7:
                    return "Preço de Custo";
                case 8:
                    return "Lucro";
                case 9:
                    return "Preço Final";
                case 10:
                    return "Descrição";
                default:
                    return "";
            }
        }

        private object GetCellValue(CadastrarItens item, int index)
        {
            switch (index)
            {
                case 0:
                    return item.Id_item.ToString();
                case 1:
                    return item.Id.ToString();
                case 2:
                    return item.Nome_f;
                case 3:
                    return item.Nome_item;
                case 4:
                    return item.Codbar;
                case 5:
                    return item.Unmed;
                case 6:
                    return item.Status_conv;
                case 7:
                    return item.Preco_custo;
                case 8:
                    return $"{item.Lucro_porcent}%";
                case 9:
                    return item.Preco_final;
                case 10:
                    return item.Descricao;
                default:
                    return "";
            }
        }
    }
}
