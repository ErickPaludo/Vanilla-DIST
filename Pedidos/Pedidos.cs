using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class Pedidos : CadastrarItens
    {
        private int id, id_c, id_t, qtd;
        private bool item_disp;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Id_c
        {
            get { return id_c; }
            set { id_c = value; }
        }
        public int Id_t
        {
            get { return id_t; }
            set { id_t = value; }
        }
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
        public bool ItemDisp { get { return item_disp; } set { item_disp = value; } }

        public Pedidos()
        {
        }

        public Pedidos(int id_c, int id_t)
        {
            this.id_c = id_c;
            this.id_t = id_t;
        }

        public Pedidos(int id_i, string nome, int qtd,bool item_disp) : base(nome, id_i)
        {
            this.qtd = qtd;
            this.item_disp = item_disp;
        }
    }
}
