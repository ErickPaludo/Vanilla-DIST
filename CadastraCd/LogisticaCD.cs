using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Backsys;
using Vanilla.CadastraCd;

namespace Vanilla
{
    public class LogisticaCD : RegArmazenagem
    {
        Database db = new Database();
        private BackLog login = new BackLog();
        private int id_rua;
        private int id_predio;
        private int id_la;
        private string codbar;
        

        public LogisticaCD()
        {
        }

        public LogisticaCD(int id_rua, int id_predio, int id_la, string codbar)
        {
            this.id_rua = id_rua;
            this.id_predio = id_predio;
            this.id_la = id_la;
            this.codbar = codbar;
        }

        public LogisticaCD(int id_rua, int id_predio, int id_la, string codbar, string name_reg) : base(name_reg)
        {
            this.id_rua = id_rua;
            this.id_predio = id_predio;
            this.id_la = id_la;
            this.codbar = codbar;
        }

        public LogisticaCD(int id_rua)
        {
            this.id_rua = id_rua;
        }

        public int Id_rua { get { return id_rua; } set {  id_rua = value; } }
        public int Id_predio { get { return id_predio; } set { id_predio = value; } }
        public int Id_la { get { return id_la; } set { id_la = value; } }  
         public string Cod_bar { get {  return codbar; } set { codbar = value; } }  
    }
}
