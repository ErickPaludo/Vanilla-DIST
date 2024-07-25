
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanilla
{
    public partial class ConfigBank : Form
    {
        Util utilitarios = new Util();
        Config classconfig = new Config();
        Database db = new Database();
        public ConfigBank()
        {
            InitializeComponent();
            enderecoatual.Text = classconfig.Lerdados();
        }

        private void GravarEndereço(object sender, EventArgs e)//Chama a gravação na classe Config
        {
            Cursor = Cursors.WaitCursor;
            if(NoNull() == true)
            {
                classconfig.GravarDados(FormatEndereco(ipbank.Text, portabank.Text, sidbank.Text, userbank.Text, passbank.Text));
                MessageBox.Show("Endereço Redefinido");
                this.Close();
            }
            Cursor = Cursors.Default;
        }

        private bool NoNull()//Verifica se há algum campo nulo
        {
            if (!string.IsNullOrEmpty(userbank.Text) && !string.IsNullOrEmpty(passbank.Text) && !string.IsNullOrEmpty(ipbank.Text) && !string.IsNullOrEmpty(portabank.Text) && !string.IsNullOrEmpty(sidbank.Text) && portabank.Text.Length >= 3)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Campos Inválidos!");
                return false;
            }
        
        }

        public string FormatEndereco(string ip, string porta, string sid, string user, string pass) //Formata os dados
        {
            return $"Data Source={ip}:{porta}/{sid};User Id ={user};Password={pass};";
        }

        private void VerSenha(object sender, EventArgs e)//Checkbox para visualizar senha
        {
            if (checkpass.Checked == false)
            {
                passbank.UseSystemPasswordChar = true;
            }
            else
            {
                passbank.UseSystemPasswordChar = false;
            }
        }

        private void TestarConexao(object sender, EventArgs e)//Testa se a conexão está funcionando
        {
            Cursor = Cursors.WaitCursor;
            if (NoNull() == true)
            {
                if (db.StatusConfigBank(FormatEndereco(ipbank.Text, portabank.Text, sidbank.Text, userbank.Text, passbank.Text)) == true)
                {
                    status.Text = "Conectado";
                    status.ForeColor = Color.Green;
                }
                else
                {
                    status.Text = "Conexão Falhou";
                    status.ForeColor = Color.Red;
                }
            }
            Cursor = Cursors.Default;
        }

        private void SoNumeros(object sender, KeyPressEventArgs e)//Deixa o campo de Porta só digitar numeros
        {
            utilitarios.SomenteNumeros(e);
        }
    }
}
