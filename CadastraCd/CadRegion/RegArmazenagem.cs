using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla.CadastraCd.CadRegion
{
    public class RegArmazenagem
    {
        Config config = new Config();
        private int id;
        private string name;
        private string status;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Status { get { return status; } set { status = value; } }

        public RegArmazenagem()
        {
        }

        public RegArmazenagem(string name)
        {
            this.name = name;
        }

        public RegArmazenagem(int id, string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }

        public void GravaReg(string name_reg)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_region.vnl_cadastra_reg", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_name_reg", OracleDbType.Varchar2).Value = name_reg;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void RetornoReg(int local_class)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    CadastroCd cd = new CadastroCd();
                    SelecionarReg reg = new SelecionarReg();
                    connection.Open();

                    using (OracleCommand cmd = new OracleCommand("Select * from view_reg_sep order by id", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (local_class == 0)
                                {
                                    cd.GravarListaReg(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), reader["status"].ToString());
                                }
                                else
                                {
                                    reg.GravarListaReg(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), reader["status"].ToString());
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
