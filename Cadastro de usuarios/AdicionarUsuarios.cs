using Microsoft.VisualBasic.ApplicationServices;

namespace Vanilla
{
    public class AdicionarUsuarios
    {
        Util util = new Util();
        Database db = new Database();
        private int id;
        private string name;
        private string cpf;
        private string email;
        private string tel;
        private string tel2;
        private string perm;
        private int status;
        private string status_conv;
        private string login;
        private string password;
        private int bloq_user;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Tel { get { return tel; } set { tel = value; } }
        public string Tel2 { get { return tel2; } set { tel2 = value; } }
        public string Perm { get { return perm; } set { perm = value; } }
        public int Status { get { return status; } set { status = value; } }
        public string Status_conv { get { return status_conv; } set { status_conv = value; } }
        public string Login { get { return login; } set { login = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int Bloq_user { get { return bloq_user; } set {  bloq_user = value; } }
        public AdicionarUsuarios() { }

        public AdicionarUsuarios(string login)
        {
            this.login = login;
        }

        public AdicionarUsuarios(int id, string name, string cpf, string email, string tel, string tel2, string perm, string status_conv, string login, string password, int bloq_user)
        {       
            this.id = id;
            this.name = name;
            this.cpf = cpf;
            this.email = email;
            this.tel = tel;
            this.tel2 = tel2;
            this.perm = perm;
            this.status_conv = status_conv;
            this.login = login;
            this.password = password;
            this.bloq_user = bloq_user;
        }

        public AdicionarUsuarios(int id, string perm, int status, string login, string password, int bloq_user,string email)
        {
            this.id = id;
            this.perm = perm;
            this.status = status;
            this.login = login;
            this.password = password;
            this.bloq_user = bloq_user;
            this.email = email;
        }

        public AdicionarUsuarios(int id,string login)
        {
            this.id = id;
            this.login = login;
        }

        public void Adduser(string nome, string cpf, string email, string tel, string tel2, string permissao, string status, string user, string pass,bool status_enc_email)//Adiciona usuário ao banco
        {
            db.GravarnUsers( nome, cpf, email, tel, tel2, permissao, status, user, pass); //chama o metodo para gravar no banco

            if (status_enc_email == true) //verifica se o envio para email está ativo
            {
                util.EnviarEmail("Primeiro acesso!", email, $"Olá, seja bem vindo a equipe!\nSeguem abaixo os dados de acesso ao nosso sistema:\n\nUsuário: {user}\nSenha: {pass}\n\n\nVocê pode alterar a senha do seu perfil assim que acessar o sistema, basta acessa a barra superio do menu inicial do sistema, ir no seu nome de usuário > botão direiro > alterar conta. Após isso, basta sair e entrar novamente no sistema!"); //envia um email avisando sobre o novo cadastro
            }
        }
        public void AlterUserC(string nome, string email, string tel, string tel2, string pass) //Altera usuário pelo primário
        {
            db.EditarUserC(util.Id_user, nome, email, tel, tel2, pass); //chama o metodo para gravar no banco
        }
        public void AlterUserADM(int id, string nome, string email, string tel, string tel2, string login, string pass, string perm, string status)//altera usuário por um terceiro (somente adm)
        {
            db.EditarUserADM(id, nome, email, tel, tel2,login, pass,perm, status); //chama o metodo para gravar no banco
        }

    }
}
