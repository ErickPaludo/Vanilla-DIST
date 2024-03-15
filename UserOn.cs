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
        static private int id_select;
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
        public void AddNaLista(int id, string user, string host, string ip, DateTime date)
        {
            listuser.Add(new UserOnBack(id, user, host, ip, date));
        }

        private void Despreender(object sender, EventArgs e)
        {
            if (db.VerificaLogin() == true)
            {
                db.Deslog(id_select);
                MessageBox.Show("A sessão do usuário selecionada foi encerrada!");
                AtualizaTable();
                id_select = 0;
                btndesconect.Enabled = false;
            }
            else
            {
                Homepage home = new Homepage();
                home.DeslogarUsuario();
            }
        }

        private void EscolherUser(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) //Está sendo enviada a inscrição estadual para busca de dados (vai ser alterado para cnpj)
            {
                string user = (dataGridLogados.Rows[e.RowIndex].Cells[0].Value).ToString();
                foreach (UserOnBack obj in listuser)
                {
                    if (obj.Login == user)
                    {
                        if (obj.Id != Util.id_user)
                        {
                            id_select = obj.Id;
                            btndesconect.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível encerrar esta sessão!");
                        }

                    }
                }
            }
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
