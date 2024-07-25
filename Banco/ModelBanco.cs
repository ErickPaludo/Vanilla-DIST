using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class ModelBanco
    {
        public void GravarEndereco(BancoOracle endereco) 
        {
            File.WriteAllText("settings.json", JsonConvert.SerializeObject(endereco));           
        }
        public BancoOracle RetornaEndereco()
        {
            try
            {
                return JsonConvert.DeserializeObject<BancoOracle>(File.ReadAllText("settings.json").ToString());
            }
            catch
            {
                return new BancoOracle();
            }
        }
    }
}
