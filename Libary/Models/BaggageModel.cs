using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    public class BaggageModel
    {
        public int ID_Bagagem { get; set; }
        public int ID_Passageiro { get; set; }
        public decimal Peso { get; set; }

        public string Info
        {
            get
            {
                return $"{Peso} KG";
            }
        }

        public BaggageModel() { }

        public BaggageModel(int clientId, string weight)
        {
            ID_Passageiro = clientId;
            decimal.TryParse(weight, out decimal pa);
            Peso = pa;
        }
    }
}
