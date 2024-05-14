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

      


        #region Buscadores
       

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