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
    public partial class LoginFront : Form
    {
        Config config = new Config();
        Database db = new Database();
        public LoginFront()
        {
            InitializeComponent();
        }

        private void LogarSystem(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (userLogin.Text != string.Empty && passLogin.Text != string.Empty && userLogin.Text.Length >= 3 && passLogin.Text.Length >= 6)
            {            
                bool val = db.Login(userLogin.Text, passLogin.Text);
                if (val == false)
                {
                    passLogin.Text = string.Empty;
                }
                else if (val == true)
                {
                    Homepage home = new Homepage();
                    home.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Campos nulos! Favor verificar!");
            }
            Cursor = Cursors.Default;
        }

        private void VerificarVisibilidadeSenha(object sender, EventArgs e)
        {
            if (checkPass.Checked == false)
            {
                passLogin.UseSystemPasswordChar = true;
            }
            else
            {
                passLogin.UseSystemPasswordChar = false;
            }
        }

        private void GravarConfig(object sender, EventArgs e)
        {
            // config.GravarDados(connect.Text);
        }

        private void LoginFront_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ConfigBanco(object sender, EventArgs e)
        {
            ConfigBank configbank = new ConfigBank();
            configbank.ShowDialog();
        }
    }
}
