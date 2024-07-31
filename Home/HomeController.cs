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
        Database db = new Database();
        private CadastrarItensFront itensForm;
        public HomeController()
        {
        }
        public HomeController(IHomePage viewhome, HomeModel model)
        {
            this.viewhome = viewhome;
            this.model = model;
            viewhome.UserMenu.Text = Util.nome_user;
            viewhome.SetController(this);
        }
        public void Fechar()
        {
            model.Fechar();
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
            altercomun.MdiParent = viewhome.Home;
            altercomun.Show();                    
        }
        public void TrocarConta()
        {
            db.Deslog(Util.id_user);
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
        public void Sair()
        {
            db.Deslog(0);
            Environment.Exit(0);
        }
        public void ConfigBanco()
        {
            BancoView view = new BancoView();
            view.Visible = false;
            ModelBanco model = new ModelBanco();
            ControllerBanco controller = new ControllerBanco(view, model);
            view.MdiParent = viewhome.Home;
            view.Show();

        }
        public void AbrirSobre()
        {
            Sobre sobre = new Sobre();
            sobre.MdiParent = viewhome.Home;
            sobre.Show();
        }

        #endregion

        #region Cadastros
        public void StartCadEmp()
        {
            CadastraCNPJ emp = new CadastraCNPJ();
            viewhome.CadEmpresas.Enabled = false;

            model.AddJanela("Cadastra Empresa");

            emp.MdiParent = viewhome.Home;
            emp.Show();
            viewhome.Home.WindowState = FormWindowState.Maximized;
            emp.WindowState = FormWindowState.Normal; // Define o estado da janela como normal

            emp.FormClosed += (s, args) =>
            {
                viewhome.CadEmpresas.Enabled = true;
            };

        }
        public void StartCadItens()
        {
            CadastrarItensFront cadastrarItensFront = new CadastrarItensFront();
            viewhome.CadItens.Enabled = false;
            cadastrarItensFront.MdiParent = viewhome.Home;
            cadastrarItensFront.Show();
            cadastrarItensFront.FormClosed += (s, args) =>
            {
                viewhome.CadItens.Enabled = true;
            };

        }
        public void StartCadUser()
        {
            AdicionarUsuariosFront usuarios = new AdicionarUsuariosFront();
            viewhome.CadUser.Enabled = false;
            model.AddJanela("Cadastra Usuários");
            usuarios.Show();
            usuarios.FormClosed += (s, args) =>
            {
                viewhome.CadUser.Enabled = true;
            };
        }
        public void StartCadCd()
        {
            CadastroCd cd = new CadastroCd();
            viewhome.LayoutCd.Enabled = false;
            model.AddJanela("Cadastro Cd");

            cd.AtualizaTabelaRuas();
            cd.Show();

            cd.FormClosed += (s, args) =>
            {
                viewhome.LayoutCd.Enabled = true;
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
        public void ConsultarPedidos()
        {
            TabelaPedidosView view_tb_pedidos = new TabelaPedidosView();
            view_tb_pedidos.Visible = false;
            ModelTabelaPedidos model_tb_pedidos = new ModelTabelaPedidos();
            ControllerTabelaPedidos controller_tb_pedidos = new ControllerTabelaPedidos(view_tb_pedidos, model_tb_pedidos);
            view_tb_pedidos.MdiParent = viewhome.Home;
            view_tb_pedidos.Show();
            view_tb_pedidos.Show();

        }
        #endregion

        #region Operações
        public void StartInsItem()
        {
            InserirItem inserir = new InserirItem();
            inserir.Atualizar();
            viewhome.InsItem.Enabled = false;


            inserir.FormClosed += (s, args) =>
            {
                viewhome.InsItem.Enabled = true;

            };
            inserir.Show();
        }
        #endregion

        public void StartOpenMsg()
        {
            ViewMsg view = new ViewMsg();
            view.Visible = false;
            ModelMsg model_ = new ModelMsg();
            ControllerMsg controller = new ControllerMsg(view, model_);
            view.Show();
        }

       public void CriarPedido()
        {
            PedidosView view = new PedidosView();
            view.Visible = false; // Inicialmente invisível para evitar flicker
            view.MdiParent = viewhome.Home;
            PedidosModel model = new PedidosModel();
            PedidosController controller = new PedidosController(view, model);

            // Adiciona um manipulador para o evento Load
            view.Load += (s, e) =>
            {
                // Define a localização e o tamanho desejados
                view.Location = new Point(650, 200);
            };

            view.Show();
            view.Visible = true; 
        }

    }
}
