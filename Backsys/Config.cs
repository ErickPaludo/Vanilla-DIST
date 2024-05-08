using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string endereco = "";

            try
            {
                StreamReader sr = new StreamReader(arquivo);
                endereco = sr.ReadLine();
                sr.Close();
            }
            catch
            {
                StreamWriter sw = File.CreateText(arquivo);
            }
           
            return endereco;
        }
    }
}
