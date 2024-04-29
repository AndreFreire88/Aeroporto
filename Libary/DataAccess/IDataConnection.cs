using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.DataAccess
{
    public interface IDataConnection
    {
        void CreateClient(ClientModel model); 

        List<ClientModel> GetClients_All();

        void CreateBag(BaggageModel model);

        void CreateFlight(FlightModel model);

        List<FlightModel> GetFlights_All();
        
     
    }

}
