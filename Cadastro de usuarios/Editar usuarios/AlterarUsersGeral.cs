using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vanilla
{
    public partial class AlterarUsersGeral : Form
    {  
        AdicionarUsuarios clasusuarios = new AdicionarUsuarios();
        Util util = new Util();
        Database db = new Database();
        static private List<AdicionarUsuarios> usuarios = new List<AdicionarUsuarios>();
        static int id_user;
        string cpf, user;
        private string oldemail;
        public AlterarUsersGeral()
        {
            InitializeComponent();
        }
     
        public void ChamarNoBanco()
        {
            usuarios.Clear();
            db.ChamaView("view_users", 1);
        }
        public void ArmazenaDados(int id, string name, string cpf, string email, string tel, string tel2, string perm, string status, string login, string password, int bloq_user)
        {
            usuarios.Add(new AdicionarUsuarios(id, name, cpf, email, tel, tel2, perm, status, login, password, bloq_user));
        }
        public void ExibirDadosTabela()// Puxa dados do banco para tabela
        {
            ChamarNoBanco();
            foreach (AdicionarUsuarios obj in usuarios)
            {
                dataGridUser.Rows.Add(obj.Id, obj.Name, obj.Login, util.FormataCPF(obj.Cpf.ToString()));
            }
        }
        private void ModifyElemnts(bool type) //habilita ou desabilita elementos do form
        {
            nomeCompleto.Enabled = type;
            emailBox.Enabled = type;
            telfBox.Enabled = type;
            telfBox2.Enabled = type;
            comboPerm.Enabled = type;
            comboStatus.Enabled = type;
            userBox.Enabled = type;
            passBox.Enabled = type;
            confPassBox.Enabled = type;
        }
        private void Clear()
        {
            nomeCompleto.Text = string.Empty;
            emailBox.Text = string.Empty;
            telfBox.Text = string.Empty;
            telfBox2.Text = string.Empty;
            comboPerm.Text = string.Empty;
            comboStatus.Text = string.Empty;
            userBox.Text = string.Empty;
            passBox.Text = string.Empty;
            confPassBox.Text = string.Empty;
        }
        private void SelecionaCell(object sender, DataGridViewCellEventArgs e) //Seleciona uma célula da tabela, e exibe todos os dados nos elemento do form
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridUser.Rows[e.RowIndex].Cells[0].Value);
                foreach (AdicionarUsuarios obj in usuarios)
                {
                    if (obj.Id == id)
                    {
                        ModifyElemnts(true); //habilita elementos form
                        oldemail = obj.Email;
                        cpf = obj.Cpf;
                        user = obj.Login;
                        id_user = id;
                        nomeCompleto.Text = obj.Name;
                        emailBox.Text = obj.Email;
                        telfBox.Text = obj.Tel;
                        telfBox2.Text = obj.Tel2;
                        userBox.Text = obj.Login;
                        passBox.Text = obj.Password;
                        confPassBox.Text = obj.Password;
                        comboPerm.Text = obj.Perm;
                        comboStatus.Text = obj.Status_conv;
                        if (util.Id_user == id) // caso o user seja adm, ele não poderá modificar suas propriedades de permissão e status
                        {
                            comboPerm.Enabled = false;
                            comboStatus.Enabled = false;
                        }
                        break;
                    }
                }
            }
        }

        private void Gravar(object sender, EventArgs e) //faz a gravacao dos dados
        {
            if (!string.IsNullOrEmpty(nomeCompleto.Text) && !string.IsNullOrEmpty(emailBox.Text) && !string.IsNullOrEmpty(telfBox.Text) && !string.IsNullOrEmpty(comboPerm.Text) && !string.IsNullOrEmpty(comboStatus.Text) && !string.IsNullOrEmpty(userBox.Text) && !string.IsNullOrEmpty(passBox.Text) && !string.IsNullOrEmpty(confPassBox.Text))
            {
                if (userBox.Text.Length >= 3)
                {

                    if (db.AntiCopy("user", "vnl_user", userBox.Text) == true)
                    {

                        if (passBox.Text.Length >= 6 && confPassBox.Text.Length >= 6)
                        {
                            if (passBox.Text == confPassBox.Text)
                            {
                                ChamaClassUser();
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
                        if (user == userBox.Text)
                        {

                            if (passBox.Text.Length >= 6 && confPassBox.Text.Length >= 6)
                            {
                                if (passBox.Text == confPassBox.Text)
                                {
                                    ChamaClassUser();
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
                            MessageBox.Show("Nome de usuário já está em uso!");
                            userBox.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuário deve conter no mínimo 3 carácteres!");
                }
            }
            else
            {
                MessageBox.Show("Favor verificar os campos novamente!");
            }
        }
        private void ChamaClassUser()//carrega as informacoes do form para classe usuarios
        {
            clasusuarios.AlterUserADM(id_user, nomeCompleto.Text, emailBox.Text, telfBox.Text, telfBox2.Text, userBox.Text, passBox.Text, comboPerm.Text, comboStatus.Text);
            if (encaminhar.Checked == true) //verifica se o envio para email está ativo
            {
                if (comboStatus.Text == "Ativo")
                {
                    if (emailBox.Text == oldemail)
                    {
                        util.EnviarEmail("Conta alterada!", emailBox.Text, $"Olá, seus dados foram atualizados com sucesso!\nSeguem abaixo os dados de acesso ao nosso sistema:\n\nUsuário: {userBox.Text}\nSenha: {passBox.Text} \n\n\nPara  obter mais informações referentes a alteração do seu usuário, favor contatar a administração!");
                    }
                    else
                    {
                        util.EnviarEmail("Acesso e e-mail alterados!", oldemail, $"Olá, seus dados foram atualizados com sucesso!\nSeguem abaixo os dados de acesso ao nosso sistema:\n\nNovo e-mail: {emailBox.Text}\n\nUsuário: {userBox.Text}\nSenha: {passBox.Text}\n\n\nPara obter mais informações referentes a alteração do seu usuário, favor contatar a administração!");
                        util.EnviarEmail("Conta alterada!", emailBox.Text, $"Olá, seus dados foram atualizados com sucesso!\nSeguem abaixo os dados de acesso ao nosso sistema:\n\nUsuário: {userBox.Text}\nSenha: {passBox.Text}\n\n\nPara  obter mais informações referentes a alteração do seu usuário, favor contatar a administração!");
                    }
                }
                else
                {
                    util.EnviarEmail("Alteração de status da Conta!", emailBox.Text, $"Olá, seus dados foram atualizados!\nO usuário {userBox.Text} está com o status {comboStatus.Text}, favor contatar a administração!\n\n\nUsuário: {userBox.Text}\nSenha: {passBox.Text}");
                }
            }
            ModifyElemnts(false);
            Clear();
            if (id_user == util.Id_user)
            {
                Homepage home = new Homepage();
                home.ValidaRecebe(true);
                this.Close();
            }
            else
            {
                dataGridUser.Rows.Clear();
                ExibirDadosTabela();
            }
        }      
    
        private void Cancelar(object sender, EventArgs e)
        {      
            this.Close();
        }
        private void Pesquisar(object sender, EventArgs e) //Pesquisa na lista que veio do banco se existe o  item solicitado (id,nome,codbar)
        {
            dataGridUser.Rows.Clear();

            var itensFiltrados = usuarios
      .Where(item => item.Name.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Cpf.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Login.StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase) || item.Id.ToString().StartsWith(camppesq.Text, StringComparison.OrdinalIgnoreCase))
      .ToList();
            foreach (var obj in itensFiltrados)
            {
                dataGridUser.Rows.Add(obj.Id, obj.Name, obj.Login, util.FormataCPF(obj.Cpf));
            }

        }
        private void Reload(object sender, EventArgs e) //Recarrega a tabela
        {
            dataGridUser.Rows.Clear();
            ExibirDadosTabela();
        }

        private void ValidaEmail(object sender, EventArgs e)
        {
            if (util.IsValidEmail(emailBox.Text) == false)
            {
                MessageBox.Show("Email inválido!");
                emailBox.Text = string.Empty;
            }
        }
    }
}

