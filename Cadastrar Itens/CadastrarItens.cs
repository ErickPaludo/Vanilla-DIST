namespace Vanilla
{
    public class CadastrarItens : CadastraCnpjBack
    {
        Database db = new Database();
        Util utilitarios = new Util();
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
        public string Nome_item { get { return nome_item; } set { nome_item = value; } }
        public int Id_item { get { return id_item; } set { id_item = value; } }
        public decimal Preco_custo { get { return preco_custo; } set { preco_custo = value; } }
        public decimal Lucro_porcent { get { return lucro_porcent; } set { lucro_porcent = value; } }
        public decimal Preco_final { get { return preco_final; } set { preco_final = value; } }
        public int Quantidade { get { return quantidade; } set { quantidade = value; } }
        public string Codbar { get { return codbar; } set { codbar = value; } }
        public int Status { get { return status; } set { status = value; } }
        public string Status_conv { get { return status_conv; } set { status_conv = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public string Unmed { get { return unmed; } set { unmed = value; } }


        public CadastrarItens()
        {
        }

        public CadastrarItens(int id_item, int id_fornec,string nome_f, string nome_item, decimal preco_custo, decimal lucro_porcent, decimal preco_final, string codbar, string status_conv, string descricao, string unmed) : base(nome_f,id_fornec)
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

        public CadastrarItens(int id, string name, int quant) // contrutor da lista de fornecedores de itens
        {
            this.id_item = id;
            this.nome_item= name;
            this.quantidade = quant;
        }

        public CadastrarItens(int id_fornec, string nome, string cnpj) : base(id_fornec,nome, cnpj) // contrutor da lista de fornecedores de itens
        {
        }
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
        public void CadastraItem(int id_fornecedor, string codigo_barras, string nome, string status, string desc, string und_m, decimal preco_custo, decimal margem_lucro, decimal preco_venda, int id_end, double cubagem) //Grava no banco de dados
        {
            db.GravarItens (id_fornecedor, codigo_barras, nome, status, desc, und_m, preco_custo, margem_lucro, preco_venda,id_end,cubagem); //grava de fato no banco
        }
        public void EditaItens(int id_principal,int id_fornecedor,string cod,string nome, string status, string desc, string und_m, decimal preco_custo, decimal margem_lucro, decimal preco_venda) //Grava no banco de dados
        {
            db.EditaItens(id_principal, id_fornecedor, cod, nome, status, desc, und_m, preco_custo, margem_lucro, preco_venda); 
        }
        public void ReturItens(int id)
        {
            db.ChamaView("view_itens",1);
        }
    }
}
