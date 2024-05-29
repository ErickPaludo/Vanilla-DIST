using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.StatusCd;

namespace Vanilla
{
    public class HomeController
    {
        IHomePage viewhome;
        HomeModel model;
        Database db = new Database();
        public HomeController()
        {
        }
        public HomeController(IHomePage viewhome, HomeModel model)
        {
            this.viewhome = viewhome;
            this.model = model;
            viewhome.SetController(this);
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
            emp.Show();
        }
        public void StartCadItens()
        {
            CadastrarItensFront cadastrarItensFront = new CadastrarItensFront();
            cadastrarItensFront.ShowDialog();
        }
        public void StartCadUser()
        {
            AdicionarUsuariosFront usuarios = new AdicionarUsuariosFront();
            usuarios.ShowDialog();
        }
        public void StartCadCd()
        {
            CadastroCd cd = new CadastroCd();
            cd.AtualizaTabelaRuas();
            cd.Show();
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
            ViewMsg view = new ViewMsg();
            view.Visible = false;
            ModelMsg model = new ModelMsg();
            ControllerMsg controller = new ControllerMsg(view, model);
            view.Show();
        }
        public void Encerramento(int id_tela)
        {
            switch (id_tela)
            {
                case 1:
                    viewhome.MsgOpen.Enabled = true;
                    break;
                default:
                    viewhome.MsgOpen.Enabled = true;
                    break;
            }
        }
        #endregion

        public void StartOpenMsg()
        {
            viewhome.MsgOpen.Enabled = false;
            ViewMsg view = new ViewMsg();
            view.Visible = false;
            ModelMsg model = new ModelMsg();
            ControllerMsg controller = new ControllerMsg(view, model);
            view.Show();
        }
    }
}
