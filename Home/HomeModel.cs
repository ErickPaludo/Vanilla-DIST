using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class HomeModel
    {
        private static List<string> listjanelas = new List<string>();
        public List<string> LWindows { get { return listjanelas; } }

        public void AddJanela(string nome) 
        {
            listjanelas.Add(nome);
        }

        public void RemJanela(string nome)
        {
            foreach(string obj in listjanelas)
            {
                if (obj == nome)
                {
                    listjanelas.Remove(obj);
                    break;
                }
            }
        }
    }
}
