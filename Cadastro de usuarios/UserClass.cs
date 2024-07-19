using Aspose.Words;
using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Vanilla
{
    public class UserClass
    {
        Util util = new Util();
        Database db = new Database();
        Config config = new Config();
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
        public int Bloq_user { get { return bloq_user; } set { bloq_user = value; } }
        public UserClass() { }

        public UserClass(string login)
        {
            this.login = login;
        }

        public UserClass(int id, string name, string cpf, string email, string tel, string tel2, string perm, string status_conv, string login, string password, int bloq_user)
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

        public UserClass(string email, string tel, string tel2, string login, string password)
        {
            this.email = email;
            this.tel = tel;
            this.tel2 = tel2;
            this.login = login;
            this.password = password;
        }

        public UserClass(int id, string perm, int status, string login, string password, int bloq_user, string email)
        {
            this.id = id;
            this.perm = perm;
            this.status = status;
            this.login = login;
            this.password = password;
            this.bloq_user = bloq_user;
            this.email = email;
        }

        public UserClass(int id, string login)
        {
            this.id = id;
            this.login = login;
        }

        public void Adduser(string nome, string cpf, string email, string tel, string tel2, string permissao, string status, string user, string pass, bool status_enc_email)//Adiciona usuário ao banco
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    try
                    {
                        connection.Open();
                        using (OracleCommand cmd = new OracleCommand("vnl_pkg_users.vnl_ins_user", connection))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("v_nome", nome);
                            cmd.Parameters.Add("v_cpf", cpf);
                            cmd.Parameters.Add("v_email", email);
                            cmd.Parameters.Add("v_tel", tel);
                            cmd.Parameters.Add("v_tel_2", tel2);
                            cmd.Parameters.Add("v_perm", permissao);
                            cmd.Parameters.Add("v_status", status);
                            cmd.Parameters.Add("v_login", user);
                            cmd.Parameters.Add("v_pass", pass);

                            cmd.ExecuteNonQuery();
                            db.AddLog($"USUARIO: {user} | TIPO: {permissao} | FOI CADASTRADO COM SUCESSO!", Util.id_user);
                            MessageBox.Show("Usuario adicionado com sucesso!");
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (status_enc_email == true) //verifica se o envio para email está ativo
            {
                util.EnviarEmail("Primeiro acesso!", email, $"Olá, seja bem vindo a equipe!\nSeguem abaixo os dados de acesso ao nosso sistema:\n\nUsuário: {user}\nSenha: {pass}\n\n\nVocê pode alterar a senha do seu perfil assim que acessar o sistema, basta acessa a barra superio do menu inicial do sistema, ir no seu nome de usuário > botão direiro > alterar conta. Após isso, basta sair e entrar novamente no sistema!"); //envia um email avisando sobre o novo cadastro
            }
        }
        public void AlterUserC(string email, string tel, string tel2, string pass) //Altera usuário pelo primário
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        using (OracleCommand cmd = new OracleCommand("vnl_pkg_users.vnl_edit_userc", connection))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                            cmd.Parameters.Add("v_email", OracleDbType.Varchar2).Value = email;
                            cmd.Parameters.Add("v_tel", OracleDbType.Varchar2).Value = tel;
                            cmd.Parameters.Add("v_tel_2", OracleDbType.Varchar2).Value = tel2;
                            cmd.Parameters.Add("v_pass", OracleDbType.Varchar2).Value = pass;
                            cmd.ExecuteNonQuery();
                            db.AddLog($"ALTERAÇÃO REALIZADA COM SUCESSO!", Util.id_user);
                        }

                        MessageBox.Show("Usuário gravado com sucesso!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AlterUserADM(int id, string nome, string email, string tel, string tel2, string login, string pass, string perm, string status)//altera usuário por um terceiro (somente adm)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        using (OracleCommand cmd = new OracleCommand("vnl_pkg_users.vnl_edit_useradm", connection))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                            cmd.Parameters.Add("v_nome", OracleDbType.Varchar2).Value = nome;
                            ;
                            cmd.Parameters.Add("v_email", OracleDbType.Varchar2).Value = email;
                            cmd.Parameters.Add("v_tel", OracleDbType.Varchar2).Value = tel;
                            cmd.Parameters.Add("v_tel_2", OracleDbType.Varchar2).Value = tel2;
                            cmd.Parameters.Add("v_perm", OracleDbType.Varchar2).Value = perm;
                            cmd.Parameters.Add("v_status", OracleDbType.Varchar2).Value = status;
                            cmd.Parameters.Add("v_login", OracleDbType.Varchar2).Value = login;
                            cmd.Parameters.Add("v_pass", OracleDbType.Varchar2).Value = pass;
                            cmd.ExecuteNonQuery();
                            db.AddLog($"USUARIO: {login} | ID: {id} | PERMISSAO: {perm} | STATUS: {status} | FOI EDITADO COM SUCESSO!", Util.id_user);
                        }
                        MessageBox.Show("Usuário gravado com sucesso!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ChamaView()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"Select * From view_users", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AlterarUsersGeral alteruserc = new AlterarUsersGeral();
                                alteruserc.ArmazenaDados(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), reader["cpf"].ToString(), reader["email"].ToString(), reader["tel"].ToString(), reader["tel_2"].ToString(), reader["perm_form"].ToString(), reader["status_format"].ToString(), reader["login"].ToString(), reader["pass"].ToString(), Convert.ToInt32(reader["bloq"]));

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public UserClass RetornarUserC()
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"select b.email,b.tel,b.tel_2,b.pass,b.login from vnl_user b where id = {util.Id_user}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string email = reader["email"].ToString();
                                string tel = reader["tel"].ToString();
                                string tel2 = reader["tel_2"].ToString();
                                string pass = reader["pass"].ToString();
                                string login = reader["login"].ToString();

                                return new UserClass(reader["email"].ToString(), reader["tel"].ToString(), reader["tel_2"].ToString(), reader["login"].ToString(), reader["pass"].ToString());
                            }
                            else
                            {
                                return new UserClass();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new UserClass();
                }
            }
        }
    }
}
