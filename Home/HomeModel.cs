using NPOI.SS.Formula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class HomeModel
    {
        private static List<string> listjanelas = new List<string>();
        public List<string> LWindows { get { return listjanelas; } }
        LicencasLogin lic = new LicencasLogin();
        Database db = new Database();
        public void AddJanela(string nome) 
        {
            listjanelas.Add(nome);
        }

        public void Fechar()
        {
         /*   if (lic.VerificaLogin() == true)
            {
                db.Deslog(0);
            }
            Environment.Exit(0);*/
        }
    }
}
