using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla.CadastraCd.CadRegion
{
    public class RegArmazenagem
    {
        private int id;
        private string name;
        private string status;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Status { get { return status; } set { status = value; } }

        public RegArmazenagem()
        {
        }

        public RegArmazenagem(string name)
        {
            this.name = name;
        }

        public RegArmazenagem(int id, string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }
    }
}
