using Newtonsoft.Json.Linq;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Vanilla.CadastraCd
{
    public class ClassAddCd
    {
        Config config = new Config();
        Database db = new Database();

        public void GravarCd(int predios, int la, int min_emp, int type_generate, int id_reg, string nome_rua, int subla)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    try
                    {
                        connection.Open();
                        using (OracleCommand cmd = new OracleCommand("vnl_pkg_cd.vnl_cria_cds", connection))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("v_nome_rua", nome_rua);
                            cmd.Parameters.Add("v_predio_fin", predios);
                            cmd.Parameters.Add("v_la", la);
                            cmd.Parameters.Add("v_sub_la", subla);
                            cmd.Parameters.Add("v_min_emp", min_emp);
                            cmd.Parameters.Add("v_par_or_impar", type_generate);
                            cmd.Parameters.Add("v_id_reg", id_reg);
                            cmd.ExecuteNonQuery();
                            db.AddLog($"{predios} enderecos adicionados ao CD", Util.id_user);
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
        }
        public void RetornaRuas()
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand("select * from view_obtem_ruas", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                cd.ObtemRuas(Convert.ToInt32(reader["rua"]), reader["nome"].ToString(), reader["status"].ToString());
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
        public void RetornaRuaUnica(int rua)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand($"select * from view_enderecos_cd where rua= {rua}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {                       
                                while (reader.Read())
                                {
                                    cd.GravaListEndereco(Convert.ToInt32(reader["rua"]), Convert.ToInt32(reader["predio"]), Convert.ToInt32(reader["la"]), reader["cod"].ToString(), reader["nome_regiao"].ToString());
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
        public void RetornaPredio(int predio)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand($"select * from view_subla where predio = {predio}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                cd.PickingAdd(Convert.ToInt32(reader["rua"]), Convert.ToInt32(reader["predio"]), Convert.ToInt32(reader["la"]), Convert.ToInt32(reader["sub_la"]), reader["cod"].ToString(), reader["item"].ToString());
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
