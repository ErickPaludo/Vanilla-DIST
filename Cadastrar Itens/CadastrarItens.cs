using Oracle.ManagedDataAccess.Client;

namespace Vanilla
{
    public class CadastrarItens : CadastraCnpjBack
    {
        Database db = new Database();
        Util utilitarios = new Util();
        Config config = new Config();
        #region Propriedades
        private string nome_item;
        private int id_item;
        private decimal preco_custo;
        private decimal lucro_porcent;
        private decimal preco_final;
        private int quantidade;
        private string codbar;
        private int status;
        private string status_conv;
        private string descricao;
        private string unmed;
        private decimal altura;
        private decimal largura;
        private decimal comprimento;
        private decimal cubagem;
        public string Nome_item
        {
            get
            {
                return nome_item;
            }
            set
            {
                nome_item = value;
            }
        }
        public int Id_item
        {
            get
            {
                return id_item;
            }
            set
            {
                id_item = value;
            }
        }
        public decimal Preco_custo
        {
            get
            {
                return preco_custo;
            }
            set
            {
                preco_custo = value;
            }
        }
        public decimal Lucro_porcent
        {
            get
            {
                return lucro_porcent;
            }
            set
            {
                lucro_porcent = value;
            }
        }
        public decimal Preco_final
        {
            get
            {
                return preco_final;
            }
            set
            {
                preco_final = value;
            }
        }
        public int Quantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                quantidade = value;
            }
        }
        public string Codbar
        {
            get
            {
                return codbar;
            }
            set
            {
                codbar = value;
            }
        }
        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public string Status_conv
        {
            get
            {
                return status_conv;
            }
            set
            {
                status_conv = value;
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }
        public string Unmed
        {
            get
            {
                return unmed;
            }
            set
            {
                unmed = value;
            }
        }
        public decimal Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }
        public decimal Largura
        {
            get
            {
                return largura;
            }
            set
            {
                largura = value;
            }
        }
        public decimal Comprimento
        {
            get
            {
                return comprimento;
            }
            set
            {
                comprimento = value;
            }
        }
        public decimal Cubagem
        {
            get
            {
                return cubagem;
            }
            set
            {
                cubagem = value;
            }
        }
        #endregion
        #region Construtores
        public CadastrarItens()
        {
        }

        public CadastrarItens(int id_item, int id_fornec, string nome_f, string nome_item, decimal preco_custo, decimal lucro_porcent, decimal preco_final, string codbar, string status_conv, string descricao, string unmed) : base(nome_f, id_fornec)
        {
            this.nome_item = nome_item;
            this.id_item = id_item;
            this.preco_custo = preco_custo;
            this.lucro_porcent = lucro_porcent;
            this.preco_final = preco_final;
            this.codbar = codbar;
            this.status_conv = status_conv;
            this.descricao = descricao;
            this.unmed = unmed;         
        }

        public CadastrarItens(int id_item, int id_fornec, string nome_f, string nome_item, decimal preco_custo, decimal lucro_porcent, decimal preco_final, string codbar, string status_conv, string descricao, string unmed, decimal altura, decimal largura, decimal comprimento, decimal cubagem) : base(nome_f, id_fornec)
        {
            this.nome_item = nome_item;
            this.id_item = id_item;
            this.preco_custo = preco_custo;
            this.lucro_porcent = lucro_porcent;
            this.preco_final = preco_final;
            this.codbar = codbar;
            this.status_conv = status_conv;
            this.descricao = descricao;
            this.unmed = unmed;
            this.altura = altura;
            this.largura = largura;
            this.comprimento = comprimento;
            this.cubagem = cubagem;
        }

        public CadastrarItens(int id, string name, int quant) // contrutor da lista de fornecedores de itens
        {
            this.id_item = id;
            this.nome_item = name;
            this.quantidade = quant;
        }

        public CadastrarItens(int id_fornec, string nome, string cnpj) : base(id_fornec, nome, cnpj) // contrutor da lista de fornecedores de itens
        {
        }
        #endregion

        public string GeraCodBarrar() //gera um cod de 13 digitos
        {
            bool verific = false;
            int cod_1, cod_2;
            string cod_bar;
            Random random = new Random();
            do
            {
                cod_1 = random.Next(100000, 9999999); //gera primeira parte do codigo
                cod_2 = random.Next(100000, 999999); //gera segunda parte do codigo
                cod_bar = $"{cod_1}{cod_2}"; //gera codigo completo
                verific = db.BuscarCodBar(cod_bar); //verifica se o codigo ja existe
            } while (verific == false);
            return cod_bar; //retorna o codigo
        }

        public decimal CalculaPrecoFinal(decimal preco_custo, decimal percent_lucro) //Faz o calculo de lucro
        {
            return preco_custo + (preco_custo * (percent_lucro / 100));
        }

        public void CadastraItem(int id_fornecedor, string codigo_barras, string nome, string status, string desc,
            string und_m, decimal preco_custo, decimal margem_lucro, decimal preco_venda, int id_end, double cubagem, double altura, double largura, double comprimento) //Grava no banco de dados
        {

            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();

                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        using (OracleCommand cmd = new OracleCommand("vnl_pkg_itens.vnl_ins_item", connection))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("v_id_f", OracleDbType.Int32).Value = id_fornecedor;
                            cmd.Parameters.Add("v_cubagem", OracleDbType.Decimal).Value = cubagem;
                            cmd.Parameters.Add("v_altura", OracleDbType.Decimal).Value = altura;
                            cmd.Parameters.Add("v_largura", OracleDbType.Decimal).Value = largura;
                            cmd.Parameters.Add("v_comprimento", OracleDbType.Decimal).Value = comprimento;
                            cmd.Parameters.Add("v_codbar", OracleDbType.Varchar2).Value = codigo_barras;
                            cmd.Parameters.Add("v_name", OracleDbType.Varchar2).Value = nome;
                            cmd.Parameters.Add("v_status", OracleDbType.Varchar2).Value = status;
                            cmd.Parameters.Add("v_desc", OracleDbType.Varchar2).Value = desc;
                            cmd.Parameters.Add("v_und_med", OracleDbType.Varchar2).Value = und_m;
                            cmd.Parameters.Add("v_pre_c", OracleDbType.Decimal).Value = preco_custo;
                            cmd.Parameters.Add("v_porc_l", OracleDbType.Decimal).Value = margem_lucro;
                            cmd.Parameters.Add("v_pre_f", OracleDbType.Decimal).Value = preco_venda;
                            cmd.Parameters.Add("v_id_picking", OracleDbType.Int32).Value = id_end;
                            cmd.Parameters.Add("v_quant_max", OracleDbType.Int32).Value = 999;
                            cmd.ExecuteNonQuery();
                            db.AddLog($"ITEM: {nome} | STATUS: {status} | CODBAR: {codigo_barras} | FOI CADASTRADO COM SUCESSO!", Util.id_user);
                        }
                        MessageBox.Show("Item gravado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditaItens(int id_principal, int id_fornecedor, string cod, string nome, string status, string desc, string und_m, decimal preco_custo, decimal margem_lucro, decimal preco_venda) //Grava no banco de dados
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        using (OracleCommand cmd = new OracleCommand("vnl_pkg_itens.vnl_edit_item", connection))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.Parameters.Add("v_id", OracleDbType.Int32).Value = id_principal;
                            cmd.Parameters.Add("v_id_f", OracleDbType.Int32).Value = id_fornecedor;
                            cmd.Parameters.Add("v_name", OracleDbType.Varchar2).Value = nome;
                            cmd.Parameters.Add("v_status", OracleDbType.Varchar2).Value = status;
                            cmd.Parameters.Add("v_desc", OracleDbType.Varchar2).Value = desc;
                            cmd.Parameters.Add("v_und_med", OracleDbType.Varchar2).Value = und_m;
                            cmd.Parameters.Add("v_pre_c", OracleDbType.Decimal).Value = preco_custo;
                            cmd.Parameters.Add("v_porc_l", OracleDbType.Decimal).Value = margem_lucro;
                            cmd.Parameters.Add("v_pre_f", OracleDbType.Decimal).Value = preco_final;
                            cmd.ExecuteNonQuery();
                            db.AddLog($"ITEM: {nome} | STATUS: {status} | CODBAR: {cod} | FOI EDITADO COM SUCESSO!", Util.id_user);
                        }
                        MessageBox.Show("Item gravado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReturItens()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"Select * From view_itens order by id", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                TabelaItens itens_table = new TabelaItens(true);
                                itens_table.AddNaTabelaItens(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["id_f"]), reader["nome_fantasia"].ToString(), reader["codbar"].ToString(), reader["nome"].ToString(), reader["descri"].ToString(), reader["und_med"].ToString(), Convert.ToDecimal(reader["preco_custo"]), Convert.ToDecimal(reader["lucro"]), Convert.ToDecimal(reader["preco_final"]), reader["status"].ToString());
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

        public void ReturItensCuston(string column, string busca)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(config.Lerdados()))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"Select * From view_itens where {column} LIKE '%{busca}%'", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TabelaItens itens_table = new TabelaItens(true);
                                itens_table.AddNaTabelaItens(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["id_f"]), reader["nome_fantasia"].ToString(), reader["codbar"].ToString(), reader["nome"].ToString(), reader["descri"].ToString(), reader["und_med"].ToString(), Convert.ToDecimal(reader["preco_custo"]), Convert.ToDecimal(reader["lucro"]), Convert.ToDecimal(reader["preco_final"]), reader["status"].ToString());
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

        public double CalculaMetrosCubicos(double altura, double largura, double comprimento)
        {
            return ((altura /100) * (largura / 100) * (comprimento / 100));
        }

        public CadastrarItens RetornarItens(int id)
        {

            using (OracleConnection connection = new OracleConnection(config.Lerdados()))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"select * from view_itens where id = {id}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                return new CadastrarItens(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["id_f"]), reader["nome_fantasia"].ToString(), reader["nome"].ToString(), Convert.ToDecimal(reader["preco_custo"]), Convert.ToDecimal(reader["lucro"]), Convert.ToDecimal(reader["preco_final"]),reader["codbar"].ToString(), reader["status"].ToString(), reader["descri"].ToString(), reader["und_med"].ToString(), Convert.ToDecimal(reader["altura"]), Convert.ToDecimal(reader["largura"]),Convert.ToDecimal(reader["comprimento"]), Convert.ToDecimal(reader["cubagem_item"]));
                            }
                            return new CadastrarItens();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new CadastrarItens();
                }
            }
        }
    }

}
