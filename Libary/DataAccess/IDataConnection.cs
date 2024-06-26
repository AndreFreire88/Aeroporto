﻿using System;
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

        void BookFlight(FlightModel flightModel, ClientModel clientModel);

        void DeleteReservation(FlightModel flightModel, ClientModel clientModel);

        void DeleteBag(BaggageModel model);

        void UpdateClient(ClientModel model);

        void UpdateFlights(FlightModel model);
        
     
    }

}
