using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vanilla.Backsys;

namespace Vanilla
{
    public partial class Logs : Form
    {
        private Database db = new Database();
        private static List<BackLog> logslist = new List<BackLog>();
        private static List<BackLog> listcombo = new List<BackLog>();
        public Logs()
        {
            InitializeComponent();
        }

        private void AtualizarViaBtn(object sender, EventArgs e)
        {
            AtualizaTable();
        }
        public void AtualizaTable()
        {
            dataGridLog.Rows.Clear();
            logslist.Clear();
            db.RetornaLogs(combouser.Text, camppesq.Text, Convert.ToDateTime(dateinicial.Text), Convert.ToDateTime(datefinal.Text));
            // var listaOrdenada = logslist.OrderBy(item => item.Id_log);
            foreach (BackLog log in logslist.OrderByDescending(item => item.Date))
            {
                dataGridLog.Rows.Add(log.Login, log.Log, log.Date);
            }
        }
        public void DadosnaLista(int id, string log, DateTime date, int id_user, string name_user)
        {
            logslist.Add(new BackLog(id, log, date, id_user, name_user));
        }
        public void AddnoListCombo(string user)//adiciona user no listcomb
        {
            listcombo.Add(new BackLog(user));
        }
        public void ExibirlistComb()//Exibir user no listcomb
        {
            combouser.Items.Add("TODOS");
            combouser.Text = "TODOS";
            foreach (BackLog log in listcombo)
            {
                combouser.Items.Add(log.Login);
            }
        }
        public void LimparCombo()
        {
            listcombo.Clear();
            combouser.Items.Clear();
        }
    }
}
