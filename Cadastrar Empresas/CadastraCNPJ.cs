using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vanilla
{
    public partial class CadastraCNPJ : Form
    {
        private CadastraCnpjBack cad = new CadastraCnpjBack();
        private Util util = new Util();
        private static List<CadastraCnpjBack> list = new List<CadastraCnpjBack>();
        private LicencasLogin lic = new LicencasLogin();
        static List<Endereco> ceparmazena = new List<Endereco>();
        private TabelaEmpClass table = new TabelaEmpClass();
        private Database db = new Database();
        private static bool editar = false;
        private static int id, id_end;
        public CadastraCNPJ()
        {
            InitializeComponent();
        }
        public CadastraCNPJ(int id)
        {
            InitializeComponent();
            if (id == 1)
            {
                combotypeemp.Text = "Fornecedor";
                combotypeemp.Enabled = false;
            }

        }
        public void DesativaEdit()
        {
            editarCnpjToolStripMenuItem.Enabled = false;
        }
        private void Clear()
        {
            nomefantasia.Text = string.Empty;
            textname.Text = string.Empty;
            textabertura.Text = string.Empty;
            textdataatual.Text = string.Empty;
            textlogradouro.Text = string.Empty;
            textnumber.Text = string.Empty;
            textbairro.Text = string.Empty;
            textcep.Text = string.Empty;
            textmuni.Text = string.Empty;
            combouf.Text = string.Empty;
            textemail.Text = string.Empty;
            textel.Text = string.Empty;
            textie.Text = string.Empty;
            combostatus.SelectedIndex = -1;
            combotypeemp.SelectedIndex = -1;
            textcnpj.Text = string.Empty;
        }

        async Task BuscaCnpjp()
        {
            string cnpj = textcnpj.Text;
            // URL do serviço ReceitaWS
            string apiUrl = $"https://www.receitaws.com.br/v1/cnpj/{cnpj}";

            using (HttpClient client = new HttpClient())
            {
                try
                {

                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Verifica se a requisição foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Converte a resposta para uma string
                        string content = await response.Content.ReadAsStringAsync();

                        // Faz o parse do JSON
                        var result = JsonConvert.DeserializeObject<dynamic>(content);

                        if (result.situacao != "Ativo")
                        {
                            textname.Text = result.nome;
                            nomefantasia.Text = result.nome;
                            textabertura.Text = result.abertura;
                            textdataatual.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
                            textlogradouro.Text = result.logradouro;
                            textnumber.Text = result.numero;
                            textbairro.Text = result.bairro;
                            textcep.Text = result.cep;
                            textmuni.Text = result.municipio;
                            combouf.Text = result.uf;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Erro na requisição: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private async void ButtonBuscarCnpj(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            await BuscaCnpjp();
            Cursor = Cursors.Default;
        }

        private void CadastrarCnpj(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (lic.VerificaLogin() == true)
            {
                try//verifica se o numero do endereco eh um numero de fato
                {
                    Convert.ToInt32(textnumber.Text);
                }
                catch { textnumber.Text = "0"; }
                if (!string.IsNullOrEmpty(textcnpj.Text) && !string.IsNullOrEmpty(textname.Text) && !string.IsNullOrEmpty(nomefantasia.Text) && !string.IsNullOrEmpty(textdataatual.Text) && !string.IsNullOrEmpty(textabertura.Text) && !string.IsNullOrEmpty(textie.Text) && textie.Text.Length >= 5 && !string.IsNullOrEmpty(textemail.Text) && !string.IsNullOrEmpty(textlogradouro.Text) && !string.IsNullOrEmpty(textnumber.Text) && !string.IsNullOrEmpty(textbairro.Text) && !string.IsNullOrEmpty(textmuni.Text) && !string.IsNullOrEmpty(combouf.Text) && !string.IsNullOrEmpty(textcep.Text) && !string.IsNullOrEmpty(combotypeemp.Text) && !string.IsNullOrEmpty(combostatus.Text) && textel.Text.Length == 14)
                {
                    if (editar == false)
                    {
                        GravarCnpj();
                    }
                    else
                    {
                        EditarCnpj();
                    }
                    Clear();
                }
                else
                {
                    MessageBox.Show("Alguns campos estão inválivos!");
                }
            }
            else
            {
                Homepage home = new Homepage();
            }
            Cursor = Cursors.Default;
        }
        private void GravarCnpj()
        {
            Endereco endereco = new Endereco();
            cad.GravarCnpj(util.FormataCnpj(textcnpj.Text), nomefantasia.Text, textname.Text, Convert.ToDateTime(textabertura.Text), Convert.ToDateTime(textdataatual.Text), textie.Text, combotypeemp.Text, textel.Text, textemail.Text, combostatus.Text, textlogradouro.Text, Convert.ToInt32(textnumber.Text), textcompl.Text, textbairro.Text, textmuni.Text, combouf.Text, textcep.Text);

            editar = false;
            Cursor = Cursors.Default;
            Clear();
        }
        private void EditarCnpj()
        {
            cad.EditarCnpj(id, id_end, util.FormataCnpj(textcnpj.Text), nomefantasia.Text, textname.Text, Convert.ToDateTime(textdataatual.Text), Convert.ToDateTime(textabertura.Text), textie.Text, combotypeemp.Text, textel.Text, textemail.Text, combostatus.Text, textlogradouro.Text, Convert.ToInt32(textnumber.Text), textcompl.Text, textbairro.Text, textmuni.Text, combouf.Text, textcep.Text);
            editar = false;
            Clear();
            textcnpj.Enabled = true;
            buttonenv.Text = "Gravar";
            id = 0;

        }
        private void Validacao(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textcnpj.Text))
            {
                if (editar == false)
                {
                    if (textcnpj.Text.Length == 14)
                    {
                        if (cad.NoCopy(util.FormataCnpj(textcnpj.Text)) != true)
                        {
                            MessageBox.Show("O CNPJ já está cadastrado!");
                            textcnpj.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O CNPJ não é válido!");
                        textcnpj.Text = string.Empty;
                    }
                }
            }
        }

        private void Validaemail(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textemail.Text))
            {
                if (util.IsValidEmail(textemail.Text) != true)
                {
                    MessageBox.Show("Email inválido");
                }
            }
        }

        private void CancelaOp(object sender, EventArgs e)
        {
            editar = false;
            this.Close();
        }

        private void Editar(object sender, EventArgs e)
        {
            TabelaEmpresas emp = new TabelaEmpresas(true);
            emp.Carregar();
            emp.ShowDialog();
            if (editar == true)
            {
                buttonenv.Text = "Editar";
                foreach (CadastraCnpjBack obj in list)
                {
                    id = obj.Id;
                    id_end = obj.Id_end;
                    textcnpj.Text = obj.Cnpj;
                    textcnpj.Enabled = false;
                    nomefantasia.Text = obj.Nome_f;
                    textname.Text = obj.Nome_emp;
                    textdataatual.Text = DateTime.Now.ToString();
                    textabertura.Text = obj.Datacad.ToString();
                    textie.Text = obj.Ie;
                    textemail.Text = obj.Email;
                    textlogradouro.Text = obj.Rua;
                    textnumber.Text = obj.Numero.ToString();
                    textbairro.Text = obj.Bairro;
                    textmuni.Text = obj.Cidade;
                    combouf.Text = obj.UF;
                    textcep.Text = obj.CEP;
                    combotypeemp.Text = obj.Type_f;
                    combostatus.Text = obj.Status_Format;
                    textel.Text = obj.Tel;
                    textcompl.Text = obj.Complemento;
                }
            }
        }

        public void ReturDadosCnpj(string cnpj, bool type)
        {
            editar = type;
            table.CarregarDadosEmpresas(1, cnpj);
        }
        public void AddList(string status, string type, string nomef, string nome_emp, string cnpj, string ie, string tel, string email, int id, int id_end, string uf, string cidade, string bairro, string rua, int numero, string cep, DateTime data,string complemento)
        {
            list.Add(new CadastraCnpjBack(status, type, nomef, nome_emp, cnpj, ie, tel, email, id, id_end, uf, cidade, bairro, rua, numero, cep, data,complemento));
        }

        private void combostatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RetornaCep(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textcep.Text) && textcep.Text.Length == 8)
            {
                util.ReturnInfoCep(textcep.Text);
                foreach (Endereco end in ceparmazena)
                {
                    combouf.Text = end.UF.ToUpper();
                    textbairro.Text = end.Bairro.ToUpper();
                    textlogradouro.Text = end.Rua.ToUpper();
                    textmuni.Text = end.Cidade.ToUpper();
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

        private void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            util.SomenteNumeros(e);
        }

    }
}
