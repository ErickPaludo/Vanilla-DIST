using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    internal interface IExportarXLS
    {
         void Export(List<CadastrarItens> itens);
    }
}
