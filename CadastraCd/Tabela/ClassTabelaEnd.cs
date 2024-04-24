using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Vanilla.CadastraCd.Tabela
{
    public class ClassTabelaEnd
    {
        Config config = new Config();
        public void RetornaSubLa()
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand($"select * from view_subla", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            TabelaEnderecos end = new TabelaEnderecos();
                            while (reader.Read())
                            {
                                end.GravaListPicking(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["rua"]), Convert.ToInt32(reader["predio"]), Convert.ToInt32(reader["la"]), Convert.ToInt32(reader["sub_la"]), reader["regiao"].ToString(), reader["cod"].ToString(), reader["item"].ToString());
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
        public void RetornaEnd()
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand($"select * from view_enderecos_cd", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            TabelaEnderecos end = new TabelaEnderecos();
                            while (reader.Read())
                            {

                                end.GravaListEndereco(Convert.ToInt32(reader["rua"]), Convert.ToInt32(reader["predio"]), Convert.ToInt32(reader["la"]), reader["cod"].ToString(), reader["nome_regiao"].ToString(), reader["nome_item"].ToString());
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
