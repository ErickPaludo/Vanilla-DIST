using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Vanilla
{
    public partial class Homepage : Form
    {
        Util utilitarios = new Util();
        Database db = new Database();
        public static bool validador = false;
        private Config _config = new Config();
        public Homepage()
        {
            InitializeComponent();
            Exibir();
        }
        public void ValidaRecebe(bool type)//atribuira true ou false para o validador
        {
            validador = type;
        }
        public void Exibir()
        {
            if (utilitarios.Permissao_user == 0)
            {
                alterarOutrosUsuários.Visible = false;
                containerlabelcad.Visible = false;
                containercad.Visible = false;
                useron.Visible = false;
            }
            else
            {

            }
            nameuser.Text = utilitarios.Nome_user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                CadastraCNPJ transportadora = new CadastraCNPJ();
                transportadora.ShowDialog();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void AbrirItem(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                CadastrarItensFront cadastrarItensFront = new CadastrarItensFront();
                cadastrarItensFront.ShowDialog();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                AdicionarUsuariosFront usuarios = new AdicionarUsuariosFront();
                usuarios.ShowDialog();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Config_User(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                AlterarUserCFront altercomun = new AlterarUserCFront();
                altercomun.ExibirDados();
                altercomun.ShowDialog();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void AlterarUser(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                AlterarUserCFront altercomun = new AlterarUserCFront();
                altercomun.ExibirDados();
                altercomun.ShowDialog();
                if (validador == true)
                {
                    db.Deslog(0);
                    DeslogarUsuario();
                }
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void AddCd(object sender, EventArgs e)
        {
            CadastroCd cd = new CadastroCd();
            cd.ShowDialog();
        }

        private void TrocarConta(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                db.Deslog(0);
                DeslogarUsuario();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void AlterarQualqueruser(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                AlterarUsersGeral users = new AlterarUsersGeral();
                users.ExibirDadosTabela();
                users.ShowDialog();
                if (validador)
                {
                    db.Deslog(0);
                    DeslogarUsuario();
                }
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                db.Deslog(0);
                Application.Exit();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void EndereçoBanco(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                ConfigBank editbank = new ConfigBank();
                editbank.ShowDialog();
                if (validador == true)
                {
                    db.Deslog(0);
                    DeslogarUsuario();
                }
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void VerSobre(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void VerEmpresas(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                Cursor = Cursors.WaitCursor;
                TabelaEmpresas emp = new TabelaEmpresas(false);
                emp.Carregar();
                emp.Show();
                Cursor = Cursors.Default;
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void VerLog(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                Logs log = new Logs();
                log.LimparCombo();
                db.RetornaUsuarios();
                log.ExibirlistComb();
                log.Show();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void ConsultarItens(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                TabelaItens itens = new TabelaItens(false);
                itens.AtualizarItens();
                itens.Show();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void LOgados(object sender, EventArgs e)
        {
            db.VerificaLogin();
            if (validador == false)
            {
                UserOn logados = new UserOn();
                logados.AtualizaTable();
                logados.Show();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void DeslogarUsuario()
        {         
                validador = false;
                this.Hide();
                LoginFront login = new LoginFront();
                login.Show();
        }
    }
}
