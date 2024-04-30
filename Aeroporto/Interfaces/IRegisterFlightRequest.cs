using Libary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporto
{
    public interface IRegisterFlightRequest
    {        
        void FlightComplete(FlightModel model);
    }
}
