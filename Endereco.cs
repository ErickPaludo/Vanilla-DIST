using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Vanilla
{
    public class Endereco
    {
        Database db = new Database();
        private string rua;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        private int id_endereco;
        public string Rua { get { return rua; } set { rua = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public string Complemento { get { return complemento; } set { complemento = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string UF { get { return uf; } set { uf = value; } }
        public string CEP { get { return cep; } set { cep = value; } }
        public int Id_endereco { get { return id_endereco; } set { id_endereco = value; } }

        public Endereco()
        {
        }

        public Endereco(string rua, string bairro, string cidade, string uf)
        {
            this.rua = rua;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
        }
        public Endereco(string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep, int id_endereco)
        {
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
            this.id_endereco = id_endereco;
        }

        public Endereco(string uf, string cidade, string bairro, string rua, int numero, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
        }
        public Endereco(string uf, string cidade, string bairro, string rua, int numero, string cep, string complemento)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
            this.complemento = complemento;
        }
    }
}



