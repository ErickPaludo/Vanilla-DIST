using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Reflection.Metadata;
using Newtonsoft.Json.Linq;


namespace Vanilla
{
    public class Database
    {
        #region Cabeçalho
        TabelaEmpresas tableemp;
        TabelaItens itens_table;
        CadastrarItensFront itens;
        Config config = new Config();
        Util util;
        public Database()
        {
        }
        #endregion

        public bool Login(string user, string pass)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_users.vnl_login_user", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_user", OracleDbType.Varchar2).Value = user;
                        cmd.Parameters.Add("v_pass", OracleDbType.Varchar2).Value = pass;
                        cmd.Parameters.Add("v_ip", OracleDbType.Varchar2).Value = Dns.GetHostAddresses(Dns.GetHostName())
                        .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                        cmd.Parameters.Add("v_host", OracleDbType.Varchar2).Value = System.Net.Dns.GetHostName();
                        cmd.Parameters.Add("r_verificador", OracleDbType.Boolean).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("r_msg", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("r_id_user", OracleDbType.Int32).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("r_perm", OracleDbType.Int32).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        string msg = cmd.Parameters["r_msg"].Value.ToString();
                        decimal id = ((OracleDecimal)cmd.Parameters["r_id_user"].Value).Value;
                        bool ver = ((OracleBoolean)cmd.Parameters["r_verificador"].Value).IsTrue;
                        decimal perm = ((OracleDecimal)cmd.Parameters["r_perm"].Value).Value;
                        string name = user;
                        util = new Util();
                        util.DadosUser(Convert.ToInt32(id), Convert.ToInt32(perm), name);
                        if (ver == false)
                        {
                            MessageBox.Show(msg);
                        }
                        else
                        {
                            AddLog("USUÁRIO LOGADO!", Util.id_user); //temporário
                        }
                        return ver;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public void Deslog(int id)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_users.vnl_deslog", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        util = new Util();
                        ;
                        if (id == 0)
                        {
                            id = Util.id_user;
                        }
                        cmd.Parameters.Add("v_id", OracleDbType.Int16).Value = id;
                        cmd.ExecuteNonQuery();
                        AddLog("USUÁRIO DESLOGADO!", id); //temporário
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool StatusConfigBank(string endereco)//Verifica se a conexão com o banco está funcionando corretamente para a configurãção do banco da aplicação
        {
            using (OracleConnection connection = new OracleConnection(endereco))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
        }
        public string SobreSys()
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("select * from vnl_sobre", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string version = reader["version"].ToString();
                                return version;
                            }
                            else
                            {
                                return ""; // Ou qualquer valor padrão, se nenhum resultado for encontrado
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
            }
        }

        #region Criar
        public int GravarnabaseEndereco(string rua, int numero, string comple, string bairro, string cidade, string uf, string cep)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_enderecos.vnl_ins_end", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_rua", OracleDbType.Varchar2).Value = rua;
                        cmd.Parameters.Add("v_numero_end", OracleDbType.Int32).Value = numero;
                        cmd.Parameters.Add("v_complemento", OracleDbType.Varchar2).Value = comple;
                        cmd.Parameters.Add("v_bairro", OracleDbType.Varchar2).Value = bairro;
                        cmd.Parameters.Add("v_cidade", OracleDbType.Varchar2).Value = cidade;
                        cmd.Parameters.Add("v_uf", OracleDbType.Varchar2).Value = uf;
                        cmd.Parameters.Add("v_cep", OracleDbType.Varchar2).Value = cep;
                        cmd.Parameters.Add("r_id", OracleDbType.Int32, ParameterDirection.Output);
                        cmd.ExecuteNonQuery();
                        decimal enderecoId = ((OracleDecimal)cmd.Parameters["r_id"].Value).Value; //ORACCLE insiste em returnar um valor decimal
                        return Convert.ToInt32(enderecoId); //Retorna o id do endereco
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }
        public void GravarTFC(string nomef, string nome, string cnpj, DateTime abertura, DateTime cadastro, string insc_est, string type_cad, string tel, string email, string status, string rua, int numero, string comple, string bairro, string cidade, string uf, string cep) //Gravar TFC (Transportadoras,fornecedores,clientes)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_empresas.vnl_ins_emp", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_nome_emp", nome);
                        cmd.Parameters.Add("v_cnpj", cnpj);
                        cmd.Parameters.Add("v_inc", insc_est);
                        cmd.Parameters.Add("v_tipo_emp", type_cad);
                        cmd.Parameters.Add("v_tel", tel);
                        cmd.Parameters.Add("v_email", email);
                        cmd.Parameters.Add("v_data_abert", abertura);
                        cmd.Parameters.Add("v_date_cad", cadastro);
                        cmd.Parameters.Add("v_status", status);
                        cmd.Parameters.Add("v_name_f", nomef);
                        cmd.Parameters.Add("v_rua", rua);
                        cmd.Parameters.Add("v_numero_end", numero.ToString());
                        cmd.Parameters.Add("v_complemento", comple);
                        cmd.Parameters.Add("v_bairro", bairro);
                        cmd.Parameters.Add("v_cidade", cidade);
                        cmd.Parameters.Add("v_uf", uf);
                        cmd.Parameters.Add("v_cep", cep);
                        cmd.ExecuteNonQuery();
                        AddLog($"EMPRESA {nome} | {cnpj} | TIPO: {type_cad} | FOI CADASTRADA COM SUCESSO!", Util.id_user);
                        MessageBox.Show("Operação Concluída!");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void GravarnUsers(string nome, string cpf, string email, string tel, string tel2, string permissao, string status, string user, string pass)
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
                            AddLog($"USUARIO: {user} | TIPO: {permissao} | FOI CADASTRADO COM SUCESSO!", Util.id_user);
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
        } //gravar na base o usuario
       

        public void AddLog(string msg, int id)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_users.vnl_reg_logs", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_id", OracleDbType.Int16).Value = id;
                        cmd.Parameters.Add("v_msg", OracleDbType.Varchar2).Value = msg;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Editar
        public void EditarTFC(int id, int id_end, string nomef, string nome, string cnpj, DateTime abertura, DateTime cadastro, string insc_est, string type_cad, string tel, string email, string status, string rua, int numero, string comple, string bairro, string cidade, string uf, string cep)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {

                            using (OracleCommand cmd = new OracleCommand("vnl_pkg_empresas.vnl_edit_emp", connection))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.Add("v_id", id);
                                cmd.Parameters.Add("v_id_end", id_end);
                                cmd.Parameters.Add("v_nome_emp", nome);
                                cmd.Parameters.Add("v_inc", insc_est);
                                cmd.Parameters.Add("v_tipo_emp", type_cad);
                                cmd.Parameters.Add("v_tel", tel);
                                cmd.Parameters.Add("v_email", email);
                                cmd.Parameters.Add("v_data_abert", abertura);
                                cmd.Parameters.Add("v_date_cad", cadastro);
                                cmd.Parameters.Add("v_status", status);
                                cmd.Parameters.Add("v_name_f", nomef);
                                cmd.Parameters.Add("v_rua", rua);
                                cmd.Parameters.Add("v_numero_end", numero.ToString());
                                cmd.Parameters.Add("v_complemento", comple);
                                cmd.Parameters.Add("v_bairro", bairro);
                                cmd.Parameters.Add("v_cidade", cidade);
                                cmd.Parameters.Add("v_uf", uf);
                                cmd.Parameters.Add("v_cep", cep);
                                cmd.ExecuteNonQuery();
                                AddLog($"EMPRESA {nome} | {cnpj} | TIPO: {type_cad} | FOI EDITADA COM SUCESSO!", Util.id_user);
                            }
                            MessageBox.Show($"{cnpj} / {nome} foi editado!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditaItens(int id_principal, int id_fornecedor, string cod, string nome, string status, string desc, string undm, decimal preco_c, decimal margem, decimal preco_v)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        using (OracleCommand cmd = new OracleCommand("vnl_pkg_itens.vnl_edit_item", connection))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id_principal;
                            cmd.Parameters.Add("v_id_f", OracleDbType.Int32).Value = id_fornecedor;
                            cmd.Parameters.Add("v_name", OracleDbType.Varchar2).Value = nome;
                            cmd.Parameters.Add("v_status", OracleDbType.Varchar2).Value = status;
                            cmd.Parameters.Add("v_desc", OracleDbType.Varchar2).Value = desc;
                            cmd.Parameters.Add("v_und_med", OracleDbType.Varchar2).Value = undm;
                            cmd.Parameters.Add("v_pre_c", OracleDbType.Decimal).Value = preco_c;
                            cmd.Parameters.Add("v_porc_l", OracleDbType.Decimal).Value = margem;
                            cmd.Parameters.Add("v_pre_f", OracleDbType.Decimal).Value = preco_v;
                            cmd.ExecuteNonQuery();
                            AddLog($"ITEM: {nome} | STATUS: {status} | CODBAR: {cod} | FOI EDITADO COM SUCESSO!", Util.id_user);
                        }
                        MessageBox.Show("Item gravado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarUserC(int id, string nome, string email, string tel, string tel2, string pass)//Usuario do tipo comum pode modificar seu perfil por aqui
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
                            cmd.Parameters.Add("v_nome", OracleDbType.Varchar2).Value = nome;
                            cmd.Parameters.Add("v_email", OracleDbType.Varchar2).Value = email;
                            cmd.Parameters.Add("v_tel", OracleDbType.Varchar2).Value = tel;
                            cmd.Parameters.Add("v_tel_2", OracleDbType.Varchar2).Value = tel2;
                            cmd.Parameters.Add("v_pass", OracleDbType.Varchar2).Value = pass;
                            cmd.ExecuteNonQuery();
                            AddLog($"USUARIO: {nome} | ID: {id} | FOI EDITADO COM SUCESSO!", Util.id_user);
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

        public void EditarEndereco(int id, string rua, int numero, string comple, string bairro, string cidade, string uf, string cep)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        using (OracleCommand cmd = new OracleCommand("vnl_pkg_enderecos.vnl_edit_end", connection))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                            cmd.Parameters.Add("v_rua", OracleDbType.Varchar2).Value = rua;
                            cmd.Parameters.Add("v_numero_end", OracleDbType.Int32).Value = numero;
                            cmd.Parameters.Add("v_complemento", OracleDbType.Varchar2).Value = comple;
                            cmd.Parameters.Add("v_bairro", OracleDbType.Varchar2).Value = bairro;
                            cmd.Parameters.Add("v_cidade", OracleDbType.Varchar2).Value = cidade;
                            cmd.Parameters.Add("v_uf", OracleDbType.Varchar2).Value = uf;
                            cmd.Parameters.Add("v_cep", OracleDbType.Varchar2).Value = cep;
                            cmd.ExecuteNonQuery();
                            AddLog($"O endereço {id} foi alterado!", Util.id_user);
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

        public void EditarUserADM(int id, string nome, string email, string tel, string tel2, string login, string pass, string perm, string status)//Adm muda todos os usuarios
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
                            AddLog($"USUARIO: {login} | ID: {id} | PERMISSAO: {perm} | STATUS: {status} | FOI EDITADO COM SUCESSO!", Util.id_user);
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
        #endregion

        #region Buscadores
        public void ChamaView(string table, int type) //SELECT GERAL
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"Select * From {table}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (table == "view_itens")
                                {
                                    if (type == 1)
                                    {
                                        itens_table = new TabelaItens(true);
                                        itens_table.AddNaTabelaItens(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["id_f"]), reader["nome_fantasia"].ToString(), reader["codbar"].ToString(), reader["nome"].ToString(), reader["descri"].ToString(), reader["und_med"].ToString(), Convert.ToDecimal(reader["preco_custo"]), Convert.ToDecimal(reader["lucro"]), Convert.ToDecimal(reader["preco_final"]), reader["status"].ToString());
                                    }
                                    else
                                    {
                                        InserirItem item = new InserirItem();
                                        item.AddListItems(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), Convert.ToInt32(reader["qtn_total"]));
                                    }
                                }
                                else if (table == "view_users_logados")
                                {
                                    UserOn user = new UserOn();
                                    user.AddNaLista(Convert.ToInt32(reader["id"]), reader["login"].ToString(), reader["hostname"].ToString(), reader["ip"].ToString(), Convert.ToDateTime(reader["acess"]));
                                }
                                else
                                {
                                    AlterarUsersGeral alteruserc = new AlterarUsersGeral();
                                    alteruserc.ArmazenaDados(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), reader["cpf"].ToString(), reader["email"].ToString(), reader["tel"].ToString(), reader["tel_2"].ToString(), reader["perm_form"].ToString(), reader["status_format"].ToString(), reader["login"].ToString(), reader["pass"].ToString(), Convert.ToInt32(reader["bloq"]));
                                }
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

        public void TabelaFornecItem() //Vai coletar alguns dados de endereco para jogar na tabela de fornecedores de itens
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    string query = $"Select * From vnl_cad_empresas where tipo_emp = 1 and status = 0";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string nome = reader["nome_fantasia"].ToString();
                                string cnpj = reader["cnpj"].ToString();
                                itens = new CadastrarItensFront();
                                itens.ImportarDados(id, nome, cnpj); // metodo que adiciona na lista de cadastros fornecedores da tabela
                            }
                        }

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RetornarItens(int id, out int r_id_f, out string r_codbar, out string name, out string description, out string r_und_med, out decimal r_pre_c, out decimal r_porc_l, out decimal r_pre_f, out string r_name, out string r_status)
        {
            r_id_f = 0;
            r_codbar = string.Empty;
            name = string.Empty;
            description = string.Empty;
            r_und_med = string.Empty;
            r_pre_c = 0;
            r_porc_l = 0;
            r_pre_f = 0;
            r_name = string.Empty;
            r_status = string.Empty;

            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"select * from view_itens where id = {id}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                r_id_f = Convert.ToInt32(reader["id_f"]);
                                r_codbar = reader["codbar"].ToString();
                                name = reader["nome"].ToString();
                                description = reader["descri"].ToString();
                                r_und_med = reader["und_med"].ToString();
                                r_pre_c = Convert.ToDecimal(reader["preco_custo"]);
                                r_porc_l = Convert.ToDecimal(reader["lucro"]);
                                r_pre_f = Convert.ToDecimal(reader["preco_final"]);
                                r_name = reader["nome_fantasia"].ToString();
                                r_status = reader["status"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RetornarUserC(int id, out string nome, out string email, out string tel, out string tel_, out string pass, out string login)
        {
            nome = string.Empty;
            email = string.Empty;
            tel = string.Empty;
            tel_ = string.Empty;
            pass = string.Empty;
            login = string.Empty;
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_users.vnl_busc_userc", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                        cmd.Parameters.Add("r_user", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                nome = reader.GetString(0);
                                email = reader.GetString(1);
                                tel = reader.GetString(2);
                                tel_ = !reader.IsDBNull(3) ? reader.GetString(3) : string.Empty;
                                pass = reader.GetString(4);
                                login = reader.GetString(5);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RetornaUsuarios()
        {

            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                Logs log = new Logs();
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("Select login from vnl_user", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                log.AddnoListCombo(reader["login"].ToString());
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RetornaLogs(string user, string ocorrencia, DateTime data_ini, DateTime data_fin)
        {

            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                Logs log = new Logs();
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_prc_filtro_logs", connection))
                    {
                        DateTime dataFinal = new DateTime(data_fin.Year, data_fin.Month, data_fin.Day, 23, 59, 59);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_name_user", OracleDbType.Varchar2).Value = user;
                        cmd.Parameters.Add("v_ocorrencia", OracleDbType.Varchar2).Value = ocorrencia;
                        cmd.Parameters.Add("v_data_ini", OracleDbType.Date).Value = data_ini;
                        cmd.Parameters.Add("v_data_fin", OracleDbType.Date).Value = dataFinal;
                        ;
                        cmd.Parameters.Add("r_info", OracleDbType.RefCursor, ParameterDirection.Output);
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                log.DadosnaLista(Convert.ToInt16(reader.GetString(0)), reader.GetString(1).ToString(), Convert.ToDateTime(reader.GetDateTime(2)), Convert.ToInt16(reader.GetString(3)), reader.GetString(4).ToString());

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CarregarDadosEmpresas(int retorno, string cod_emp)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    string query = "Select * From view_empresas";
                    if (retorno == 1)
                    {
                        query = $"Select * From view_empresas where cnpj = '{cod_emp}'";
                    }

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string status = reader["status_formatado"].ToString();
                                string tel = reader["tel"].ToString();
                                string email = reader["email"].ToString();
                                string type = reader["tipo_emp"].ToString();
                                string nome_f = reader["nome_fantasia"].ToString();
                                string nome = reader["nome_emp"].ToString();
                                string cnpj = reader["cnpj"].ToString();
                                string ie = reader["insc"].ToString();
                                int id = Convert.ToInt32(reader["id"]);
                                int id_end = Convert.ToInt32(reader["id_endereco"]);
                                string uf = reader["estado"].ToString();
                                string cidade = reader["cidade"].ToString();
                                string bairro = reader["bairro"].ToString();
                                string rua = reader["rua"].ToString();
                                int numero = Convert.ToInt32(reader["numero_residencia"]);
                                string cep = reader["cep"].ToString();
                                DateTime date = Convert.ToDateTime(reader["data_abertura"]);

                                if (retorno == 0)
                                {
                                    tableemp = new TabelaEmpresas();
                                    tableemp.RecebeInfoList(status, type, nome_f, cnpj, ie, tel, email, id, id_end, uf, cidade, bairro, rua, numero, cep);
                                }
                                else
                                {
                                    CadastraCNPJ classcnpj = new CadastraCNPJ();
                                    classcnpj.AddList(status, type, nome_f, nome, cnpj, ie, tel, email, id, id_end, uf, cidade, bairro, rua, numero, cep, date);
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
        }

       
        #endregion
        public bool AntiCopy(string celula, string table, string cod)//Verifica se uma palavra já existe já existe
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {

                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM {table} WHERE {celula} = :cod";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":cod", OracleDbType.Varchar2).Value = cod;
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count != 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool BuscarCodBar(string cod)  //Metodo para buscar na base itens se já existe algum código de barras igual
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    string query = $"Select Count(*) From vnl_itens where codbar = :Cod";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {

                        cmd.Parameters.Add(":Cod", cod);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count != 0)
                        {
                            MessageBox.Show("Erro na geração de código de barras: possibilidade de duplicação. Se a geração for automática, um novo código será gerado. Se for manual, insira um código não utilizado!");
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool VerificaLogin()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand("vnl_prc_verificar_existencia_usuario", connection))
                    {
                        try
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add(new OracleParameter("v_valor", OracleDbType.NVarchar2, ParameterDirection.Input)).Value = Util.id_user.ToString();
                            cmd.Parameters.Add(new OracleParameter("r_retorno", OracleDbType.Boolean, ParameterDirection.Output));

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            throw new Exception("Erro ao tentar executar a query.");
                        }

                        bool v_retorno = Convert.ToBoolean(cmd.Parameters["r_retorno"].Value.ToString());

                        if (v_retorno != true)
                        {
                            throw new Exception("Este usuário não está mais conectado na aplicação.");
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}