using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vanilla
{
    public class ModelTabelaPedidos
    {
        Config config = new Config();
        private DateTime data_ini;
        private DateTime? data_fim;
        private string cliente, transportadora, status, n_pedido, item;
        private double cubagem;
        private int qtd;
        public DateTime Data_ini { get { return data_ini; } set { data_ini = value; } }
        public DateTime? Data_fim { get { return data_fim; } set { data_fim = value; } }
        public string Cliente { get { return cliente; } set { cliente = value; } }
        public string Transportadora { get { return transportadora; } set { transportadora = value; } }
        public string Status { get { return status; } set { status = value; } }
        public string N_pedido { get { return n_pedido; } set { n_pedido = value; } }
        public string Item { get { return item; } set { item = value; } }
        public double Cubagem { get { return cubagem; } set { cubagem = value; } }
        public int Qtd { get { return qtd; } set { qtd = value; } }

        private List<ModelTabelaPedidos> listapedidos = new List<ModelTabelaPedidos>();
        public List<ModelTabelaPedidos> ListaPedidos { get { return listapedidos; } }

        private List<ModelTabelaPedidos> listalinhapedidos = new List<ModelTabelaPedidos>();
        public List<ModelTabelaPedidos> Listalinhapedidos { get { return listalinhapedidos; } }

        public ModelTabelaPedidos()
        {
        }

        public ModelTabelaPedidos(DateTime data_ini, DateTime? data_fim, string cliente, string transportadora, string status, string n_pedido, double cubagem)
        {
            this.data_ini = data_ini;
            this.data_fim = data_fim;
            this.cliente = cliente;
            this.transportadora = transportadora;
            this.status = status;
            this.n_pedido = n_pedido;
            this.cubagem = cubagem;
        }

        public ModelTabelaPedidos(string n_pedido, string item, double cubagem, int qtd)
        {
            this.n_pedido = n_pedido;
            this.item = item;
            this.cubagem = cubagem;
            this.qtd = qtd;
        }

        public void ColetaPedidos()
        {
            listapedidos.Clear();
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        using (OracleCommand cmd = new OracleCommand("Select * from view_pedidos order by id desc", connection))
                        {
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    DateTime? data_fim = reader["dthr_fim"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["dthr_fim"]);

                                    listapedidos.Add(new ModelTabelaPedidos(Convert.ToDateTime(reader["dthr_criacao"]), data_fim, reader["cliente"].ToString(), reader["transportadora"].ToString(), reader["situacao"].ToString(), reader["id"].ToString(), Convert.ToDouble(reader["cubagem_pedido"])));
                                }
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
        public void ColetaLinhaPedidos(string id_pedido)
        {
            listalinhapedidos.Clear();
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        using (OracleCommand cmd = new OracleCommand($"Select * from view_linha_pedidos where id_pedido = {id_pedido}", connection))
                        {
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    listalinhapedidos.Add(new ModelTabelaPedidos(reader["id_pedido"].ToString(), reader["item"].ToString(), Convert.ToDouble(reader["cubagem_pedido"]), Convert.ToInt32(reader["qtd"])));
                                }
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
