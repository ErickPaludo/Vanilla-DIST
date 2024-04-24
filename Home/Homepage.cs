using Aspose.Words.XAttr;
using Oracle.ManagedDataAccess.Client;
using Org.BouncyCastle.Crypto.Engines;
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
                Salterauseradm.Visible = false;
                //containerlabelcad.Visible = false;
                // containercad.Visible = false;
                Badduser.Visible = false;
                Suseron.Visible = false;
            }
            Snameuser.Text = utilitarios.Nome_user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (db.VerificaLogin() == true)
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
            if (db.VerificaLogin() == true)
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
            if (db.VerificaLogin() == true)
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
            if (db.VerificaLogin() == true)
            {
                db.Deslog(0);
            }
            Environment.Exit(0);
        }

        private void Config_User(object sender, EventArgs e)
        {
            if (db.VerificaLogin() == true)
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
            if (db.VerificaLogin() == true)
            {
                AlterarUserCFront altercomun = new AlterarUserCFront();
                altercomun.ExibirDados();
                altercomun.ShowDialog();
                if (validador == true)
                {
                    validador = false;
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
            cd.AtualizaTabelaRuas();
            cd.ShowDialog();
        }

        private void TrocarConta(object sender, EventArgs e)
        {
            if (db.VerificaLogin() == true)
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
            if (db.VerificaLogin() == true)
            {
                AlterarUsersGeral users = new AlterarUsersGeral();
                users.ExibirDadosTabela();
                users.ShowDialog();
                if (validador)
                {
                    validador = false;
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
            if (db.VerificaLogin() == true)
            {
                db.Deslog(0);
                Environment.Exit(0);
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void EndereçoBanco(object sender, EventArgs e)
        {

            if (db.VerificaLogin() == true)
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
            if (db.VerificaLogin() == true)
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

            if (db.VerificaLogin() == true)
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
            if (db.VerificaLogin() == true)
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
            if (db.VerificaLogin() == true)
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

        public void DeslogarUsuario()
        {
            Type formTypeToKeepOpen = typeof(LoginFront);

            // Crie uma instância do formulário de login
            LoginFront login = new LoginFront();

            // Itere sobre todas as formas abertas
            foreach (Form childForm in Application.OpenForms.Cast<Form>().ToArray())
            {
                // Verifique se a forma não é a forma que você quer manter aberta
                if (childForm.GetType() != formTypeToKeepOpen)
                {
                    // Se não for, feche a forma
                    childForm.Hide();
                }
            }

            // Mostrar o formulário de login
            login.Show();
        }

        private void nameuser_Click(object sender, EventArgs e)
        {
            if (db.VerificaLogin() == false)
            {
                DeslogarUsuario();
            }
        }

        private void AcessaTableCd(object sender, EventArgs e)
        {
            if (db.VerificaLogin() == true)
            {
                TabelaEnderecos itens = new TabelaEnderecos();
                //   itens.Atualizar();
                itens.Show();
            }
            else
            {
                DeslogarUsuario();
            }
        }

        private void InserirItens(object sender, EventArgs e)
        {
            if (db.VerificaLogin() == true)
            {
               InserirItem itens = new InserirItem();
                itens.Atualizar();
                itens.Show();
            }
            else
            {
                DeslogarUsuario();
            }
        }
    }
}
