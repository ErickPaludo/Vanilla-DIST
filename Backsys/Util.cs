
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Vanilla;
using Newtonsoft.Json.Linq;

namespace Vanilla
{
    public class Util : Endereco
    {
        #region Cabeçalho
        static public int id_user;
        static public int permissao_user = 1;
        static public string nome_user = "sys";
        private string cnpj;
        public int Permissao_user
        {
            get
            {
                return permissao_user;
            }
            set
            {
                permissao_user = value;
            }
        }
        public string Cnpj
        {
            get
            {
                return cnpj;
            }
            set
            {
                cnpj = value;
            }
        }
        public string Nome_user
        {
            get
            {
                return nome_user;
            }
            set
            {
                nome_user = value;
            }
        }
        public int Id_user
        {
            get
            {
                return id_user;
            }
            set
            {
                id_user = value;
            }
        }
        #endregion
        #region Construtores e Sobrecargas
        public Util()
        {
        }
        public Util(string cnpj, string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep, int id_endereco) : base(rua, numero, complemento, bairro, cidade, uf, cep, id_endereco)
        {
            this.cnpj = cnpj;
        }
        #endregion
        public void DadosUser(int id, int perm, string name_user)
        {
            id_user = id;
            permissao_user = perm;
            nome_user = name_user;
        }

        public string SelectFolder()
        {
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                // Mostra a janela de escolha do directorio
                DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    // Como o utilizador carregou no OK, o directorio escolhido pode ser acedido da seguinte forma:
                    return dirDialog.SelectedPath;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public void EnviarEmail(string titulo, string destinatario, string conteudo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("botvanilla1@gmail.com");
                mail.To.Add(destinatario);
                mail.Subject = titulo;
                mail.Body = $"{conteudo}\n\n\n © PLDProjects ";
                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("botvanilla1@gmail.com", "xana hxfq glgc cljk");
                    try
                    {
                        smtp.Send(mail);
                    }
                    catch
                    {
                        MessageBox.Show($"Erro ao enviar mensagem para o destinatário: {destinatario}");
                    }
                }
            }catch
            {
                MessageBox.Show($"Erro ao enviar mensagem para o destinatário: { destinatario}");
            }
        }
        public void ReturnInfoCep(string cep, int type)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string json = client.DownloadString($"https://viacep.com.br/ws/{cep}/json/");
                    dynamic cepInfo = JObject.Parse(json);

                    if (cepInfo.uf != null)
                    {
                        string uf = cepInfo.uf;
                        string bairro = cepInfo.bairro;
                        string rua = cepInfo.logradouro;
                        string cidade = cepInfo.localidade;
                        if (type == 0)
                        {
                            EnderecoFront endereco = new EnderecoFront();
                            endereco.ListaRecebe(rua, bairro, cidade, uf);
                        }
                        else
                        {
                            CadastraCNPJ endereco = new CadastraCNPJ();
                            endereco.ListaRecebe(rua, bairro, cidade, uf);
                        }
                    }
                    else
                    {
                        MessageBox.Show("CEP não encontrado.");
                    }
                }
                catch
                {
                    MessageBox.Show($"Erro ao obter dados do CEP!");
                }
            }
        }
        #region Formatadores
        public string FormataCnpj(string cnpj)
        {
            return $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12)}";
        }
        public string FormataCPF(string cpf)
        {
            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";
        }
        public void SomenteNumeros(KeyPressEventArgs e) //Metodo usado para digitar somente numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Permite somente numeros
            {
                e.Handled = true;
            }
        }
        public void SomenteLetras(KeyPressEventArgs e)
        {
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    // Se não for uma letra, ignora a entrada definindo a propriedade Handled como true
                    e.Handled = true;
                }
            }
        }
        public void SomenteUmaVirgula(KeyPressEventArgs e, string textBox) //Metodo usado para digitar somente numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == ',')
            {
                if (textBox.Contains(','))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void AntiCtrlV(KeyEventArgs e) //Bloquei ctrl v
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        public bool IsValidEmail(string email)
        {
            // Expressão regular para validar o formato do e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            // Verifica se o e-mail corresponde ao padrão
            return regex.IsMatch(email);
        }
        #endregion
    }
}
