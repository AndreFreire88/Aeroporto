using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    public class FlightModel
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public string CompanyName { get; set; }

        public string WhereFrom { get; set; }
        public string WhereTo { get; set; }

        public string DepartureAt { get; set; }
        public string ArriveAt { get; set; }
        public int Capacity { get; set; }

        List<ClientModel> Passengers { get; set; } = new List<ClientModel>();

    }
}
