using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class TabelaEmpClass
    {
        Config config = new Config();

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
                                    TabelaEmpresas tableemp = new TabelaEmpresas();
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
    }
}
