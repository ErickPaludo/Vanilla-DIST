using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace Vanilla
{
    public class ModelMsg
    {
        Config config = new Config();
        private static int id_ultima_msg;
        Mensagem msginf = new Mensagem();
        public int Id
        {
            get
            {
                return id_ultima_msg;
            }
        }

        static private List<Mensagem> contatos = new List<Mensagem>();
        public List<Mensagem> Contatos
        {
            get
            {
                return contatos;
            }
        }

        static private List<Mensagem> histlist = new List<Mensagem>();
        public List<Mensagem> Histlist
        {
            get
            {
                return histlist;
            }
        }

        public void Env(string id_r, string id_d, string mensagem)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_prc_msg", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_id_remetente", OracleDbType.Int16).Value = Convert.ToInt32(id_r);
                        cmd.Parameters.Add("v_id_destinatario", OracleDbType.Int16).Value = Convert.ToInt32(id_d);
                        cmd.Parameters.Add("v_msg", OracleDbType.Varchar2).Value = mensagem;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void RecebeMensagens()
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"select * from view_msg w where w.id_remetente = {Util.id_user} and w.id_destinatario = {Usuario.id_des} or w.id_remetente = {Usuario.id_des} and w.id_destinatario = {Util.id_user} order by dthr", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            histlist.Clear();
                            while (reader.Read())
                            {
                                histlist.Add(new Mensagem(reader["id_remetente"].ToString(), reader["remetente"].ToString(), reader["msg"].ToString(), Convert.ToDateTime(reader["dthr"])));
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
        public void NovaMsg()
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"SELECT MAX(id) as id FROM vnl_msg WHERE (destinatario = {Usuario.id_des} OR destinatario = {Util.id_user}) AND (remetente = {Util.id_user} OR remetente = {Usuario.id_des})", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader.IsDBNull(reader.GetOrdinal("id")))
                                {
                                    id_ultima_msg = 0;
                                }
                                else
                                {
                                    id_ultima_msg = reader.GetInt32(reader.GetOrdinal("id"));
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
        public void SetDestinoId(string us)
        {
            foreach (Mensagem obj in contatos)
            {
                if (obj.Name_r == us)
                {
                    Usuario.id_des = obj.Id.ToString();
                    break;
                }
            }
        }
        public void CarregaContatos()
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                contatos.Clear();
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"select * from vnl_user where id != {Util.id_user}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                contatos.Add(new Mensagem(Convert.ToInt32(reader["id"]), reader["login"].ToString()));
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

