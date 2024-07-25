using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla;

namespace Vanilla
{
    public class ControllerBanco
    {
        IBancoView view;
        ModelBanco model;

        public ControllerBanco(IBancoView view, ModelBanco model)
        {
            this.view = view;
            this.model = model;
            view.SetController(this);
            Atualiza();
        }
        public void GravarEndereco()
        {
            if (!string.IsNullOrEmpty(view.User.Text) && !string.IsNullOrEmpty(view.Pass.Text) && !string.IsNullOrEmpty(view.Connection.Text) && !string.IsNullOrEmpty(view.Port.Text) && !string.IsNullOrEmpty(view.Sid.Text))
            {
                model.GravarEndereco(new BancoOracle(view.User.Text, view.Pass.Text, view.Connection.Text, view.Port.Text, view.Sid.Text));
                MessageBox.Show("Endereço gravado com sucesso!");
                view.Janela.Close();
            }
        }
        public void Atualiza()
        {
            BancoOracle dados = model.RetornaEndereco();
            view.User.Text = dados.User;
            view.Connection.Text = dados.Connection;
            view.Port.Text = dados.Port;
            view.Sid.Text = dados.Sid;
        }
    }
}
