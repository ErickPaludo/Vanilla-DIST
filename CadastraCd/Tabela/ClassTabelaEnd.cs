using iTextSharp.text.pdf;
using iTextSharp.text;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using Aspose.Words.Tables;
using Font = iTextSharp.text.Font;
using Vanilla.Interfaces;

namespace Vanilla
{
    public class ClassTabelaEnd : IExportarRelatorios
    {
        Config config = new Config();
        Util util = new Util();
        public void RetornaSubLa(int type)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    connection.Open();

                    string query = string.Empty;

                    if (type == 0) //filtra tudo que é picking
                    {
                        query = "select * from view_subla";
                    }
                    else if (type == 1) //filtra o que esta ocupado
                    {
                        query = $"select * from view_subla where ocupado = 'S'";
                    }
                    else //filtra o que esta livre
                    {
                        query = $"select * from view_subla where ocupado = 'N'";
                    }


                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            TabelaEnderecos end = new TabelaEnderecos();
                            while (reader.Read())
                            {
                                end.GravaListPicking(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["rua"]), Convert.ToInt32(reader["predio"]), Convert.ToInt32(reader["la"]), Convert.ToInt32(reader["sub_la"]), reader["regiao"].ToString(), reader["cod"].ToString(), reader["item"].ToString());
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
        public void RetornaEnd(int type, string chave)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    connection.Open();

                    string query = string.Empty;

                    if (type == 0) //filtra tudo que é pulmão
                    {
                        query = "select * from view_enderecos_cd where possui_subla = 'N'";
                    }
                    else if (type == 1) //filtra por codigo de barras ou nome
                    {
                        query = $"select * from view_enderecos_cd e where e.cod like '%{chave}%' or e.nome_item like '%{chave}%' ";
                    }
                    else if (type == 2) //filtra o que esta ocupado
                    {
                        query = $"select * from view_enderecos_cd e where e.possui_subla = 'N' and e.ocupado = 'S'";
                    }
                    else //filtra o que esta livre
                    {
                        query = $"select * from view_enderecos_cd e where e.possui_subla = 'N' and e.ocupado = 'N'";
                    }

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            TabelaEnderecos end = new TabelaEnderecos();
                            while (reader.Read())
                            {

                                end.GravaListEndereco(Convert.ToInt32(reader["id"]),Convert.ToInt32(reader["rua"]), Convert.ToInt32(reader["predio"]), Convert.ToInt32(reader["la"]), reader["cod"].ToString(), reader["nome_regiao"].ToString(), reader["nome_item"].ToString());
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

        private string pasta = @"C:\Vanilla\temp";

        public void ExportPdf()
        {
            try
            {
                TabelaEnderecos list = new TabelaEnderecos();
                
                // Cria um novo documento com orientação paisagem e margens definidas
                Document document = new Document(PageSize.A4);

                string arquivo = $"Itens{DateTime.Now:yyyy-MM-dd}.pdf";

                PdfWriter.GetInstance(document, new FileStream(@$"{pasta}\{arquivo}", FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(4); // Cria uma tabela com 11 colunas

                // Define a largura de cada coluna
                float[] widths = new float[] { 15f, 20f, 15f, 20f };
                table.SetWidths(widths);

                int font_size_head = 7;
                int font_size = 8;
                Font font_head = new Font(Font.FontFamily.HELVETICA, font_size_head);
                Font font_data = new Font(Font.FontFamily.HELVETICA, font_size);

                table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                // Adiciona células à tabela
                table.AddCell(GetCell("ENDEREÇO", font_head));
                table.AddCell(GetCell("CODIGO DE BARRAS", font_head));
                table.AddCell(GetCell("REGIÃO DE SEPARAÇÃO", font_head));
                table.AddCell(GetCell("ITEM", font_head));

                if (list.Picking.Count > 0)
                {
                    foreach (LogisticaCD obj in list.Picking)
                    {
                        table.AddCell(GetCell($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}-{obj.Id_Subla}", font_data));
                        table.AddCell(GetCell(obj.Cod_bar, font_data));
                        table.AddCell(GetCell(obj.Name, font_data));
                        table.AddCell(GetCell(obj.Item_no_endereco, font_data));

                    }                 
                }
                else
                {
                    foreach (LogisticaCD obj in list.CdList)
                    {
                        table.AddCell(GetCell($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}", font_data));
                        table.AddCell(GetCell(obj.Cod_bar, font_data));
                        table.AddCell(GetCell(obj.Name, font_data));
                        table.AddCell(GetCell(obj.Item_no_endereco, font_data));
                    }
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
                TabelaEnderecos list = new TabelaEnderecos();
                HSSFWorkbook workbook = new HSSFWorkbook();

                ISheet planilha = workbook.CreateSheet("Itens");
                var center = workbook.CreateCellStyle();
                center.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

                planilha.SetColumnWidth(0, 5000);  // Endereco
                planilha.SetColumnWidth(1, 7000);  // codbar
                planilha.SetColumnWidth(2, 10000);  // reg sep
                planilha.SetColumnWidth(3, 30000);  // item

                // Estilo para bordas destacadas
                var borderStyle = workbook.CreateCellStyle();
                borderStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                borderStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                borderStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                borderStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;


                // Configura o alinhamento para o cabeçalho
                IRow headerRow = planilha.CreateRow(0);

                headerRow.HeightInPoints = 20;
                for (int x = 0; x < 4; x++)
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

                if (list.Picking.Count > 0)
                {
                    foreach (LogisticaCD obj in list.Picking)
                    {
                        IRow dataRow = planilha.CreateRow(i + 1);
                        int columnIndex = 0; // Inicialize columnIndex dentro do loop

                        // Defina os valores das células
                        ICell cell = dataRow.CreateCell(columnIndex++);
                        cell.SetCellValue($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}-{obj.Id_Subla}");

                        cell = dataRow.CreateCell(columnIndex++);
                        cell.SetCellValue(obj.Cod_bar);

                        cell = dataRow.CreateCell(columnIndex++);
                        cell.SetCellValue(obj.Name);

                        cell = dataRow.CreateCell(columnIndex++);
                        cell.SetCellValue(obj.Item_no_endereco);


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
                }
                else
                {
                    {
                        foreach (LogisticaCD obj in list.CdList)
                        {
                            IRow dataRow = planilha.CreateRow(i + 1);
                            int columnIndex = 0; // Inicialize columnIndex dentro do loop

                            // Defina os valores das células
                            ICell cell = dataRow.CreateCell(columnIndex++);
                            cell.SetCellValue($"{obj.Id_rua}-{obj.Id_predio}-{obj.Id_la}");

                            cell = dataRow.CreateCell(columnIndex++);
                            cell.SetCellValue(obj.Cod_bar);

                            cell = dataRow.CreateCell(columnIndex++);
                            cell.SetCellValue(obj.Name);

                            cell = dataRow.CreateCell(columnIndex++);
                            cell.SetCellValue(obj.Item_no_endereco);


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
                    }
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
                    return "Endereço";
                case 1:
                    return "Codigo de barras";
                case 2:
                    return "Região de separação";
                default:
                    return "Item";
            }
        }


    }
}
