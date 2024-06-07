using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla.StatusCd
{
    public class Classstatuscd
    {
        Config config = new Config();
        StatusdoCd cd;
        public void RetornaStatus()     //Faz a Gravação de itens na tabela
        {
            try
            {
                cd = new StatusdoCd();
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    try
                    {
                        connection.Open();

                        using (OracleTransaction transaction = connection.BeginTransaction())
                        {
                            using (OracleCommand cmd = new OracleCommand("vnl_pkg_cd.vnl_status_cd", connection))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.Add("r_total", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("r_pulmao_t", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("r_picking_t", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("r_pulmao_l", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("r_picking_l", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.ExecuteNonQuery();      
                                cd.AlterarValores(((OracleDecimal)cmd.Parameters["r_total"].Value).Value, ((OracleDecimal)cmd.Parameters["r_pulmao_t"].Value).Value, ((OracleDecimal)cmd.Parameters["r_pulmao_l"].Value).Value,
                                 ((OracleDecimal)cmd.Parameters["r_picking_t"].Value).Value,
                              
                                ((OracleDecimal)cmd.Parameters["r_picking_l"].Value).Value);


                            }
                        }
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
        }
    }
}
