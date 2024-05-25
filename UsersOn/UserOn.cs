using Aspose.Words.Tables;
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
        private UserOnBack userOnBack = new UserOnBack();
        static public List<UserOnBack> listuser = new List<UserOnBack>();
        public UserOn()
        {
            InitializeComponent();
        }
        public void AtualizaTable()
        {
            listuser.Clear();
            dataGridLogados.Rows.Clear();
            userOnBack.ChamaView();

            foreach (UserOnBack obj in listuser)
            {
                if (obj.Id != Util.id_user)
                {
                    dataGridLogados.Rows.Add("Deslogar", obj.Login, obj.Maquina, obj.Ip, obj.Entrada);
                }
            }

        }
        public void AddNaLista(int id, string user, string host, string ip, DateTime date)
        {
            listuser.Add(new UserOnBack(id, user, host, ip, date));
        }

        private void Deslogar(int user)
        {
           
                db.Deslog(user);
                MessageBox.Show("A sessão do usuário selecionada foi encerrada!");
                AtualizaTable();
          
        }

        private void Atualize(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) // Verifica se a tecla pressionada é a tecla F5
            {
                AtualizaTable();
            }
        }

        private void dataGridLogados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridLogados.Rows[e.RowIndex].Cells["Deslog"].ToolTipText = "Clique aqui para deslogar o usuário";
        }

        private void dataGridLogados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int validador = 0; //0 - nao encontrado | 1 - desloga | 2 - confirma deslog
            string user = (dataGridLogados.Rows[e.RowIndex].Cells[1].Value).ToString();
            int id_user = 0;
            if (dataGridLogados.Columns[e.ColumnIndex] == dataGridLogados.Columns["Deslog"])
            {
                foreach (UserOnBack obj in listuser) //primeiro for
                {
                    if (obj.Login == user) //encontra usuario
                    {
                        DialogResult result = MessageBox.Show($"O usuário {obj.Login} será desconectado, podendo acarretar na perda de dados da tarefa que estiver sendo executada. \nDeseja continuar?", "Desconectar usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes) //solicita se o usuario quer deslogar mesmo o outro colaborador
                        {
                            validador = 1;
                            id_user = obj.Id;
                        }
                        else
                        {
                            validador = 3;
                        }

                    }
                }
                AtualizaTable();
                if (validador == 1) //desloga colaborador
                {
                    listuser.Clear();
                    userOnBack.ChamaView();
                    foreach (UserOnBack obj2 in listuser) //verifica se o colaborador esta ainda online
                    {
                        if (obj2.Login == user)
                        {
                            validador = 2; //esta online
                            id_user = obj2.Id;
                        }
                    }
                    if (validador == 2) { Deslogar(id_user); }
                    else // nao esta mais online
                    {
                        MessageBox.Show("O usuário não parece estar mais online!");
                        AtualizaTable();
                    }
                }

            }
        }
    }
}
