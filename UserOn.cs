using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanilla
{
    public partial class UserOn : Form
    {
        private Database db = new Database();
        static public List<UserOnBack> listuser = new List<UserOnBack>();
        public UserOn()
        {
            InitializeComponent();
        }
        public void AtualizaTable()
        {
            listuser.Clear();
            dataGridLogados.Rows.Clear();
            db.ChamaView("view_users_logados");
            foreach (UserOnBack obj in listuser)
            {
                dataGridLogados.Rows.Add(obj.Login, obj.Maquina, obj.Ip, obj.Entrada);
            }
        }
        public void AddNaLista(string user, string host, string ip, DateTime date)
        {
            listuser.Add(new UserOnBack(user, host, ip, date));
        }

        private void Atualize(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) // Verifica se a tecla pressionada é a tecla F5
            {
                AtualizaTable();
            }      
        }
    }
}
