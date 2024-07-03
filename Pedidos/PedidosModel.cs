using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class PedidosModel
    {
        Config config = new Config();

        private List<Pedidos> itens = new List<Pedidos>();
        private Dictionary<int, string> emp = new Dictionary<int, string>();
        public Dictionary<int, string> Empresas { get { return emp; } }
        public List<Pedidos> Itens { get { return itens; } }
        public void ColetarDados(int type)
        {
            emp.Clear();
            // 0 - Cliente  | 2 - Transportadora
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();


                    string query = $"Select * From vnl_cad_empresas where tipo_emp = {type} and status = 0 order by id";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                emp.Add(Convert.ToInt32(reader["id"]), reader["nome_fantasia"].ToString());
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
        public void RetornarItens()
        {
            itens.Clear();
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();


                    string query = $"Select * From vnl_itens where status = 0 order by id";

                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                itens.Add(new Pedidos(Convert.ToInt32(reader["id"]), reader["nome"].ToString(), 0, false));
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
        public void ItemSelecionado(int id)
        {
            foreach (Pedidos obj in itens)
            {
                if (obj.Id_item == id)
                {
                    obj.ItemDisp = !obj.ItemDisp;
                    break;
                }
            }
        }

        public void MudarQtdItem(int id,int qtd)
        {
            foreach (Pedidos obj in itens)
            {
                if(obj.Id_item == id)
                {
                    obj.Qtd = qtd;
                }
            }
        }
        public void Cadastrar(Pedidos pedido)
        {
            decimal id_pedido;
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("vnl_pkg_pedidos.prc_starta_pedido", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_id_user", OracleDbType.Int32).Value = Util.id_user;
                        cmd.Parameters.Add("v_id_cliente", OracleDbType.Int32).Value = pedido.Id_c;
                        cmd.Parameters.Add("v_id_transportadora", OracleDbType.Int32).Value = pedido.Id_t;
                        cmd.Parameters.Add("r_id_pedido", OracleDbType.Int32).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        id_pedido = ((OracleDecimal)cmd.Parameters["r_id_pedido"].Value).Value;
                    }
                    connection.Close();

                    EnviaItens(Convert.ToInt32(id_pedido));
                }
                catch (Exception ex)
                {
                    ErrorBox errorBox = new ErrorBox("Favor Verificar a conexao com o banco de dados!", ex.Message);
                }
            }
        }
        private void EnviaItens(int id_pedido)
        {
            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    foreach (Pedidos obj in itens)
                    {
                        if (obj.ItemDisp)
                        {
                            using (OracleCommand cmd = new OracleCommand("vnl_pkg_pedidos.prc_insere_item_no_pedido", connection))
                            {
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                cmd.Parameters.Add("v_id_pedido", OracleDbType.Int32).Value = id_pedido;
                                cmd.Parameters.Add("v_id_item", OracleDbType.Int32).Value = obj.Id_item;
                                cmd.Parameters.Add("v_qtd", OracleDbType.Int32).Value = obj.Qtd;

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    connection.Close();
                    MessageBox.Show($"Pedido {id_pedido} foi gerado com sucesso!");
                }
                catch (Exception ex)
                {
                    ErrorBox errorBox = new ErrorBox("Favor Verificar a conexao com o banco de dados!", ex.Message);
                }
            }
        }
    }
}
