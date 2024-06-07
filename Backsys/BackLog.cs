using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla.Backsys
{
    public class BackLog : UserClass
    {
        private int id_log;
        private string log;
        private DateTime date;
        public int Id_log { get { return id_log; } set { id_log = value; } }
        public string Log { get { return log; } set { log = value; } }
        public DateTime Date { get { return date; } set { date = value; } }

        public BackLog()
        {
        }

        public BackLog(int id_log, string log, DateTime date, int id_user, string user) : base(id_user, user)
        {
            this.id_log = id_log;
            this.log = log;
            this.date = date;

        }
        public BackLog(string user) : base(user)
        {

        }
    }
}
