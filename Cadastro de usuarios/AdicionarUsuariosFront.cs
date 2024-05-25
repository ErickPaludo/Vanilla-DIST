using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Vanilla
{
    public partial class AdicionarUsuariosFront : Form
    {
        Database db = new Database();
        Util util = new Util();
        UserClass usuarios = new UserClass();
        public AdicionarUsuariosFront()
        {
            InitializeComponent();
        }

        private void GravarUser(object sender, EventArgs e)
        {
            if (db.VerificaLogin() == true)
            {
                if (!string.IsNullOrEmpty(nomeCompleto.Text) && !string.IsNullOrEmpty(cpfText.Text) && !string.IsNullOrEmpty(emailBox.Text) && !string.IsNullOrEmpty(telfBox.Text) && !string.IsNullOrEmpty(comboPerm.Text) && !string.IsNullOrEmpty(comboStatus.Text) && !string.IsNullOrEmpty(userBox.Text) && !string.IsNullOrEmpty(passBox.Text) && !string.IsNullOrEmpty(confPassBox.Text) && cpfText.Text.Length == 11)
                {
                    if (userBox.Text.Length >= 3)
                    {

                        if (db.AntiCopy("login", "vnl_user", userBox.Text) == true)
                        {
                            if (passBox.Text.Length >= 6 && confPassBox.Text.Length >= 6)
                            {
                                if (passBox.Text == confPassBox.Text)
                                {
                                    usuarios.Adduser(nomeCompleto.Text, cpfText.Text, emailBox.Text, telfBox.Text, telfBox2.Text, comboPerm.Text, comboStatus.Text, userBox.Text, passBox.Text, encaminhar.Checked);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("As senhas não coincidem! Verifique novamente!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("A senha deve conter no mínimo 6 carácteres!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nome de usuário já está em uso!");
                            userBox.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário deve conter no mínimo 3 carácteres!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor verificar os campos novamente!");
                }
            }
            else
            {
                Homepage home = new Homepage();
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {       
            this.Close();
        }

        private void ValidarCPF(object sender, EventArgs e)
        {
            if (db.AntiCopy("cpf", "vnl_user", cpfText.Text) != true)
            {
                MessageBox.Show("Verifique novamente o documento! Pois o mesmo parece já estar registrado!");
                cpfText.Text = string.Empty;
            }
        }

        private void ValidaEmail(object sender, EventArgs e)
        {
            if (util.IsValidEmail(emailBox.Text) == false)
            {
                MessageBox.Show("Email inválido!");
                emailBox.Text = string.Empty;
            }
        }
    }
}
