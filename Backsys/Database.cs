using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Reflection.PortableExecutable;
using MySqlX.XDevAPI.Relational;
using System.Reflection.Metadata;


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
        #endregion

        public Database()
        {
        }

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
                        cmd.Parameters.Add("r_name", OracleDbType.Varchar2, 1000).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        string msg = cmd.Parameters["r_msg"].Value.ToString();
                        decimal id = ((OracleDecimal)cmd.Parameters["r_id_user"].Value).Value;
                        bool ver = ((OracleBoolean)cmd.Parameters["r_verificador"].Value).IsTrue;
                        decimal perm = ((OracleDecimal)cmd.Parameters["r_perm"].Value).Value;
                        string name = cmd.Parameters["r_name"].Value.ToString();
                        util = new Util();
                        util.DadosUser(Convert.ToInt32(id), Convert.ToInt32(perm), name);
                        if (ver == false)
                        {
                            MessageBox.Show(msg);
                        }
                        else
                        {
                            AddLog("USUÁRIO LOGADO!"); //temporário
                        }
                        return ver;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public void Deslog()
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
                        cmd.Parameters.Add("v_id", OracleDbType.Int16).Value = util.Id_user;
                        cmd.ExecuteNonQuery();
                        AddLog("USUÁRIO DESLOGADO!"); //temporário
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    MessageBox.Show($"Está ocorrendo o seguinte erro:\n{ex}");
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
                    MessageBox.Show($"Ocorreu o seguinte erro:\n{ex}");
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
                    MessageBox.Show(ex.Message);
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

                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_emp.vnl_ins_emp", connection))
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
                        AddLog($"EMPRESA {nome} | {cnpj} | TIPO: {type_cad} | FOI CADASTRADA COM SUCESSO!");
                        MessageBox.Show("Operação Concluída!");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void GravarnUsers(string nome, string cpf, string email, string tel, string tel2, string permissao, string status, string user, string pass, int bloq_user)
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
                            cmd.Parameters.Add("v_bloq", bloq_user);
                            cmd.ExecuteNonQuery();
                            AddLog($"USUARIO: {user} | TIPO: {permissao} | FOI CADASTRADO COM SUCESSO!");
                            MessageBox.Show("Usuario adicionado com sucesso!");
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } //gravar na base o usuario

        public void GravarItens(int id_fornecedor, string cod, string nome, string status, string desc, string undm, int quant, decimal preco_c, decimal margem, decimal preco_v)     //Faz a Gravação de itens na tabela
        {

            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    try
                    {
                        connection.Open();

                        using (OracleTransaction transaction = connection.BeginTransaction())
                        {
                            using (OracleCommand cmd = new OracleCommand("vnl_pkg_itens.vnl_ins_item", connection))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.Add("v_id_f", OracleDbType.Int32).Value = id_fornecedor;
                                cmd.Parameters.Add("v_codbar", OracleDbType.Varchar2).Value = cod;
                                cmd.Parameters.Add("v_name", OracleDbType.Varchar2).Value = nome;
                                cmd.Parameters.Add("v_status", OracleDbType.Varchar2).Value = status;
                                cmd.Parameters.Add("v_desc", OracleDbType.Varchar2).Value = desc;
                                cmd.Parameters.Add("v_und_med", OracleDbType.Varchar2).Value = undm;
                                cmd.Parameters.Add("v_quant", OracleDbType.Int32).Value = quant;
                                cmd.Parameters.Add("v_pre_c", OracleDbType.Decimal).Value = preco_c;
                                cmd.Parameters.Add("v_porc_l", OracleDbType.Decimal).Value = margem;
                                cmd.Parameters.Add("v_pre_f", OracleDbType.Decimal).Value = preco_v;
                                cmd.ExecuteNonQuery();
                                AddLog($"ITEM: {nome} | STATUS: {status} | CODBAR: {cod} | FOI CADASTRADO COM SUCESSO!");
                            }
                            MessageBox.Show("Item gravado com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void AddLog(string msg)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                util = new Util();
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_log.vnl_reg_logs", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_id_user", OracleDbType.Int16).Value = util.Id_user;
                        cmd.Parameters.Add("v_ocorrencia", OracleDbType.Varchar2).Value = msg;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Editar
        public void EditarTFC(int id, string nomef, string nome, string cnpj, DateTime abertura, DateTime cadastro, string insc_est, string type_cad, string tel, string email, string status, string rua, int numero, string comple, string bairro, string cidade, string uf, string cep)
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

                            using (OracleCommand cmd = new OracleCommand("vnl_pkg_emp.vnl_edit_emp", connection))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.Add("v_id", id);
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
                                AddLog($"EMPRESA {nome} | {cnpj} | TIPO: {type_cad} | FOI EDITADA COM SUCESSO!");
                            }
                            MessageBox.Show($"{cnpj} / {nome} foi editado!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void EditaItens(int id_principal, int id_fornecedor, string cod, string nome, string status, string desc, string undm, int quant, decimal preco_c, decimal margem, decimal preco_v)
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
                            cmd.Parameters.Add("v_quant", OracleDbType.Int32).Value = quant;
                            cmd.Parameters.Add("v_pre_c", OracleDbType.Decimal).Value = preco_c;
                            cmd.Parameters.Add("v_porc_l", OracleDbType.Decimal).Value = margem;
                            cmd.Parameters.Add("v_pre_f", OracleDbType.Decimal).Value = preco_v;
                            cmd.ExecuteNonQuery();
                            AddLog($"ITEM: {nome} | STATUS: {status} | CODBAR: {cod} | FOI EDITADO COM SUCESSO!");
                        }
                        MessageBox.Show("Item gravado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                            AddLog($"USUARIO: {nome} | ID: {id} | FOI EDITADO COM SUCESSO!");
                        }

                        MessageBox.Show("Usuário gravado com sucesso!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                            AddLog($"O endereço {id} foi alterado!");
                        }
                        MessageBox.Show("Usuário gravado com sucesso!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                            AddLog($"USUARIO: {login} | ID: {id} | PERMISSAO: {perm} | STATUS: {status} | FOI EDITADO COM SUCESSO!");
                        }
                        MessageBox.Show("Usuário gravado com sucesso!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Buscadores
        public void ChamaView(string table) //SELECT GERAL
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
                                    itens_table = new TabelaItens(true);
                                    itens_table.AddNaTabelaItens(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["id_fornecedor"]), reader["nome_fantasia"].ToString(), reader["codigo_barras"].ToString(), reader["nome_item"].ToString(), reader["descri_item"].ToString(), reader["unidade_medida_item"].ToString(), Convert.ToInt32(reader["quant_item"]), Convert.ToDecimal(reader["preco_custo_item"]), Convert.ToDecimal(reader["margem_lucro_item"]), Convert.ToDecimal(reader["preco_venda_item"]), reader["status_conv"].ToString());
                                }
                                else if (table == "view_users_logados")
                                {
                                    UserOn user = new UserOn();
                                    user.AddNaLista(reader["login_user"].ToString(), reader["hostname"].ToString(), reader["ip"].ToString(), Convert.ToDateTime(reader["acess"]));
                                }
                                else
                                {
                                    AlterarUsersGeral alteruserc = new AlterarUsersGeral();
                                    alteruserc.ArmazenaDados(Convert.ToInt32(reader["id"]), reader["nome_user"].ToString(), reader["cpf_user"].ToString(), reader["email_user"].ToString(), reader["telefone_user"].ToString(), reader["telefone_user_"].ToString(), reader["perm_form"].ToString(), reader["status_format"].ToString(), reader["login_user"].ToString(), reader["password_user"].ToString(), Convert.ToInt32(reader["bloq_User"]));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        public void RetornarItens(int id, out int r_id_f, out string r_codbar, out string name, out string description, out string r_und_med, out int r_quant, out decimal r_pre_c, out decimal r_porc_l, out decimal r_pre_f, out string r_name, out string r_status)
        {
            r_id_f = 0;
            r_codbar = string.Empty;
            name = string.Empty;
            description = string.Empty;
            r_und_med = string.Empty;
            r_quant = 0;
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
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_itens.vnl_busc_item", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
                        cmd.Parameters.Add("r_info", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                r_id_f = reader.GetInt32(0);
                                r_codbar = reader.GetString(1);
                                name = reader.GetString(2);
                                description = !reader.IsDBNull(3) ? reader.GetString(3) : string.Empty;
                                r_und_med = reader.GetString(4);
                                r_quant = reader.GetInt32(5);
                                r_pre_c = reader.GetDecimal(6);
                                r_porc_l = reader.GetDecimal(7);
                                r_pre_f = reader.GetDecimal(8);
                                r_name = reader.GetString(9);
                                r_status = reader.GetString(10);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    MessageBox.Show(ex.Message);
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
                    using (OracleCommand cmd = new OracleCommand("Select login_user from user_base", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                log.AddnoListCombo(reader["login_user"].ToString());
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_log.vnl_pesq_logs", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_name_user", OracleDbType.Varchar2).Value = user;
                        cmd.Parameters.Add("v_ocorrencia", OracleDbType.Varchar2).Value = ocorrencia;
                        cmd.Parameters.Add("v_data_ini", OracleDbType.Date).Value = data_ini;
                        cmd.Parameters.Add("v_data_fin", OracleDbType.Date).Value = data_fin;
                        cmd.Parameters.Add("r_info", OracleDbType.RefCursor, ParameterDirection.Output);
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                log.DadosnaLista(Convert.ToInt16(reader.GetString(0)), reader.GetString(2).ToString(), Convert.ToDateTime(reader.GetDateTime(3)), Convert.ToInt16(reader.GetString(1)), reader.GetString(4).ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                                string type = reader["client_type"].ToString();
                                string nome_f = reader["nome_fantasia"].ToString();
                                string nome = reader["nome_emp"].ToString();
                                string cnpj = reader["cnpj"].ToString();
                                string ie = reader["inscricao_estadual"].ToString();
                                int id = Convert.ToInt32(reader["id_emp"]);
                                int id_end = Convert.ToInt32(reader["id"]);
                                string uf = reader["uf"].ToString();
                                string cidade = reader["cidade"].ToString();
                                string bairro = reader["bairro"].ToString();
                                string rua = reader["rua"].ToString();
                                int numero = Convert.ToInt32(reader["numero"]);
                                string cep = reader["cep"].ToString();
                                DateTime date = Convert.ToDateTime(reader["date_abertura"]);

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
                    MessageBox.Show($"Ocorreu o seguinte erro:\n{ex}");
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
                    MessageBox.Show(ex.ToString());
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
                    string query = $"Select Count(*) From itens_base where codigo_barras = :Cod";

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
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        #region Temporariamente desligdas

        public void Gravarla(string tabela, int id_la, int id_predio, int id_rua) //grava as informações de La no banco
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {

                        string query = $"INSERT INTO {tabela}(id_la, id_predio,id_rua) VALUES (:la,:id_p,:id_rua)";

                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("la", OracleDbType.Int32).Value = id_la;
                            cmd.Parameters.Add("id_p", OracleDbType.Int32).Value = id_predio;
                            cmd.Parameters.Add("id_rua", OracleDbType.Int32).Value = id_rua;
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GravarCd(string tabela, int id_predio, int rua_cd, int empmin)//grava as informações de leyout cd no banco
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {

                        string query = $"INSERT INTO {tabela}(id_predio,rua_cd,la_emp_min) VALUES (:id_p,:rua_cd,:emp_min)";

                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add("id_p", OracleDbType.Int32).Value = id_predio;
                            cmd.Parameters.Add("rua_cd", OracleDbType.Int32).Value = rua_cd;
                            cmd.Parameters.Add("emp_min", OracleDbType.Int32).Value = empmin;
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        public void VerificaLogin()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand("verificar_existencia_usuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new OracleParameter("v_table", OracleDbType.NVarchar2, ParameterDirection.Input)).Value = "VNL_USER_LOGADOS";
                        cmd.Parameters.Add(new OracleParameter("v_coluna", OracleDbType.NVarchar2, ParameterDirection.Input)).Value = "ID";
                        cmd.Parameters.Add(new OracleParameter("v_valor", OracleDbType.NVarchar2, ParameterDirection.Input)).Value = Util.id_user.ToString();
                        cmd.Parameters.Add(new OracleParameter("v_retorno", OracleDbType.Int32, ParameterDirection.Output));

                        cmd.ExecuteNonQuery();

                        int v_retorno = Convert.ToInt32(cmd.Parameters["v_retorno"].Value.ToString());

                        if (v_retorno != 1)
                            throw new Exception("Este usuário não está mais connectado na aplicação.");

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro:\n{ex.Message}");
                Homepage home = new Homepage();
                home.Hide();
                LoginFront login = new LoginFront();
                login.Show();
            }
        }
    }
}



