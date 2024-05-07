using iTextSharp.text.pdf;
using iTextSharp.text;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    internal interface IExportarRelatorios 
    {
         void ExportPdf();

         void ExportXls();

         string GetHeaderName(int index);
    }
}
