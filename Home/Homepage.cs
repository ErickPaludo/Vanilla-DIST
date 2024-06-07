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
using Vanilla.StatusCd;

namespace Vanilla
{
    public partial class Homepage : Form
    {
        HomeController controller;
        Util utilitarios = new Util();
        Database db = new Database();
        private LicencasLogin lic = new LicencasLogin();
        public Homepage()
        {
            InitializeComponent();
         //   lic.ValidaLicenca();
            Exibir();
        }
        public Homepage(bool t)
        {
            Exibir();
        }

        #region elements_view
        public void SetController(HomeController controller)
        {
            this.controller = controller;
        }
        public Form Home
        {
            get { return this; }
            set { this.Home = value; }
        }
        public ToolStripMenuItem UserMenu
        {
            get
            {
                return Snameuser;
            }
            set
            {
                Snameuser = value;
            }
        }
        public ToolStripMenuItem UserOn
        {
            get
            {
                return Suseron;
            }
            set
            {
                Suseron = value;
            }
        }
        public ToolStripMenuItem AlterUserAdm
        {
            get
            {
                return Salterauseradm;
            }
            set
            {
                Salterauseradm = value;
            }
        }
        public ToolStripMenuItem AlterUserDefaul
        {
            get
            {
                return Salteraruser;
            }
            set
            {
                Salteraruser = value;
            }
        }
        public ToolStripMenuItem Logoff
        {
            get
            {
                return Slogout;
            }
            set
            {
                Slogout = value;
            }
        }
        public ToolStripMenuItem Sair
        {
            get
            {
                return Sexit;
            }
            set
            {
                Sexit = value;
            }
        }
        public Button CadEmpresas
        {
            get
            {
                return Ccademp;
            }
            set
            {
                Ccademp = value;
            }
        }
        public Button CadItens
        {
            get
            {
                return Bcaditem;
            }
            set
            {
                Bcaditem = value;
            }
        }
        public Button CadUser
        {
            get
            {
                return Badduser;
            }
            set
            {
                Badduser = value;
            }
        }
        public Button LayoutCd
        {
            get
            {
                return Baddcd;
            }
            set
            {
                Baddcd = value;
            }
        }
        public Button ViewLog
        {
            get
            {
                return Blogs;
            }
            set
            {
                Blogs = value;
            }
        }
        public Button ViewEmp
        {
            get
            {
                return Bvisualizaemp;
            }
            set
            {
                Bvisualizaemp = value;
            }
        }
        public Button ViewItens
        {
            get
            {
                return Bvisualizaitens;
            }
            set
            {
                Bvisualizaitens = value;
            }
        }
        public Button ViewEnd
        {
            get
            {
                return Bvisualizacd;
            }
            set
            {
                Bvisualizacd = value;
            }
        }
        public Button CdStatus
        {
            get
            {
                return Bstatuscd;
            }
            set
            {
                Bstatuscd = value;
            }
        }
        public Button InsItem
        {
            get
            {
                return BInsereItem;
            }
            set
            {
                BInsereItem = value;
            }
        }
     
        #endregion

        #region Menu
        private void LOgados(object sender, EventArgs e)
        {
            controller.UsersOn();
        }
        private void AlterarQualqueruser(object sender, EventArgs e)
        {
            controller.AlterUserComplet();
        }
        private void AlterarUser(object sender, EventArgs e)
        {
            controller.AlterUser();
        }
        private void TrocarConta(object sender, EventArgs e)
        {
            controller.TrocarConta();
        }
        private void Exit(object sender, EventArgs e)
        {
            controller.Sair();
        }
        #endregion

        #region Cadastros
        private void StrEmp(object sender, EventArgs e)
        {
            controller.StartCadEmp();
        }
        private void AbrirItem(object sender, EventArgs e)
        {
            controller.StartCadItens();
        }
        private void StrCadUs(object sender, EventArgs e)
        {
            controller.StartCadUser();
        }
        private void AddCd(object sender, EventArgs e)
        {
            controller.StartCadCd();
        }
        #endregion

        #region Visualização
        private void VerLog(object sender, EventArgs e)
        {
            controller.StartViewLogs();
        }
        private void VerEmpresas(object sender, EventArgs e)
        {
            controller.StartViewEmps();
        }
        private void ConsultarItens(object sender, EventArgs e)
        {
            controller.StartViewItens();
        }
        private void AcessaTableCd(object sender, EventArgs e)
        {
            controller.StartViewEnd();
        }
        private void StatusCd(object sender, EventArgs e)
        {
            controller.StartViewCd();
        }
        #endregion

        #region Operações
        private void InserirItens(object sender, EventArgs e)
        {
            controller.StartInsItem();
        }
        #endregion

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

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lic.VerificaLogin() == true)
            {
                db.Deslog(0);
            }
            Environment.Exit(0);
        }

        private void Config_User(object sender, EventArgs e)
        {
            AlterarUserCFront altercomun = new AlterarUserCFront();
            altercomun.ExibirDados();
            altercomun.ShowDialog();
        }

        private void EndereçoBanco(object sender, EventArgs e)
        {
            ConfigBank editbank = new ConfigBank();
            editbank.ShowDialog();
        }

        private void VerSobre(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void ChamaChat(object sender, EventArgs e)
        {
            controller.StartOpenMsg();
        }
    }
}
