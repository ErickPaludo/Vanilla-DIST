﻿using System;
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
    public partial class AlterarUserCFront : Form
    {
        UserClass clasusuarios = new UserClass();
        Util utiarios = new Util();
        Database db = new Database();
        private string oldemail, user;
        public AlterarUserCFront()
        {
            InitializeComponent();
        }
        public void ExibirDados()
        {
            UserClass user = clasusuarios.RetornarUserC();

            emailBox.Text = user.Email;
            telfBox.Text = user.Tel;
            telfBox2.Text = user.Tel2;
            passBox.Text = user.Password;
            confPassBox.Text = string.Empty;
            oldemail = user.Email;
            this.user = user.Login;
        }

        private void Gravar(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(emailBox.Text) && !string.IsNullOrEmpty(telfBox.Text) && !string.IsNullOrEmpty(passBox.Text) && !string.IsNullOrEmpty(confPassBox.Text))
            {
                if (passBox.Text.Length >= 6 && confPassBox.Text.Length >= 6)
                {
                    if (passBox.Text == confPassBox.Text)
                    {
                        clasusuarios.AlterUserC(emailBox.Text, telfBox.Text, telfBox2.Text, passBox.Text); //Manda as informações para a classe, para fazer a gravação
                        if (encaminhar.Checked == true) //verifica se o envio para email está ativo                        {
                            if (emailBox.Text == oldemail) //Envia email referente a alteração
                            {
                                utiarios.EnviarEmail("Conta alterada!", emailBox.Text, $"Olá, seus dados foram atualizados com sucesso!\nSeguem abaixo os dados de acesso ao nosso sistema:\n\nUsuário: {user}\nSenha: {passBox.Text}");
                            }
                            else //Envia email referente a alteração para antigo e novo email
                            {
                                utiarios.EnviarEmail("Acesso e e-mail alterados!", oldemail, $"Olá, seus dados foram atualizados com sucesso!\nSeguem abaixo os dados de acesso ao nosso sistema:\n\nNovo e-mail: {emailBox.Text}\n\nUsuário: {user}\nSenha: {passBox.Text}");
                                utiarios.EnviarEmail("Conta alterada!", emailBox.Text, $"Olá, seus dados foram atualizados com sucesso!\nSeguem abaixo os dados de acesso ao nosso sistema:\n\nUsuário: {user}\nSenha: {passBox.Text}");
                            }
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
                MessageBox.Show("Favor verificar os campos novamente!");
            }
        }


        private void Cancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidaEmail(object sender, EventArgs e)
        {
            if(utiarios.IsValidEmail(emailBox.Text) == false)
            {
                MessageBox.Show("Email inválido!");
                emailBox.Text = string.Empty;
            }
        }
    }
}

