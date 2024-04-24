using Aspose.Words.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Backsys;
using Vanilla.CadastraCd.CadRegion;

namespace Vanilla
{
    public class LogisticaCD : RegArmazenagem
    {
        Database db = new Database();
        private string nome;
        private int id;
        private int id_rua;
        private int id_predio;
        private int id_la;
        private int id_subla;
        private string codbar;
        private string status;
        private string item_no_endereco;

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

        public LogisticaCD(int id_rua, int id_predio, int id_la, string codbar,string item_no_endereco)
        {
            this.id_rua = id_rua;
            this.id_predio = id_predio;
            this.id_la = id_la;
            this.codbar = codbar;
            this.item_no_endereco = item_no_endereco;
        }

        public LogisticaCD(int id_rua, int id_predio, int id_la, string codbar, string name_reg,string item_no_endereco) : base(name_reg)
        {
            this.id_rua = id_rua;
            this.id_predio = id_predio;
            this.id_la = id_la;
            this.codbar = codbar;
            this.item_no_endereco = item_no_endereco;
        }

        public LogisticaCD(int id_rua,string nome,string status)
        {
            this.id_rua = id_rua;
            this.nome = nome;
            this.status = status;
        }
        public LogisticaCD(int id_rua, int id_predio, int id_la, int id_subla,string codbar, string item_no_endereco)
        {
            this.id_rua = id_rua;
            this.id_predio = id_predio;
            this.id_la = id_la;
            this.id_subla = id_subla;
            this.codbar = codbar;
            this.item_no_endereco = item_no_endereco;
        }
        public LogisticaCD(int id,int id_rua, int id_predio, int id_la, int id_subla, string name_reg, string codbar, string item_no_endereco) : base(name_reg)
        {
            this.id = id;
            this.id_rua = id_rua;
            this.id_predio = id_predio;
            this.id_la = id_la;
            this.id_subla = id_subla;
            this.codbar = codbar;
            this.item_no_endereco = item_no_endereco;
        }

        //(rua, predio, andar, subla, name_reg, codbar, nome_item)

        public string Nome{ get { return nome; } set {  nome = value; } }
        public int Id { get { return id; } set {  id= value; } }
        public int Id_rua { get { return id_rua; } set {  id_rua = value; } }
        public int Id_predio { get { return id_predio; } set { id_predio = value; } }
        public int Id_la { get { return id_la; } set { id_la = value; } }  
        public int Id_Subla { get { return id_subla; } set { id_subla = value; } } 
        public string Cod_bar { get {  return codbar; } set { codbar = value; } }  
        public string Status{ get { return status; } set {status = value; } }
        public string Item_no_endereco { get { return item_no_endereco; } set { item_no_endereco = value; } }
    }
}
