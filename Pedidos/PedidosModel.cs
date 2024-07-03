using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public List<Pedidos> Itens { get {  return itens; } }
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
                                itens.Add(new Pedidos(Convert.ToInt32(reader["id"]), reader["nome"].ToString(),0,false));
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
            foreach(Pedidos obj in itens)
            {
                if(obj.Id_item == id)
                {
                    obj.ItemDisp = !obj.ItemDisp;
                    break;
                }
            }
        }
    }
}
