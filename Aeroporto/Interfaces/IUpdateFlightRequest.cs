using Libary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporto.Interfaces
{
    public interface IUpdateFlightRequest
    {
        void UpdateFlightComplete(FlightModel model);
    }
}
