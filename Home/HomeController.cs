﻿using System;
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
        public void ConfigBanco()
        {
            ConfigBank editbank = new ConfigBank();
            editbank.ShowDialog();
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
            //   viewhome.MsgOpen.Enabled = false;
            ViewMsg view = new ViewMsg();
            view.Visible = false;
            ModelMsg model_ = new ModelMsg();
            ControllerMsg controller = new ControllerMsg(view, model_);

            view.Show();

            view.FormClosed += (s, args) =>
            {
                //   viewhome.MsgOpen.Enabled = true;

            };
        }

       public void CriarPedido()
        {
            PedidosView view = new PedidosView();
            view.Visible = false;
            view.MdiParent = viewhome.Home;
            PedidosModel model = new PedidosModel();
            PedidosController controller = new PedidosController(view, model);
            view.Show();
        }

    }
}
