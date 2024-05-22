using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class Mensagem
    {
        private int id;
        private string id_rem,name_r;
        private string msg;
        private DateTime date;
        public int Id
        {
            get
            {
            return id;
            }
            set
            {
            id = value; 
            }
        }
        public string Id_rem
        {
            get
            {
                return id_rem;
            }
            set
            {
                id_rem = value;
            }
        }
        public string Name_r
        {
            get
            {
                return name_r;
            }
            set
            {
                name_r = value;
            }
        }
        public string Msg
        {
            get
            {
                return msg;
            }
            set
            {
                msg = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public Mensagem()
        {
        }

        public Mensagem(string id_rem, string msg)
        {
            this.id_rem = id_rem;

            this.msg = msg;
        }

        public Mensagem(int id, string name_r)
        {
            this.id = id;
            this.name_r = name_r;
        }

        public Mensagem(string id_rem, string msg, DateTime date) : this(id_rem, msg)
        {
            this.date = date;
        }

        public Mensagem(string id_rem, string name_r, string msg, DateTime date) : this(id_rem, name_r)
        {
            this.name_r = name_r;
            this.msg = msg;
            this.date = date;
        }
    }
}
