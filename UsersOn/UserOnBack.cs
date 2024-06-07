using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class UserOnBack : UserClass
    {
        private string maquina;
        private string ip;
        private Config config = new Config();          
        private DateTime entrada;  
        public string Maquina {get{return maquina;}set{maquina = value;}}
        public string Ip {get{return ip;}set{ip = value;}}
        public DateTime Entrada {get{return entrada;}set{entrada = value;}}

        public UserOnBack()
        {
        }

        public UserOnBack(int id,string user,string maquina, string ip, DateTime entrada) : base(id,user)
        {
            this.maquina = maquina;
            this.ip = ip;
            this.entrada = entrada;
        }

        public void ChamaView() //SELECT GERAL
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"Select * From view_users_logados", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {                              
                                    UserOn user = new UserOn();
                                    user.AddNaLista(Convert.ToInt32(reader["id"]), reader["login"].ToString(), reader["hostname"].ToString(), reader["ip"].ToString(), Convert.ToDateTime(reader["acess"]));
                            }
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
}
