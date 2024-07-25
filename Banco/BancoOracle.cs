using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class BancoOracle
    {
        private string user, pass, connection, port, sid;
        public string User { get { return user; } set { user = value; } }
        public string Pass { get { return pass; } set { pass = value; } }
        public string Connection { get { return connection; } set { connection = value; } }
        public string Port { get { return port; }   set { port = value; } }
        public string Sid { get { return sid; } set { sid = value; } }
        public BancoOracle() { }



        public BancoOracle(string user, string pass, string connection, string port, string sid)
        {
            this.user = user;
            this.pass = pass;
            this.connection = connection;
            this.port = port;
            this.sid = sid;
        }
    }
}
