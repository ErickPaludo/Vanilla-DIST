using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Backsys;

namespace Vanilla
{
    public class LogisticaCD
    {
        Database db = new Database();
        private BackLog login = new BackLog();
        private int id_rua;
        private int id_predio;
        private int id_la;
        private string cod_compl;

        public LogisticaCD()
        {
        }

        public LogisticaCD(int id_rua)
        {
            this.id_rua = id_rua;
        }

        public LogisticaCD(int id_rua, int id_predio, int id_la)
        {
            this.id_rua = id_rua;
            this.id_predio = id_predio;
            this.id_la = id_la;
        }

        public int Id_rua { get { return id_rua; } set {  id_rua = value; } }
        public int Id_predio { get { return id_predio; } set { id_predio = value; } }
        public int Id_la { get { return id_la; } set { id_la = value; } }
        public string Cod_compl { get {  return cod_compl; } set { cod_compl = value; } }
        public void GerarCd(int predio_dig, int andar,int minemp)
        {
           /* string log_ini, log_final; //Mensagens para o log
           // int j, rua = db.ReturnId("rua_cd", "vnl_endereco_cd");
          //  int predio = db.ReturnId("id_predio", "vnl_endereco_cd");
            predio_dig = predio_dig + predio;
            rua++;
            if(predio == 0)
            {
                predio=1;
            }
            else
            {
                predio++;
            }
            log_ini = $"{rua}-{predio}-{1}";
            for (int i = predio; i <= predio_dig ; i++)
            {
                db.GravarCd("vnl_endereco_cd", i, rua,minemp);
                for (j = 1; j <= andar; j++)
                {
                    Console.WriteLine($"{i}-{j}");
                    db.Gravarla("vnl_la_cd", j, i,rua);
                }
                j = 1;
            }
            db.GravarLog($"NOVO ENDEREÇO ADICIONADO COM SUCESSO! [ENDEREÇO: {rua}-{predio}-{1} | {rua}-{predio_dig}-{andar}] ");
            MessageBox.Show($"Cd adicionado!");
           */
        }
    }
}
