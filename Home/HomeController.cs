using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vanilla.StatusCd;

namespace Vanilla
{
    public class HomeController
    {
        IHomePage viewhome;
        HomeModel model;
        Form mdiPai;
        Database db = new Database();
        private CadastrarItensFront itensForm;
        public HomeController()
        {
        }
        public HomeController(IHomePage viewhome, HomeModel model, Form mdiPai)
        {
            this.viewhome = viewhome;
            this.model = model;
            viewhome.SetController(this);
            this.mdiPai = mdiPai;
        }

        #region Menu
        public void UsersOn()
        {
            UserOn logados = new UserOn();
            logados.AtualizaTable();
            logados.Show();
        }
        public void AlterUserComplet()
        {
            AlterarUsersGeral users = new AlterarUsersGeral();
            users.ExibirDadosTabela();
            users.ShowDialog();
        }
        public void AlterUser()
        {
            AlterarUserCFront altercomun = new AlterarUserCFront();
            altercomun.ExibirDados();
            altercomun.Show();
        }
        public void TrocarConta()
        {
            db.Deslog(0);
        }
        public void Sair()
        {
            db.Deslog(0);
            Environment.Exit(0);
        }
        #endregion

        #region Cadastros
        public void StartCadEmp()
        {
            CadastraCNPJ emp = new CadastraCNPJ();
            viewhome.CadEmpresas.Enabled = false;
            model.AddJanela("Cadastra Empresa");
            Atualizar();
            emp.MdiParent = mdiPai;
            emp.Show();
            viewhome.Home.WindowState = FormWindowState.Maximized;
            emp.WindowState = FormWindowState.Normal; // Define o estado da janela como normal

            emp.FormClosed += (s, args) =>
            {
                viewhome.CadEmpresas.Enabled = true;
                model.RemJanela("Cadastra Empresa");
                Atualizar();
            };

        }
        public void StartCadItens()
        {
            CadastrarItensFront cadastrarItensFront = new CadastrarItensFront();
            viewhome.CadItens.Enabled = false;
            model.AddJanela("Cadastra Itens");
            Atualizar();
            cadastrarItensFront.Show();
            cadastrarItensFront.FormClosed += (s, args) =>
            {
                viewhome.CadItens.Enabled = true;
                model.RemJanela("Cadastra Itens");
                Atualizar();
            };

        }
        public void StartCadUser()
        {
            AdicionarUsuariosFront usuarios = new AdicionarUsuariosFront();
            viewhome.CadUser.Enabled = false;
            model.AddJanela("Cadastra Usuários");
            Atualizar();
            usuarios.Show();
            usuarios.FormClosed += (s, args) =>
            {
                viewhome.CadUser.Enabled = true;
                model.RemJanela("Cadastra Usuários");
                Atualizar();
            };
        }
        public void StartCadCd()
        {
            CadastroCd cd = new CadastroCd();
            viewhome.LayoutCd.Enabled = false;
            model.AddJanela("Cadastro Cd");
            Atualizar();
            cd.AtualizaTabelaRuas();
            cd.Show();

            cd.FormClosed += (s, args) =>
            {
                viewhome.LayoutCd.Enabled = true;
                model.RemJanela("Cadastro Cd");
                Atualizar();
            };

        }
        #endregion

        #region Visualização

        public void StartViewLogs()
        {
            Logs log = new Logs();
            log.LimparCombo();
            db.RetornaUsuarios();
            log.ExibirlistComb();
            log.Show();
        }
        public void StartViewEmps()
        {
            TabelaEmpresas emp = new TabelaEmpresas(false);
            emp.Carregar();
            emp.Show();
        }
        public void StartViewItens()
        {
            TabelaItens itens = new TabelaItens(false);
            itens.AtualizarItens();
            itens.Show();
        }
        public void StartViewEnd()
        {
            TabelaEnderecos itens = new TabelaEnderecos();
            itens.Show();
        }
        public void StartViewCd()
        {
            StatusdoCd scd = new StatusdoCd();
            scd.Mostrar();
            scd.Show();
        }
        #endregion

        #region Operações
        public void StartInsItem()
        {
            InserirItem inserir = new InserirItem();
            inserir.Atualizar();
            viewhome.InsItem.Enabled = false;
            model.AddJanela("Inserir Item");
            Atualizar();
            inserir.FormClosed += (s, args) =>
            {
                viewhome.InsItem.Enabled = true;
                model.RemJanela("Inserir Item");
                Atualizar();
            };
            inserir.Show();
        }
        #endregion

        public void StartOpenMsg()
        {
            viewhome.MsgOpen.Enabled = false;
            ViewMsg view = new ViewMsg();
            view.Visible = false;
            ModelMsg model_ = new ModelMsg();
            ControllerMsg controller = new ControllerMsg(view, model_);
            model.AddJanela("WalkVan - Msg");
            Atualizar();
            view.Show();

            view.FormClosed += (s, args) =>
            {
                viewhome.MsgOpen.Enabled = true;
                model.RemJanela("WalkVan - Msg");
                Atualizar();
            };
        }

        public void Seleiconajanela(string janela)
        {
            Dictionary<string, string> janelas = new Dictionary<string, string>()
            {
               { "Cadastra Empresa", "CadastraCNPJ" },
               { "Cadastra Itens", "CadastrarItensFront" },
               { "Cadastra Usuários", "AdicionarUsuariosFront" },
               { "Cadastro Cd", "CadastroCd" },
               { "WalkVan - Msg", "ViewMsg" },
                {"Inserir Item", "InserirItem" }
             };

            if (janelas.ContainsKey(janela))
            {
                janela = janelas[janela]; 
            }

            Form form = Application.OpenForms[janela];

            if (form != null)
            {
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal; // Restaura a janela se estiver minimizada
                }
                form.BringToFront(); // Traz a janela para frente
            }
        }
        public void Atualizar()
        {
            viewhome.Janelas.Rows.Clear();
            foreach (string obj in model.LWindows)
            {
                viewhome.Janelas.Rows.Add(obj);
            }
        }
    }
}
