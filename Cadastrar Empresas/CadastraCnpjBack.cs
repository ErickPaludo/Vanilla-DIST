using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class CadastraCnpjBack : Endereco
    {
        Util utilitario = new Util();
        Database db = new Database();

        private int status;
        private string status_format;
        private string nome_f;
        private string nome_emp;
        private string cnpj;
        private string ie;
        private int id;
        private int type;
        private string type_f;
        private int id_end;
        private string tel;
        private string email;
        private DateTime datacad;
        public int Status { get { return status; } set { status = value; } }
        public string Status_Format { get { return status_format; } set { status_format = value; } }
        public int Type { get { return type; } set { type = value; } }
        public string Type_f { get { return type_f; } set { type_f = value; } }
        public int Id { get { return id; } set { id = value; } }
        public int Id_end { get { return id_end; } set { id_end = value; } }
         public string Nome_f { get { return nome_f; } set { nome_f = value; } }
        public string Nome_emp { get { return nome_emp; } set { nome_emp = value; } }
        public string Cnpj { get { return cnpj; } set { cnpj = value; } }
         public string Ie { get { return ie; } set { ie = value; } }
        public string Tel { get { return tel; } set { tel = value; } }
        public string Email { get { return email; } set { email = value; } }
         public DateTime Datacad { get { return datacad; } set { datacad = value; } }

        public CadastraCnpjBack()
        {
        }

        public CadastraCnpjBack(string nome_f,int id)
        {
            this.id = id;
            this.nome_f = nome_f;
        }

        public CadastraCnpjBack(int id,string nome_emp, string cnpj)
        {
            this.id = id;
            this.nome_emp = nome_emp;
            this.cnpj = cnpj;
        }

        public CadastraCnpjBack(string status_format,string type_f, string nome_emp, string cnpj, string ie,string tel, string email,int id, int id_end, string uf, string cidade, string bairro, string rua, int numero, string cep) : base(uf, cidade, bairro, rua, numero, cep)
        {
            this.status_format = status_format;
            this.tel = tel;
            this.email = email;
            this.type_f = type_f;
            this.nome_emp = nome_emp;
            this.cnpj = cnpj;
            this.ie = ie;
            this.id = id;
            this.id_end = id_end;
        }
        public CadastraCnpjBack(string status_format, string type_f, string nome_f, string nome_emp, string cnpj, string ie, string tel, string email, int id, int id_end, string uf, string cidade, string bairro, string rua, int numero, string cep,DateTime datacad) : base(uf, cidade, bairro, rua, numero, cep)
        {
            this.status_format = status_format;
            this.tel = tel;
            this.email = email;
            this.type_f = type_f;
            this.nome_f = nome_f;
            this.nome_emp = nome_emp;
            this.cnpj = cnpj;
            this.ie = ie;
            this.id = id;
            this.id_end = id_end;
            this.datacad = datacad;
        }

        public CadastraCnpjBack(string nome_emp, string cnpj, int id, int id_end)
        {
            this.nome_emp = nome_emp;
            this.cnpj = cnpj;
            this.id = id;
            this.id_end = id_end;
        }
     
        public void GravarCnpj(string cnpj,string nomefantasia,string nome,DateTime abertura, DateTime cadastro, string insc_est,string type_cad, string tel,string email,string status, string rua, int numero, string comple, string bairro, string cidade, string uf, string cep)//Grava a empresa via banco
        {        
           db.GravarTFC(nomefantasia, nome, cnpj, abertura, cadastro, insc_est, type_cad, tel, email, status,rua,numero,comple,bairro,cidade,uf,cep);
         //   db.GravarLog($"NOVO CNPJ CADASTRADO - [ID: {id} / CNPJ: {cnpj} / NOME: {nome} / TIPO DE EMPRESA: {type_cad}]"); //grava o log
        }
        public void EditarCnpj(int id,int id_end,string cnpj, string nomefantasia, string nome, DateTime abertura, DateTime cadastro, string insc_est, string type_cad, string tel, string email, string status, string rua, int numero, string comple, string bairro, string cidade, string uf, string cep)//Grava a empresa via banco
        {
            db.EditarTFC(id,id_end,nomefantasia, nome, cnpj, abertura, cadastro, insc_est, type_cad, tel, email, status, rua, numero, comple, bairro, cidade, uf, cep);
          //  db.GravarLog($"CNPJ EDITADO - [ID: {id} / CNPJ: {cnpj} / NOME: {nome} / TIPO DE EMPRESA: {type_cad}]"); //grava o log
        }

        public bool NoCopy(string cod) //Verifica se o Cnpj está cadastrado
        {
        return db.AntiCopy("cnpj", "vnl_cad_empresas", cod);
        }
    }
}
