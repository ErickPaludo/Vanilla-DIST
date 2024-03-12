using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class UserOnBack : AdicionarUsuarios
    {
        private string maquina;
        private string ip;
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
    }
}
