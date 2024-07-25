using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Vanilla
{
    internal class Config
    {
        static string arquivo = "settings.txt";

        public Config()
        {
        }

        public void GravarDados(string endereco) //Grava o endereço do banco em um .tex
        {
            StreamWriter sw = File.CreateText(arquivo);

            sw.WriteLine(endereco);

            sw.Close();
        }



        public string Lerdados() //lê o endereço do banco
        {
            ModelBanco banco = new ModelBanco();
            BancoOracle dados = banco.RetornaEndereco();
            if (dados.User != null)
            {
                return $"Data Source={dados.Connection}:{dados.Port}/{dados.Sid};User Id ={dados.User};Password={dados.Pass};";
            }
            else
            {
                return string.Empty;
            }           
        }
    }
}
