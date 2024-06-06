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
       LoginClass log = new LoginClass();
        public LoginFront()
        {
            InitializeComponent();
        }

        private void LogarSystem(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (Tuser.Text != string.Empty && Tpass.Text != string.Empty && Tuser.Text.Length >= 3 && Tpass.Text.Length >= 6)
            {
                bool val = log.Login(Tuser.Text, Tpass.Text);
                if (val == false)
                {
                    Tpass.Text = string.Empty;
                }
                else if (val == true)
                {
                //  VanillaMDI vanillaMDI = new VanillaMDI();
              //      vanillaMDI.Show();
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
            if (Csenha.Checked == false)
            {
                Tpass.UseSystemPasswordChar = true;
            }
            else
            {
                Tpass.UseSystemPasswordChar = false;
            }
        }

        private void ConfigBanco(object sender, EventArgs e)
        {
            ConfigBank configbank = new ConfigBank();
            configbank.ShowDialog();
        }

        private void LoginFront_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
