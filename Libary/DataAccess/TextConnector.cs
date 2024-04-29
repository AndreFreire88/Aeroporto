using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary.DataAccess
{
    internal class TextConnector : IDataConnection
    {
        public void CreateBag(BaggageModel model)
        {
            throw new NotImplementedException();
        }

        public void CreateFlight(FlightModel model)
        {
            throw new NotImplementedException();
        }

        public List<BaggageModel> GetBag_ByClient(ClientModel model)
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> GetClients_All()
        {
            throw new NotImplementedException();
        }

        public List<FlightModel> GetFlights_All()
        {
            throw new NotImplementedException();
        }

        void IDataConnection.CreateClient(ClientModel model)
        {
            throw new NotImplementedException();
        }
    }
}
