using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.StatusCd;

namespace Vanilla
{
    public class ClassQuantItem
    {
        Config config = new Config();
        public void RetornaItens() //SELECT GERAL
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"Select * From view_itens", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                InserirItem item = new InserirItem();
                                item.AddListItems(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), Convert.ToInt32(reader["qtn_total"]));

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

        public void InsereItens(int id, int quantidade)     //Faz a Gravação de itens na tabela
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
                            using (OracleCommand cmd = new OracleCommand("vnl_pkg_itens.vnl_ins_end", connection))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.Add("v_id_item", OracleDbType.Int32).Value = id;
                                cmd.Parameters.Add("v_quant", OracleDbType.Decimal).Value = quantidade;
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Item gravado com sucesso!");
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

        public bool VerificaExistencia()    
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
                            using (OracleCommand cmd = new OracleCommand("vnl_pkg_cd.vnl_status_cd", connection))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.Add("r_total", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("r_pulmao_t", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("r_picking_t", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("r_pulmao_l", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.Parameters.Add("r_picking_l", OracleDbType.Int32).Direction = ParameterDirection.Output;
                                cmd.ExecuteNonQuery();
                               if(((OracleDecimal)cmd.Parameters["r_pulmao_t"].Value) != 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
