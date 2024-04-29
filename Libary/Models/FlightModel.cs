using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    public class FlightModel
    {
        public int ID_Voo { get; set; }
        public string NumeroVoo{ get; set; }
        public string CompanhiaAerea { get; set; }

        public string Origem { get; set; }
        public string Destino { get; set; }

        public string DataHoraPartida { get; set; }
        public string DataHoraChegada { get; set; }
        public int Capacidade { get; set; }

        public List<ClientModel> Passengers { get; set; } = new List<ClientModel>();

        public FlightModel() { }

        public FlightModel(string flightNumber, string companyName, string whereFrom, string whereTo, string departureAt, string arriveAt, string capacity)
        {
            NumeroVoo = flightNumber;
            CompanhiaAerea = companyName;
            Origem = whereFrom;
            Destino = whereTo;
            DataHoraPartida = departureAt;
            DataHoraChegada = arriveAt;
            int.TryParse(capacity, out int pa);
            Capacidade = pa;
        }

        public string FlightName
        {
            get
            {
                return $"{NumeroVoo} {CompanhiaAerea} {Origem} - {Destino}";
            }
        }
    }
}
