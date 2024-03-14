using System.Security.Cryptography.X509Certificates;

namespace Vanilla
{
    public partial class EnderecoFront : Form
    {
        AlterarUserCFront alterarUserCFront = new AlterarUserCFront();
        AdicionarUsuariosFront usuarios = new AdicionarUsuariosFront();
        Util util = new Util();
        Endereco endereco = new Endereco();
        static List<Endereco> ceparmazena = new List<Endereco>();
        static int returnclass; // Se trata de um parametro, o numero vai indicar qual classe o valor id deve ser retornado
        static bool edit;
        static int id_end;

        public EnderecoFront()
        {
        }

        public EnderecoFront(int whereclass) //esse construtor vai receber o parametro
        {
            InitializeComponent();
            returnclass = whereclass; //essa variavel recebera o numero para a classe
        }

        public void RecebeIdEnd(int id)
        {
            id_end = id;
        }
        public EnderecoFront(bool habilite) //esse construtor vai receber o parametro
        {
            InitializeComponent();
            edit = habilite;
        }

        public void numeroEndereco_KeyPress(object sender, KeyPressEventArgs e) //Verifica se foi digitado um numero
        {
            util.SomenteNumeros(e);//metodo que verifica o que foi digitado
        }

        private void cepTransp_KeyPress(object sender, KeyPressEventArgs e) //Verifica se foi digitado um numero
        {
            util.SomenteNumeros(e);//metodo que verifica o que foi digitado
        }   

        private void numeroEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            util.AntiCtrlV(e);
        }
        private void cepTransp_KeyDown(object sender, KeyEventArgs e)
        {
            util.AntiCtrlV(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ruaTransp.Text) &&
              !string.IsNullOrEmpty(numeroEndereco.Text) &&
              !string.IsNullOrEmpty(bairroTransp.Text) &&
              !string.IsNullOrEmpty(cidadeTranp.Text) &&
              !string.IsNullOrEmpty(ufTransp.Text) &&
              !string.IsNullOrEmpty(cepTransp.Text) && cepTransp.Text.Length == 8)
            {
                {
                    if (edit == false)
                    {

                        endereco.AddEndereco((ruaTransp.Text).ToString(), Convert.ToInt32(numeroEndereco.Text), (complementoTransp.Text).ToString(), (bairroTransp.Text).ToString(), (cidadeTranp.Text).ToString(), ufTransp.Text, (cepTransp.Text).ToString(), returnclass); //
                    }
                    else
                    {
                        endereco.EditEndereco(id_end, (ruaTransp.Text).ToString(), Convert.ToInt32(numeroEndereco.Text), (complementoTransp.Text).ToString(), (bairroTransp.Text).ToString(), (cidadeTranp.Text).ToString(), ufTransp.Text, (cepTransp.Text).ToString());
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Impossivel concluir a operação, campos inválidos!");
            }
        }

        private void PuxarInfo(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cepTransp.Text) && cepTransp.Text.Length == 8)
            {
                util.ReturnInfoCep(cepTransp.Text,0);
                foreach (Endereco end in ceparmazena)
                {
                    ufTransp.Text = end.UF;
                    bairroTransp.Text = end.Bairro;
                    ruaTransp.Text = end.Rua;
                    cidadeTranp.Text = end.Cidade;
                }
                ceparmazena.Clear();
            }
            else
            {
                MessageBox.Show("Revise o campo Cep!");
            }
        }
        public void ListaRecebe(string uf, string bairro, string endereco, string cidade)
        {
            ceparmazena.Add(new Endereco(uf, bairro, endereco, cidade));
        }
    }
}

